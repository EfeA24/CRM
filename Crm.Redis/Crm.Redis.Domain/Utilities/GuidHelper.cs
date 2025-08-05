using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Redis.Domain.Utilities
{
    public static class GuidHelper
    {
        public static Guid NewGuid() => Guid.NewGuid();

        public static string NewGuidString() => Guid.NewGuid().ToString("N"); // 32 karakter, tire yok
    }
}
