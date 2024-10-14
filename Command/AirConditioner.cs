using Laboratory8.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class AirConditioner
    {
        private Log log = Log.GetLogger();
        public string mode = "auto";
        public void TunrOn()
        {
            log.Logging("Включается кондиционер.");
        }
        public void TunrOff()
        {
            log.Logging("Выключается кондиционер.");
        }
        public void ChangeMode(string mode)
        {
            this.mode = mode;
            log.Logging($"Режим кондиционера изменен на {mode}.");
        }
    }
}
