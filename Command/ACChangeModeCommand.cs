using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class ACChangeModeCommand : ICommand
    {
        private AirConditioner airConditioner;
        public ACChangeModeCommand(AirConditioner airConditioner)
        {
            this.airConditioner = airConditioner;
        }
        public void Execute()
        {
            Console.WriteLine("На какой режим поменять кондиционер?");
            airConditioner.ChangeMode(Console.ReadLine());
        }
        public void Undo()
        {
            airConditioner.ChangeMode("auto");
        }
    }
}
