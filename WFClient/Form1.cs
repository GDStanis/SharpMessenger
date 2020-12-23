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

// WFClient

namespace WFClient
{

    [Serializable]
    public class Message
    {
        public string UserName = "";
        public string Text = "";
        public DateTime TimeStamp;
    }

    public partial class Form1 : Form
    {

        int lastMsgID = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void updLoop_Tick(object sender, EventArgs e)
        {
            Message msg = GetMes(lastMsgID);
            if (msg != null)
            {
                MesList.Items.Add($"{msg.TimeStamp} [{msg.UserName}] {msg.Text}");
                lastMsgID++;
            }
        }

        private void SendBttn_Click(object sender, EventArgs e)
        {
            SendMes(new Message()
            {
                UserName = userField.Text,
                Text = MesField.Text,
            });

        }

        //      Отправка сообщений на сервер.
        static void SendMes(Message txt)
        {
            WebRequest req = WebRequest.Create("http://localhost:5000/api/Mes");
            req.Method = "POST";
            string postData = JsonConvert.SerializeObject(txt);
            //byte[] bytes = Encoding.UTF8.GetBytes(postData);
            req.ContentType = "application/json";
            //req.ContentLength = bytes.Length;
            StreamWriter reqStream = new StreamWriter (req.GetRequestStream());
            reqStream.Write(postData);
            reqStream.Close();
            req.GetResponse();
        }

        //      Получение сообщений с сервера.
        static Message GetMes(int id)
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

            //try
            //{
            //    WebRequest req = WebRequest.Create($"http://localhost:5000/api/Mes/{id}");
            //    req.Method = "GET";
            //    WebResponse resp = req.GetResponse();
            //    string smsg = new StreamReader(resp.GetResponseStream()).ReadToEnd();

            //    if (smsg == "Not found") return null;
            //    return JsonConvert.DeserializeObject<Message>(smsg);
            //}
            //catch { return null; }

        }
    }
}
