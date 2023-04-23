using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Logging.Configuration
{
    public class LoggingConfiguration
    {
        public LoggerType LoggerType { get; set; } 
        public TextLoggerConfiguration TextLoggerConfiguration { get; set; }
        // public DatabaseLoggerConfiguration DatabaseLoggerConfiguration { get; set; }
    }
    public class TextLoggerConfiguration
    {
        public string Directory { get; set; }
        public string Filename { get; set; }
        public string FileExtension { get; set; }
    }
    public class DatabaseLoggerConfiguration
    {

    }
}