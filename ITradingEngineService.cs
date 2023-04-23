using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineService.Core
{
    internal interface ITradingEngineService
    {
        Task Run(CancellationToken token);
    }
}
