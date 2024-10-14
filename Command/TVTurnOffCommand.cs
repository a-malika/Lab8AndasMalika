using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class TVTurnOffCommand : ICommand
    {
        private Televisor tv;
        public TVTurnOffCommand(Televisor tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.TunrOff();
        }
        public void Undo()
        {
            tv.TunrOn();
        }
    }
}
