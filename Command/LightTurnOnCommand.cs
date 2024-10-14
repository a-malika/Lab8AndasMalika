using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class LightTurnOnCommand : ICommand
    {
        private Light light;
        public LightTurnOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.TurnOn();
        }
        public void Undo()
        {
            light.TurnOff();
        }
    }
}
