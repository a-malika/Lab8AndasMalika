using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class ACTurnOffCommand : ICommand
    {
        private AirConditioner airConditioner;
        public ACTurnOffCommand(AirConditioner airConditioner)
        {
            this.airConditioner = airConditioner;
        }
        public void Execute()
        {
            airConditioner.TunrOff();
        }
        public void Undo()
        {
            airConditioner.TunrOn();
        }
    }
}
