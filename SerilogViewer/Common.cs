using Serilog;
using Serilog.Formatting.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SerilogViewer
{
    public class Common
    {
        public static ILogger GetLogger<T>() => new LoggerConfiguration()
                  .WriteTo.File(new JsonFormatter(),
                    AppDomain.CurrentDomain.GetData("DataDirectory").ToString() + "/SeriLogs.txt", rollingInterval: RollingInterval.Day, 
                    fileSizeLimitBytes: 5242880, rollOnFileSizeLimit: true, shared: true)
                  .CreateLogger().ForContext<T>();
    }
}