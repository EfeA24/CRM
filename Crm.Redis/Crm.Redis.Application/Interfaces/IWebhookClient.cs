using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Redis.Application.Interfaces
{
    public interface IWebhookClient
    {
        Task TriggerWebhookAsync(string url, object payload);
    }
}
