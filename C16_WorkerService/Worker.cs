using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace C16_WorkerService
{
    public class Worker : BackgroundService
    {
        
        private readonly ILogger<Worker> _logger;
        private HttpClient _client;
        private readonly string _url = "http://google.com";
        private HttpResponseMessage _result; 

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _client = new HttpClient();
            _logger.LogInformation("The service has been started");
            return base.StartAsync(cancellationToken);
            
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _client.Dispose();
            _logger.LogInformation("The service has been stopped");
            return base.StopAsync(cancellationToken);
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    _result = await _client.GetAsync(_url);
                    if (_result.IsSuccessStatusCode)
                    {
                        _logger.LogInformation($"Website ({_url}) is up. Status = {_result.StatusCode}");
                    }
                    else
                        _logger.LogInformation($"Website ({_url}) is down. Status = {_result.StatusCode}");
                }
                catch (Exception ex)
                {
                    _logger.LogInformation($"Website failed ({_url}) could not be found. Status = {ex.Message}");

                }

                await Task.Delay(10*1000, stoppingToken);


                
            }
        }
    }
}
