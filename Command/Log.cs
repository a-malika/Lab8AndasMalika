using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8.Command
{
    public class Log
    {
        private static Log logger;
        private static readonly object _lock = new object();
        private string file_path = "C:/Users/malik/OneDrive/Рабочий стол/output.txt";
        private Log() { }
        public static Log GetLogger()
        {
            if (logger == null)
            {
                lock (_lock)
                {
                    if (logger == null)
                    {
                        logger = new Log();
                    }
                }
            }
            return logger;
        }
        public void Logging(string message)
        {
            File.AppendAllText(file_path, message + "\n");
        }
    }
}
