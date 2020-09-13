using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WorkerService1
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

                var httpClient = HttpClientFactory.Create();

                var url = "https://api.openweathermap.org/data/2.5/onecall?lat=33.441792&lon=-94.037689&exclude=hourly,daily,minutely&appid=62d274c03fa45dffcda1b3b257b696ce";
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
                if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                {
                    var content = httpResponseMessage.Content;
                    var data = await content.ReadAsAsync<Current>();

                    Console.WriteLine(data);
                }
                else
                {
                    Console.WriteLine($"Error: " + httpResponseMessage.StatusCode);
                }

                await Task.Delay(10000, stoppingToken);
            }
        }


        public class Rootobject
        {
            public float lat { get; set; }
            public float lon { get; set; }
            public string timezone { get; set; }
            public int timezone_offset { get; set; }
            public Current current { get; set; }
        }

        public class Current
        {
            public int dt { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
            public float temp { get; set; }
            public float feels_like { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
            public float dew_point { get; set; }
            public float uvi { get; set; }
            public int clouds { get; set; }
            public int visibility { get; set; }
            public float wind_speed { get; set; }
            public int wind_deg { get; set; }
            public Weather[] weather { get; set; }

            public override string ToString()
            {
                return $"{sunrise}";
            }
        }

        public class Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
    }
}
