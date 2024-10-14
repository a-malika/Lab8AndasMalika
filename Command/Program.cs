using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            Televisor tv = new Televisor();
            AirConditioner conditioner = new AirConditioner();
            RemoteControl remoteControl = new RemoteControl();

            ICommand command1 = new LightTurnOnCommand(light);
            ICommand command2 = new LightTurnOffCommand(light);
            ICommand command3 = new TVTurnOnCommand(tv);
            ICommand command4 = new TVTurnOffCommand(tv);
            ICommand command5 = new ACTurnOnCommand(conditioner);
            ICommand command6 = new ACTurnOffCommand(conditioner);
            ICommand command7 = new ACChangeModeCommand(conditioner);


            remoteControl.SetCommand(command1);
            remoteControl.PressButton();
            remoteControl.PressUndoButton();

            remoteControl.SetCommand(command2);
            remoteControl.PressButton();
            remoteControl.PressUndoButton();

            remoteControl.SetCommand(command3);
            remoteControl.PressButton();
            remoteControl.PressUndoButton();

            remoteControl.SetCommand(command4);
            remoteControl.PressButton();
            remoteControl.PressUndoButton();

            remoteControl.SetCommand(command5);
            remoteControl.PressButton();
            remoteControl.PressUndoButton();

            remoteControl.SetCommand(command6);
            remoteControl.PressButton();
            remoteControl.PressUndoButton();

            remoteControl.SetCommand(command7);
            remoteControl.PressButton();
            remoteControl.PressUndoButton();
        }
    }
}
