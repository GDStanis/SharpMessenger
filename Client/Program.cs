using System;
using Terminal.Gui;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using System.Timers;

namespace Client
{
    [Serializable]
    public class Message
    {
        public string UserName = "";
        public string Text = "";
        public DateTime TimeStamp;
    }
    class Program
    {
        private static MenuBar Menu;
        private static Window mainWin;
        private static Window messagesBox;
        private static Label usernameLabel;
        private static Label messageLabel;
        private static TextField UserField;
        private static TextField MessageField;
        private static Button SendBttn;

        private static List<Message> Data = new List<Message>();
        static void Main(string[] args)
        {
            Application.Init();

            //          Верхнее меню приложения.
            Menu = new MenuBar(new MenuBarItem[] {
                    new MenuBarItem("_App", new MenuItem[] {
                    new MenuItem("_Quit", "-- Close the App.", Application.RequestStop),
                    }),
                    })

            {
                X = 0,
                Y = 0,
                Width = Dim.Fill(),
                Height = 1,

            };
            Application.Top.Add(Menu);

            //          Главное окно приложения.
            mainWin = new Window()
            {
                X = 0,
                Y = 1,
                Width = Dim.Fill(),
                Height = Dim.Fill(),
                Title = "Sharp Messenger",
            };
            Application.Top.Add(mainWin);

            //          MessagesBox.
            messagesBox = new Window()
            {
                X = 0,
                Y = 0,
                Width = mainWin.Width,
                Height = mainWin.Height - 2,

            };
            mainWin.Add(messagesBox);

            //          Надпись UserName.
            usernameLabel = new Label()
            {
                X = 0,
                Y = Pos.Bottom(mainWin) - 5,
                Width = 15,
                Height = 1,
                Text = "UserName:",
            };
            mainWin.Add(usernameLabel);

            //          Надпись Message.
            messageLabel = new Label()
            {
                X = 0,
                Y = Pos.Bottom(mainWin) - 4,
                Width = 15,
                Height = 1,
                Text = "Message:",
            };
            mainWin.Add(messageLabel);

            //          Поле UserName.
            UserField = new TextField()
            {
                X = 15,
                Y = Pos.Bottom(mainWin) - 5,
                Width = mainWin.Width - 15,
                Height = 1,
            };
            mainWin.Add(UserField);

            //          Поле Message.
            MessageField = new TextField()
            {
                X = 15,
                Y = Pos.Bottom(mainWin) - 4,
                Width = mainWin.Width - 15,
                Height = 1,
            };
            mainWin.Add(MessageField);

            //          Кнопка Send.
            SendBttn = new Button()
            {
                X = Pos.Right(mainWin) - 15,
                Y = Pos.Bottom(mainWin) - 4,
                Width = 15,
                Height = 1,
                Text = " SEND ",
            };
            mainWin.Add(SendBttn);
            SendBttn.Clicked += SendClick;

            //          Цикл получения сообщений.
            int lastMsgNum = 0;
            Timer updLoop = new Timer();
            updLoop.Interval = 1000;
            updLoop.Elapsed += (object sender, ElapsedEventArgs e) => {
                Message ms = GetMes(lastMsgNum);
                if (ms != null)
                {
                    Data.Add(ms);
                    MesUpd();
                    lastMsgNum++;
                }
            };
            updLoop.Start();


            Application.Run();
        }
        //      Клик на Send.
        static void SendClick()
        {
            if ((UserField.Text.Length != 0) && (MessageField.Text.Length != 0))
            {
                Message ms = new Message()
                {
                    UserName = UserField.Text.ToString(),
                    Text = MessageField.Text.ToString(),
                };
                SendMes(ms);
                MessageField.Text = "";
            }
        }
        //      Синхронизация списка сообщений
        //      с представлением.
        static void MesUpd()
        {
            messagesBox.RemoveAll();
            int offset = 0;
            for (var i = Data.Count - 1; i >= 0; i--)
            {
                View txt = new View()
                {
                    X = 0,
                    Y = offset,
                    Width = messagesBox.Width,
                    Height = 1,
                    Text = $"[{Data[i].UserName}]: {Data[i].Text}",
                };
                messagesBox.Add(txt);
                offset++;
            }
            Application.Refresh();
        }

        //      Отправка сообщений на сервер.
        static void SendMes(Message txt)
        {
            WebRequest req = WebRequest.Create("http://localhost:5000/api/Mes");
            req.Method = "POST";
            string postData = JsonConvert.SerializeObject(txt);
            byte[] bytes = Encoding.UTF8.GetBytes(postData);
            req.ContentType = "application/json";
            req.ContentLength = bytes.Length;
            Stream reqStream = req.GetRequestStream();
            reqStream.Write(bytes);
            reqStream.Close();
            req.GetResponse();
        }

        //      Получение сообщений с сервера.
        static Message GetMes(int id)
        {
            WebRequest req = WebRequest.Create($"http://localhost:5000/api/Mes/{id}");
            WebResponse resp = req.GetResponse();
            string msg = new StreamReader(resp.GetResponseStream()).ReadToEnd();

            if (msg == " Not found. ") return null;
            return JsonConvert.DeserializeObject<Message>(msg);

        }
    }
}
