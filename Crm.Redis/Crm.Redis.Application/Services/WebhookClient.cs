using Crm.Redis.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Redis.Application.Services
{
    public class WebhookClient : IWebhookClient
    {
        private readonly HttpClient _httpClient;

        public WebhookClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task TriggerWebhookAsync(string url, object payload)
        {
            await _httpClient.PostAsJsonAsync(url, payload);
        }
    }
}
