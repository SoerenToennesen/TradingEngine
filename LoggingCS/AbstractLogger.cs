using System;
using System.Collections.Generic;
using System.Text;
using TradingEngineServer.Logging;

namespace TradingEngineServer.Logging
{
    public abstract class AbstractLogger : ILogger
    {
        protected AbstractLogger() { }
        public void Debug(string module, string message) => Log(LogLevel.Debug, module, message);
        public void Debug(string module, Exception exception) => Log(LogLevel.Debug, module, $"{exception}");
        public void Info(string module, string message) => Log(LogLevel.Info, module, message);
        public void Info(string module, Exception exception) => Log(LogLevel.Info, module, $"{exception}");
        public void Warning(string module, string message) => Log(LogLevel.Warning, module, message);
        public void Warning(string module, Exception exception) => Log(LogLevel.Warning, module, $"{exception}");
        public void Error(string module, string message) => Log(LogLevel.Error, module, message);
        public void Error(string module, Exception exception) => Log(LogLevel.Error, module, $"{exception}");
        protected abstract void Log(LogLevel logLevel, string module, string message);
    }
}
