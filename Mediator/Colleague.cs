using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public abstract class Colleague
    {
        public string Name { get; set; }
        protected IMediator Mediator { get; set; }
        public Colleague(string name, IMediator mediator)
        {
            Name = name;
            Mediator = mediator;
            mediator.RegisterColleague(this);
        }
        public abstract void SendPublicMessage(string message);
        public abstract void SendChatMessage(string message, Chat chat);
        public abstract void SendPrivateMessage(string message, Colleague colleague);
        public abstract void RecieveMessage(string message, string type);
    }
}
