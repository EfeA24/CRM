using Crm.Redis.Application.Interfaces;
using Crm.Redis.Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;
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

        public RedisStorageService(IConnectionMultiplexer redis)
        {
            _redisDb = redis.GetDatabase();
        }

        public async Task StoreAsync(string key, ExcelPath data)
        {
            var json = JsonConvert.SerializeObject(data);
            await _redisDb.StringSetAsync(key, json, TimeSpan.FromHours(1));
        }
    }
}
