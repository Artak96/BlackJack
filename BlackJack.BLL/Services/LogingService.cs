using BlackJack.Core.Abstractions.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BLL.Services
{
    public class LogingService : ILogingService
    {

        private readonly HttpClient _client;
        private readonly string _loggingServiceUrl;
        public LogingService(HttpClient client)
        {
            _client = client;
           // _loggingServiceUrl = LogApiUrl;
        }

        public async Task ErrorAsync(Exception exception, string caller)
        {
            var logModel = new
            {
                Caller = caller ?? "Default",
                DateTime = DateTime.UtcNow,
                Message = JsonConvert.SerializeObject(exception)
            };
            var json = JsonConvert.SerializeObject(logModel);
            StringContent data = new(json, Encoding.UTF8, "application/json");
            //publish event or send like httpClient
            //await _client.PostAsync($"{_loggingServiceUrl}", data);
        }

        public async Task InfoAsync(string message, [CallerMemberName] string? callerMethodName = default)
        {

            MethodBase? method = new StackTrace()
                                         .GetFrames()
                                         .Select(frame => frame.GetMethod())
                                         .FirstOrDefault(item => item?.Name == callerMethodName);

            string caller = method?.DeclaringType + "." + callerMethodName;
            var logModel = new
            {
                Caller = caller,
                DateTime = DateTime.UtcNow,
                Data = JsonConvert.SerializeObject(message)
            };
            var json = JsonConvert.SerializeObject(logModel);
            StringContent data = new(json, Encoding.UTF8, "application/json");

            //publish event or send like httpClient
            //await _client.PostAsync($"{_loggingServiceUrl}", data);
        }

        public async Task DebugAsync(string message, [CallerMemberName] string? callerMethodName = default)
        {
            MethodBase? method = new StackTrace()
                                        .GetFrames()
                                        .Select(frame => frame.GetMethod())
                                        .FirstOrDefault(item => item?.Name == callerMethodName);

            string caller = method?.DeclaringType + "." + callerMethodName;

            var logModel = new
            {
                Caller = caller,
                DateTime = DateTime.UtcNow,
                Data = JsonConvert.SerializeObject(message)
            };
            var json = JsonConvert.SerializeObject(logModel);
            StringContent data = new(json, Encoding.UTF8, "application/json");

            //publish event or send like httpClient
            //await _client.PostAsync($"{_loggingServiceUrl}", data);
        }
    }
}
