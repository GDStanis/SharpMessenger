using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

//  Класс выдачи токенов.
    public class tokens
    {
        public int token { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public tokens()
        {
            this.token = -1;
            this.login = "none";
            this.password = "none";
        }

        public tokens(int token, string login, string password)
        {
            this.token = token;
            this.login = login;
            this.password = password;
        }

    }

//  Класс сессий мессенджера.
    public class SessionsClass
    {
//      Динамическое хранилище токенов.
        public List<tokens> tokensList = new List<tokens>();

//      Метод добавления нового токена.
        public void addToken()
        {
            Random rand = new Random();
            int int_token = rand.Next(1000 * 1000, 10 * 1000 * 1000);
            tokens token_record = new tokens(int_token, "Check", "GDS");
            token_record.login = "Check";
            token_record.password = "GDS";
            token_record.token = int_token;
            tokensList.Add(token_record);
        }

//      Генератор значений токенов.        
        public int GenToken()
        {
            Random rand = new Random();
            return rand.Next(10 * 1000, 100 * 1000);
        }

//      Метод аутентификации.
        public int login(AuthData auth_data)
        {
            string login = auth_data.login;
            string password = auth_data.password;
            bool login_exist = false;
            int row_num = 0;
            foreach (tokens item in tokensList)
            {
                if (item.login == login)
                {
                    login_exist = true;
                    if (item.password == password)
                    {
                        int token = GenToken();
                        tokens record_token = new tokens(token, login, password);
                        tokensList[row_num].token = token;
                        //tokensList.Add(record_token);
                        Console.WriteLine($"New auth! Login: [{login}]; Password: [{password}]; Token: [{token}].");
                        return token;
                    }
                    else
                    {
                        return -1;
                    }
                }
                row_num++;
            }
            if (!login_exist)
            {
                return -2;
            }
            return -200;   // ошибка логики
        }

//      Метод регистрации.
        public int registration(AuthData auth_data)
        {
            bool login_exist = false;
            foreach (tokens item in tokensList)
            {
                if (item.login == auth_data.login)
                {
                    login_exist = true;
                }
            }
            if (!login_exist)
            {
                int token = GenToken();
                tokens record_token = new tokens(token, auth_data.login, auth_data.password);
                tokensList.Add(record_token);
                Console.WriteLine($"New Registration! Login: [{auth_data.login}]; Password: [{auth_data.password}]; Token: [{token}]");
                return token;
            }
            return -1;
        }

//      Метод записи логов сессий в файл.
        public void SaveToFile(string filename = "sharp_datafile.json")
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            try
            {
                string Data = JsonConvert.SerializeObject(Program.Sessions);

                using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(Data);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

//      Загрузка логов предыдущей сессии из файла.
        public void LoadFromFile(string filename = "sharp_datafile.json")
        {
            long size = 0;
            if (File.Exists(filename))
            {
                System.IO.FileInfo file = new System.IO.FileInfo(filename);
                size = file.Length;
            }
            if (size > 0)
            {
                try
                {
                    Console.WriteLine("Complete.");
                    string json = "";
                    using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default))
                    {
                        json = sr.ReadToEnd();
                    }
                    Program.Sessions = JsonConvert.DeserializeObject<SessionsClass>(json);
                    for (int i = 0; i < tokensList.Count; i++)
                    {
                        tokensList[i].token = 0;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                 Console.WriteLine($"Data loaded: [{this.tokensList.Count}]");
            }
        }


    }
//  Класс записи данных по логину и паролю.
    public class AuthData
    {
        public string login { get; set; }
        public string password { get; set; }
    }
}
