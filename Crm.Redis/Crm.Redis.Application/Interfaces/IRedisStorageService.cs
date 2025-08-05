using Crm.Redis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Redis.Application.Interfaces
{
    public interface IRedisStorageService
    {
        Task StoreAsync(string key, ExcelPath data);
    }
}
