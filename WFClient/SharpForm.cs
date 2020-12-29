using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFClient
{

    public partial class SharpForm : Form
    {
//      Глобальные переменные для работы
//      с окнами регистрации и аутентификации.
        int lastMsgID = 0;
        RegForm _formReg = new RegForm();
        AuthForm _formAuth = new AuthForm();
        public TextBox TB_UserName = new TextBox();
        public int int_token;
        public Message message;
         
        public SharpForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

//      Таймер, отвечающий за отправку сообщений и вывод их в окно чата.
        private void updLoop_Tick(object sender, EventArgs e)
        {
            Message msg = GetMes(lastMsgID);
            if (msg != null)
            {
                MesList.Items.Add($"({lastMsgID}) {msg.TimeStamp} [{msg.UserName}] {msg.Text}");
                lastMsgID++;
            }
        }

//      Функция кнопки Send.
        private void SendBttn_Click(object sender, EventArgs e)
        {
            if (int_token == 0)
            {
                MessageBox.Show("First you should log in for writing.");
            }
            else
            {
                SendMes(new Message()
                {
                    UserName = UserField.Text,
                    Text = MesField.Text,
                });
            }
        }

//      Отправка сообщений на сервер.
        void SendMes(Message txt)
        {
            WebRequest req = WebRequest.Create("http://localhost:5000/api/Mes");
            req.Method = "POST";
            string postData = JsonConvert.SerializeObject(txt);
            //byte[] bytes = Encoding.UTF8.GetBytes(postData);
            req.ContentType = "application/json";
            //req.ContentLength = bytes.Length;
            StreamWriter reqStream = new StreamWriter(req.GetRequestStream());
            reqStream.Write(postData);
            reqStream.Close();
            req.GetResponse();
        }

//      Получение сообщений с сервера.
        Message GetMes(int id)
        {
            try
            {
                WebRequest req = WebRequest.Create($"http://localhost:5000/api/Mes/{id}");
                WebResponse resp = req.GetResponse();
                string ms = new StreamReader(resp.GetResponseStream()).ReadToEnd();

                if (ms == " Not found. ") return null;
                return JsonConvert.DeserializeObject<Message>(ms);
            }
            catch
            {
                return null;
            }
        }
        [Serializable]
        public class Message
        {
            public string UserName = "";
            public string Text = "";
            public DateTime TimeStamp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
//      Функция кнопки аутентификации.
        private void AuthBttn_Click(object sender, EventArgs e)
        {
            _formAuth.Show();
            this.Visible = false;
        }
//      Функция кнопки регистрации.
        private void RegBttn_Click(object sender, EventArgs e)
        {
            _formReg.sForm = this;
            _formReg.Show();
            this.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Message msg = GetMes(lastMsgID);
            if (msg != null)
            {
                MesList.Items.Add($"({lastMsgID}) {msg.TimeStamp} [{msg.UserName}] {msg.Text}");
                lastMsgID++;
            }
        }
    }
}
