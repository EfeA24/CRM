using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Redis.Domain.Utilities
{
    public static class KeyGenerator
    {
        public static string GenerateExcelKey(Guid id)
        {
            return $"excel:{id}";
        }
    }
}
