using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Redis.Domain.Utilities
{
    public static class FileHelper
    {
        public static bool IsExcelFile(string fileName)
        {
            var ext = Path.GetExtension(fileName).ToLowerInvariant();
            return ext == ".xls" || ext == ".xlsx";
        }

        public static bool IsFileSizeValid(long fileSize, long maxFileSizeInMb = 5)
        {
            return fileSize <= maxFileSizeInMb * 1024 * 1024;
        }

        public static long GetFileSizeInBytes(string filePath)
        {
            return new FileInfo(filePath).Length;
        }
    }
}
