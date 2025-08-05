using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Redis.Domain.Utilities
{
    public static class StringHelper
    {
        public static string SanitizeFileName(string fileName)
        {
            return Path.GetFileNameWithoutExtension(fileName)
                       .Replace(" ", "_")
                       .Replace("ç", "c")
                       .Replace("ğ", "g")
                       .Replace("ş", "s")
                       .Replace("ü", "u")
                       .Replace("ö", "o")
                       .Replace("ı", "i");
        }
    }
}
