using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Redis.Application.Options
{
    public class RedisOptions
    {
        public int TtlHours { get; set; } = 1;
    }
}
