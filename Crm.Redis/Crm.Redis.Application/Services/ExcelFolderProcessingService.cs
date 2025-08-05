using Crm.Redis.Application.Interfaces;
using Crm.Redis.Domain.Entities;
using Crm.Redis.Domain.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Redis.Application.Services
{
    public class ExcelFolderProcessingService
    {
        private readonly IRedisStorageService _redis;
        private readonly IWebhookClient _webhook;

        public ExcelFolderProcessingService(IRedisStorageService redis, IWebhookClient webhook)
        {
            _redis = redis;
            _webhook = webhook;
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

                var excelPath = new ExcelPath
                {
                    FileName = sanitized,
                    FilePath = file,
                    UploadedAt = DateTime.UtcNow
                };

                var redisKey = KeyGenerator.GenerateExcelKey(excelPath.Id);

                await _redis.StoreAsync(redisKey, excelPath);
                await _webhook.TriggerWebhookAsync("https://n8n.yourserver.com/webhook/excel", new { key = redisKey });
            }
        }
    }
}
