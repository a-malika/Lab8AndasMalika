using Laboratory8.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class Televisor
    {
        private Log log = Log.GetLogger();
        public void TunrOn()
        {
            log.Logging("Включается телевизор.");
        }
        public void TunrOff()
        {
            log.Logging("Выключается телевизор.");
        }
    }
}
