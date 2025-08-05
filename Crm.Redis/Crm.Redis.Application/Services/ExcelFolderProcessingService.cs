using Crm.Redis.Application.Interfaces;
using Crm.Redis.Domain.Entities;
using Crm.Redis.Domain.Utilities;
using ExcelDataReader;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Crm.Redis.Application.Services
{
    public class ExcelFolderProcessingService
    {
        private readonly IRedisStorageService _redis;
        private readonly IWebhookClient _webhook;
        private readonly IConfiguration _configuration;

        public ExcelFolderProcessingService(IRedisStorageService redis, IWebhookClient webhook, IConfiguration configuration)
        {
            _redis = redis;
            _webhook = webhook;
            _configuration = configuration;
        }

        public async Task ProcessFolderAsync(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine($"Folder not found: {folderPath}");
                return;
            }

            string[] files;
            try
            {
                files = Directory.GetFiles(folderPath, "*.xlsx");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error accessing folder {folderPath}: {ex.Message}");
                return;
            }
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                if (!FileHelper.IsExcelFile(fileName)) continue;

                var fileSize = FileHelper.GetFileSizeInBytes(file);
                if (!FileHelper.IsFileSizeValid(fileSize)) continue;

                var sanitized = StringHelper.SanitizeFileName(fileName);

                var data = ReadExcel(file);

                var excelPath = new ExcelPath
                {
                    FileName = sanitized,
                    FilePath = file,
                    UploadedAt = DateTime.UtcNow,
                    Data = data
                };

                var redisKey = KeyGenerator.GenerateExcelKey(excelPath.Id);

                await _redis.StoreAsync(redisKey, excelPath);
                var webhookUrl = _configuration["N8N:WebhookUrl"] ?? "http://localhost:5678/webhook/excel";
                await _webhook.TriggerWebhookAsync(webhookUrl, new { key = redisKey, data });
            }
        }

        private static List<Dictionary<string, object?>> ReadExcel(string path)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using var stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using var reader = ExcelReaderFactory.CreateReader(stream);
            var config = new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration { UseHeaderRow = true }
            };
            var dataSet = reader.AsDataSet(config);
            var table = dataSet.Tables[0];
            var rows = new List<Dictionary<string, object?>>();
            foreach (DataRow row in table.Rows)
            {
                var dict = new Dictionary<string, object?>();
                foreach (DataColumn col in table.Columns)
                {
                    dict[col.ColumnName] = row[col];
                }
                rows.Add(dict);
            }
            return rows;
        }
    }
}
