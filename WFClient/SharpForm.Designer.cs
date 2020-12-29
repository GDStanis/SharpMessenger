
namespace WFClient
{
    partial class SharpForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharpForm));
            this.MesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserField = new System.Windows.Forms.TextBox();
            this.MesField = new System.Windows.Forms.TextBox();
            this.SendBttn = new System.Windows.Forms.Button();
            this.updLoop = new System.Windows.Forms.Timer(this.components);
            this.AuthBttn = new System.Windows.Forms.Button();
            this.RegBttn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MesList
            // 
            this.MesList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MesList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MesList.ForeColor = System.Drawing.Color.LimeGreen;
            this.MesList.FormattingEnabled = true;
            this.MesList.ItemHeight = 20;
            this.MesList.Location = new System.Drawing.Point(12, 12);
            this.MesList.Name = "MesList";
            this.MesList.Size = new System.Drawing.Size(776, 324);
            this.MesList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(12, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // UserField
            // 
            this.UserField.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UserField.ForeColor = System.Drawing.Color.LimeGreen;
            this.UserField.Location = new System.Drawing.Point(96, 348);
            this.UserField.Name = "UserField";
            this.UserField.Size = new System.Drawing.Size(554, 27);
            this.UserField.TabIndex = 3;
            this.UserField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MesField
            // 
            this.MesField.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MesField.ForeColor = System.Drawing.Color.LimeGreen;
            this.MesField.Location = new System.Drawing.Point(96, 381);
            this.MesField.Name = "MesField";
            this.MesField.Size = new System.Drawing.Size(554, 27);
            this.MesField.TabIndex = 4;
            // 
            // SendBttn
            // 
            this.SendBttn.ForeColor = System.Drawing.Color.LimeGreen;
            this.SendBttn.Image = ((System.Drawing.Image)(resources.GetObject("SendBttn.Image")));
            this.SendBttn.Location = new System.Drawing.Point(656, 348);
            this.SendBttn.Name = "SendBttn";
            this.SendBttn.Size = new System.Drawing.Size(132, 90);
            this.SendBttn.TabIndex = 5;
            this.SendBttn.Text = "SEND";
            this.SendBttn.UseVisualStyleBackColor = true;
            this.SendBttn.Click += new System.EventHandler(this.SendBttn_Click);
            // 
            // updLoop
            // 
            this.updLoop.Enabled = true;
            this.updLoop.Interval = 500;
            this.updLoop.Tick += new System.EventHandler(this.updLoop_Tick);
            // 
            // AuthBttn
            // 
            this.AuthBttn.BackColor = System.Drawing.SystemColors.Desktop;
            this.AuthBttn.ForeColor = System.Drawing.Color.LimeGreen;
            this.AuthBttn.Location = new System.Drawing.Point(12, 414);
            this.AuthBttn.Name = "AuthBttn";
            this.AuthBttn.Size = new System.Drawing.Size(136, 29);
            this.AuthBttn.TabIndex = 6;
            this.AuthBttn.Text = "Authentication";
            this.AuthBttn.UseVisualStyleBackColor = false;
            this.AuthBttn.Click += new System.EventHandler(this.AuthBttn_Click);
            // 
            // RegBttn
            // 
            this.RegBttn.BackColor = System.Drawing.SystemColors.Desktop;
            this.RegBttn.ForeColor = System.Drawing.Color.LimeGreen;
            this.RegBttn.Location = new System.Drawing.Point(180, 414);
            this.RegBttn.Name = "RegBttn";
            this.RegBttn.Size = new System.Drawing.Size(136, 29);
            this.RegBttn.TabIndex = 7;
            this.RegBttn.Text = "Registration";
            this.RegBttn.UseVisualStyleBackColor = false;
            this.RegBttn.Click += new System.EventHandler(this.RegBttn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SharpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegBttn);
            this.Controls.Add(this.AuthBttn);
            this.Controls.Add(this.SendBttn);
            this.Controls.Add(this.MesField);
            this.Controls.Add(this.UserField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SharpForm";
            this.Text = "SharpMessenger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserField;
        private System.Windows.Forms.TextBox MesField;
        private System.Windows.Forms.Button SendBttn;
        private System.Windows.Forms.Timer updLoop;
        private System.Windows.Forms.Button AuthBttn;
        private System.Windows.Forms.Button RegBttn;
        private System.Windows.Forms.Timer timer1;
    }
}

