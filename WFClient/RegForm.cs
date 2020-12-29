using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WFClient
{
    public partial class RegForm : Form
    {
        public class AuthData
        {
            public string login { get; set; }
            public string password { get; set; }
        }
        public SharpForm sForm;
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_load(object sender, EventArgs e)
        {

        }

        private void RegBttn_Click(object sender, EventArgs e)
        {
            string passLine1 = tbPass1.Text;
            string passLine2 = tbPass2.Text;
            if (passLine1 == passLine2)
            {
                WebRequest req = WebRequest.Create("http://localhost:5000/api/reg");
                req.Method = "POST";
                AuthData auth_data = new AuthData();
                auth_data.login = tbUser.Text;
                auth_data.password = passLine1;
                string postData = JsonConvert.SerializeObject(auth_data);
                req.ContentType = "application/json";
                StreamWriter reqStream = new StreamWriter(req.GetRequestStream());
                reqStream.Write(postData);
                reqStream.Close();
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                string content = sr.ReadToEnd();
                int int_token = Convert.ToInt32(content, 10);
                if (int_token != -1)
                {
                    sForm.int_token = int_token;
                    sForm.TB_UserName.Text = auth_data.login;
                    sForm.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("This UserName is already exists. Try another one.");
                }
            }
            else
            {
                MessageBox.Show("Passwords don't match. Try again.");
            }
        }
        private void RegFormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void RegFormClosed(object sender, FormClosedEventArgs e)
        {
            sForm.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
