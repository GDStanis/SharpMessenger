
namespace WFClient
{
    partial class Form1
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
            this.MesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userField = new System.Windows.Forms.TextBox();
            this.MesField = new System.Windows.Forms.TextBox();
            this.SendBttn = new System.Windows.Forms.Button();
            this.updLoop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MesList
            // 
            this.MesList.FormattingEnabled = true;
            this.MesList.ItemHeight = 20;
            this.MesList.Location = new System.Drawing.Point(12, 12);
            this.MesList.Name = "MesList";
            this.MesList.Size = new System.Drawing.Size(894, 424);
            this.MesList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // userField
            // 
            this.userField.Location = new System.Drawing.Point(96, 450);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(584, 27);
            this.userField.TabIndex = 3;
            // 
            // MesField
            // 
            this.MesField.Location = new System.Drawing.Point(96, 485);
            this.MesField.Name = "MesField";
            this.MesField.Size = new System.Drawing.Size(584, 27);
            this.MesField.TabIndex = 4;
            this.MesField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SendBttn
            // 
            this.SendBttn.Location = new System.Drawing.Point(686, 450);
            this.SendBttn.Name = "SendBttn";
            this.SendBttn.Size = new System.Drawing.Size(220, 62);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 517);
            this.Controls.Add(this.SendBttn);
            this.Controls.Add(this.MesField);
            this.Controls.Add(this.userField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox MesField;
        private System.Windows.Forms.Button SendBttn;
        private System.Windows.Forms.Timer updLoop;
    }
}

