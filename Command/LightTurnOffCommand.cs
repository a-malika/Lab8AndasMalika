using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class LightTurnOffCommand : ICommand
    {
        private Light light;
        public LightTurnOffCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.TurnOff();
        }
        public void Undo()
        {
            light.TurnOn();
        }
    }
}
