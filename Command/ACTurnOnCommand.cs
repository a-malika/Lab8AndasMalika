using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class ACTurnOnCommand : ICommand
    {
        private AirConditioner airConditioner;
        public ACTurnOnCommand(AirConditioner airConditioner)
        {
            this.airConditioner = airConditioner;
        }
        public void Execute()
        {
            airConditioner.TunrOn();
        }
        public void Undo()
        {
            airConditioner.TunrOff();
        }
    }
}
