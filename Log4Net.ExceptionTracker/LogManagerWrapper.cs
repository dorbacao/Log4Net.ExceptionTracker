using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net.ExceptionTracker
{
    public static class LogManagerWrapper
    {

        public static ILog GetLogger(Type type)
        {
            if (LogManager.GetCurrentLoggers().Length == 0)
            {
                LoadConfig();
            }
            return LogManager.GetLogger(type);
        }

        private static void LoadConfig()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
    }

}
