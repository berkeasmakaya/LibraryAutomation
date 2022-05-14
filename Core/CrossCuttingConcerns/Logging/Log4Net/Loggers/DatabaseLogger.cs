using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging.Log4Net.Layouts.Loggers
{
    public class DatabaseLogger:LoggerServiceBase
    {
        
        public DatabaseLogger() : base("DatabaseLogger")
        {
        }
    }
}
