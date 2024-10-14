using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class RemoteControl
    {
        private ICommand command;
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        public void PressButton()
        {
            command.Execute();
        }
        public void PressUndoButton()
        {
            command.Undo();
        }
    }
}
