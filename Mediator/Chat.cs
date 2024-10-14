using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class Chat
    {
        private Log log = Log.GetLogger();
        public string Name { get; set; }
        public List<Colleague> colleagueList { get; private set; }
        private IMediator Mediator { get; set; }
        public Chat(string name, IMediator mediator)
        {
            Name = name;
            colleagueList = new List<Colleague>();
            Mediator = mediator;
            mediator.RegisterChat(this);
        }
        public void AddColleague(Colleague colleague)
        {
            colleagueList.Add(colleague);
            log.Logging($"Пользователь {colleague.Name} добавлен в чат '{Name}'.");
            Console.WriteLine("Пользователь {0} добавлен в чат '{1}'.", colleague.Name, Name);
        }
        public void RemoveColleague(Colleague colleague)
        {
            colleagueList.Remove(colleague);
            log.Logging($"Пользователь {colleague.Name} удален из чата '{Name}'.");
            Console.WriteLine("Пользователь {0} удален из чата '{1}'.", colleague.Name, Name);
        }
    }
}
