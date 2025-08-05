using Crm.Redis.Application.Interfaces;
using Crm.Redis.Application.Options;
using Crm.Redis.Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Redis.Application.Services
{
    public class RedisStorageService : IRedisStorageService
    {
        private readonly StackExchange.Redis.IDatabase _redisDb;
        private readonly TimeSpan _ttl;

        public RedisStorageService(IConnectionMultiplexer redis, IOptions<RedisOptions> options)
        {
            _redisDb = redis.GetDatabase();
            var hours = options.Value.TtlHours <= 0 ? 1 : options.Value.TtlHours;
            _ttl = TimeSpan.FromHours(hours);
        }

        public async Task StoreAsync(string key, ExcelPath data)
        {
            var json = JsonConvert.SerializeObject(data);
            await _redisDb.StringSetAsync(key, json, _ttl);
        }
    }
}
