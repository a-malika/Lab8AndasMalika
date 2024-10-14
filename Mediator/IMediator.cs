using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public interface IMediator
    {
        void RegisterColleague(Colleague colleague);
        void RegisterChat(Chat chat);
        void SendPublicMessage(string message, Colleague colleague);
        void SendChatMessage(string message, Colleague colleague, Chat chat);
        void SendPrivateMessage(string message, Colleague colleague1, Colleague colleague2);
    }
}
