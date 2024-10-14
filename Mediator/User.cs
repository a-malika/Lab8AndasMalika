using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class User : Colleague
    {
        private Log log = Log.GetLogger();
        public User(string name, IMediator mediator) : base(name, mediator) { }

        public override void SendPublicMessage(string message)
        {
            Mediator.SendPublicMessage(message, this);
        }
        public override void SendChatMessage(string message, Chat chat)
        {
            Mediator.SendChatMessage(message, this, chat);
        }
        public override void SendPrivateMessage(string message, Colleague colleague)
        {
            Mediator.SendPrivateMessage(message, this, colleague);
        }
        public override void RecieveMessage(string message, string type)
        {
            log.Logging($"{type}: Сообщение для {Name}: {message}.");
            Console.WriteLine($"{type}: Сообщение для {Name}: '{message}'.");
        }
    }
}
