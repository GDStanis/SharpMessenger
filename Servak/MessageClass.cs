using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Servak;

namespace Servak
{
    [Serializable]
    public class Message
    {
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }

//      Конструктор, который добавляет первое сообщение
//      о запуске сервера.
        public Message()
        {
            this.UserName = "Admin";
            this.Text = "Server is active now.";
            this.TimeStamp = DateTime.UtcNow;
        }

//      Метод, который добавляет сообщения по
//      полям UserName и Text, а также использует TimeStamp.
        public Message(string UserName, string Text)
        {
            this.UserName = UserName;
            this.Text = Text;
            this.TimeStamp = DateTime.UtcNow;
        }
    }

    [Serializable]
    public class MessageClass
    {
//      Динамическое хранилище сообщений.
        public List<Message> Data = new List<Message>();

        public void Add(Message ms)
        {
            ms.TimeStamp = DateTime.UtcNow;
            Data.Add(ms);
            Console.WriteLine(Data.Count);
        }

        public void Add(string UserName, string Text)
        {
            Message txt = new Message(UserName, Text);
            Data.Add(txt);
            Console.WriteLine(Data.Count);
        }

        public Message Get(int num)
        {
            return Data.ElementAt(num);
        }

        public int CountMes()
        {
            return Data.Count();
        }

        public MessageClass()
        {
            Data.Clear();
            Message ms = new Message();
            Data.Add(ms);
        }
    }

}
