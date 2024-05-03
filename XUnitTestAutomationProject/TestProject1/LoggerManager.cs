using log4net;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Log4Net.config")]

namespace TestProject1
{
    public class LoggerManager
    {
        public LoggerManager()
        {
            this.Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);
            string logName = this.GetType().Assembly.GetName().Name + ".log";
            log4net.GlobalContext.Properties["LogName"] = logName;
        }

        public ILog Log { get; set; }
    }
}
