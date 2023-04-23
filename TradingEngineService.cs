using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading;
using System.Threading.Tasks;
using TradingEngineServer.Core.Configuration;

namespace TradingEngineService.Core
{
    internal class TradingEngineService : BackgroundService, ITradingEngineService
    {
        private readonly ILogger<TradingEngineService> _logger;
        private readonly TradingEngineServiceConfiguration _tradingEngineServiceConfig;
        public TradingEngineService(ILogger<TradingEngineService> logger, IOptions<TradingEngineServiceConfiguration> config)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _tradingEngineServiceConfig = config.Value ?? throw new ArgumentNullException(nameof(config));
        }

        public Task Run(CancellationToken token) => ExecuteAsync(token);

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

            }
            return Task.CompletedTask;
        }
    }
}
