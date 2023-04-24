using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TradingEngineServer.Core.Configuration;
using TradingEngineServer.Logging;
using TradingEngineServer.Logging.Configuration;

namespace TradingEngineServer.Core
{
    public sealed class TradingEngineServerHostBuilder
    {
        public static IHost BuildTradingEngineService() => Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
        {
            // Start with configuration
            services.AddOptions();
            services.Configure<TradingEngineServerConfiguration>(context.Configuration.GetSection(nameof(TradingEngineServerConfiguration)));
            services.Configure<LoggingConfiguration>(context.Configuration.GetSection(nameof(LoggingConfiguration)));

            // Add singleton objects
            services.AddSingleton<ITradingEngineServer, TradingEngineServer>();
            services.AddSingleton<ITextLogger, TextLogger>();

            // Add hosted service
            services.AddHostedService<TradingEngineServer>();
        }).Build();
    }
}
