using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class TVTurnOnCommand : ICommand
    {
        private Televisor tv;
        public TVTurnOnCommand(Televisor tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.TunrOn();
        }
        public void Undo()
        {
            tv.TunrOff();
        }
    }
}
