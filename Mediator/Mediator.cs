using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory8
{
    public class Mediator : IMediator
    {
        private Log log = Log.GetLogger();
        private List<Colleague> colleagueList;
        private List<Chat> chatList;
        public Mediator()
        {
            colleagueList = new List<Colleague>();
            chatList = new List<Chat>();
        }
        public void RegisterColleague(Colleague colleague)
        {
            colleagueList.Add(colleague);
            log.Logging($"Пользователь {colleague.Name} добавлен в глобальный чат.");
            Console.WriteLine("Пользователь {0} добавлен в глобальный чат.", colleague.Name);
        }
        public void RegisterChat(Chat chat)
        {
            chatList.Add(chat);
            log.Logging($"Добавлен новый чат '{chat.Name}'.");
            Console.WriteLine("Добавлен новый чат '{0}'.", chat.Name);
        }
        public void SendPublicMessage(string message, Colleague colleague)
        {
            foreach (var col in colleagueList)
            {
                if (col != colleague)
                {
                    col.RecieveMessage(message, "Глобальный чат");
                }
            }
        }
        public void SendChatMessage(string message, Colleague colleague, Chat chat)
        {
            if (chat.colleagueList.Contains(colleague))
            {
                foreach (var col in chat.colleagueList)
                {
                    if (col != colleague)
                    {
                        col.RecieveMessage(message, $"Чат '{chat.Name}'");
                    }
                }
            }
            else
            {
                log.Logging($"Пользователь {colleague.Name} не может отправить сообщение в чат '{chat.Name}'. Он не зарегистрирован в нем.");
                Console.WriteLine("Пользователь {0} не может отправить сообщение в чат '{1}'. Он не зарегистрирован в нем.", colleague.Name, chat.Name);
            }
        }
        public void SendPrivateMessage(string message, Colleague colleague1, Colleague colleague2)
        {
            colleague2.RecieveMessage(message, $"{colleague1.Name}");
        }

    }
}
