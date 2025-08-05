using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Redis.Persistence.Data
{
    public class RedisContext
    {
        private readonly IConnectionMultiplexer _connection;
        public IDatabase Database => _connection.GetDatabase();

        public RedisContext(IConnectionMultiplexer connection)
        {
            _connection = connection;
        }
    }
}
