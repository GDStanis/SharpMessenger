using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WFClient
{
    public partial class AuthForm : Form
    {

        public SharpForm sForm;
        public class AuthData
        {
            public string login { get; set; }
            public string password { get; set; }
            public int token { get; set; }
        }

        public AuthForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBttn_Click(object sender, EventArgs e)
        {
            AuthData auth_data = new AuthData();
            string login = tbUserName.Text;
            string password = tbPassword.Text;
            auth_data.login = login;
            auth_data.password = password;
            string stream;
            string file = @"C:\Users\mi\Desktop\SharpMessenger\Servak\bin\Debug\netcoreapp3.1\sharp_datafile.json";
            using (StreamReader sr = new StreamReader(file))
            {
                stream = sr.ReadToEnd();
            }
            var m = JsonExtensions.ToObject<Temperatures>(stream);
            int tst = 0;
            for (int i = 0; i != m.ListTokens.Count(); i++)
            {
                if (login == m.ListTokens[i].Login)
                {
                    if (password == m.ListTokens[i].Password)
                    {
                        var token = m.ListTokens[i].Token;
                        tst = 1;
                        WebRequest req = WebRequest.Create("http://localhost:5000/api/Auth");
                        req.Method = "POST";
                        int token1 = Convert.ToInt32(token);
                        auth_data.token = token1;
                        string postData = JsonConvert.SerializeObject(auth_data);
                        req.ContentType = "application/json";
                        StreamWriter reqStream = new StreamWriter(req.GetRequestStream());
                        reqStream.Write(postData);
                        reqStream.Close();
                        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                        StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                        string content = sr.ReadToEnd();
                      //  sr.Close();
                        int int_token = Convert.ToInt32(content, 10);
                        sForm.int_token = int_token;
                        sForm.TB_UserName.Text = auth_data.login;
                        sForm.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Wrong password. Try again.");
                        tst = 1;
                    }

                }
            }
            if (tst != 1) MessageBox.Show("There's no such login in system.");
        }
        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sForm.Show();
        }
        public partial class Temperatures
        {
            [JsonProperty("list_tokens")]
            public ListToken[] ListTokens { get; set; }
        }
        public partial class ListToken
        {
            [JsonProperty("token")]
            public long Token { get; set; }
            [JsonProperty("login")]
            public string Login { get; set; }
            [JsonProperty("password")]
            public string Password { get; set; }
        }
        private void AuthForm_Load(object sender, EventArgs e)
        {

        }
    }
    public static class JsonExtensions
    {
        public static T ToObject<T>(this string jsonText)
        {
            return JsonConvert.DeserializeObject<T>(jsonText);
        }
    }
}
