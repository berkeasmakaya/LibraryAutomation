using log4net.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using log4net;

namespace Core.CrossCuttingConcerns.Logging.Log4Net
{
    public class LoggerServiceBase
    {
        private ILog _log;
        public LoggerServiceBase(string name)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(File.OpenRead("log4net.config"));

            ILoggerRepository loggerRepository = LogManager.CreateRepository(Assembly.GetEntryAssembly(),
                typeof(log4net.Repository.Hierarchy.Hierarchy));
            log4net.Config.XmlConfigurator.Configure(loggerRepository, xmlDocument["log4net"]);
            _log = LogManager.GetLogger(loggerRepository.Name, name);
        }

        public bool isInfoEnabled => _log.IsInfoEnabled;
        public bool isDebugEnabled => _log.IsDebugEnabled;
        public bool isWarnEnabled => _log.IsWarnEnabled;
        public bool isFatalEnabled => _log.IsFatalEnabled;
        public bool isErrorEnabled => _log.IsErrorEnabled;


        public void Info(object logMessage)
        {
            if (isInfoEnabled)
                _log.Info(logMessage);
            
        }
        public void Debug(object logMessage)
        {
            if (isInfoEnabled)
                _log.Debug(logMessage);

        }
        public void Warn(object logMessage)
        {
            if (isInfoEnabled)
                _log.Warn(logMessage);

        }
        public void Fatal(object logMessage)
        {
            if (isInfoEnabled)
                _log.Fatal(logMessage);

        }
        public void Error(object logMessage)
        {
            if (isInfoEnabled)
                _log.Error(logMessage);

        }
    }
}
