using Laboratory8.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class Light
    {
        private Log log = Log.GetLogger();
        public void TurnOn()
        {
            log.Logging("Включается свет.");
        }
        public void TurnOff()
        {
            log.Logging("Выключается свет.");
        }
    }
}
