
namespace WFClient
{
    partial class RegForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass1 = new System.Windows.Forms.TextBox();
            this.tbPass2 = new System.Windows.Forms.TextBox();
            this.RegBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm\r\nPassword";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbUser.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbUser.Location = new System.Drawing.Point(96, 20);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(189, 27);
            this.tbUser.TabIndex = 3;
            // 
            // tbPass1
            // 
            this.tbPass1.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbPass1.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbPass1.Location = new System.Drawing.Point(96, 55);
            this.tbPass1.Name = "tbPass1";
            this.tbPass1.Size = new System.Drawing.Size(189, 27);
            this.tbPass1.TabIndex = 4;
            // 
            // tbPass2
            // 
            this.tbPass2.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbPass2.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbPass2.Location = new System.Drawing.Point(96, 91);
            this.tbPass2.Name = "tbPass2";
            this.tbPass2.Size = new System.Drawing.Size(189, 27);
            this.tbPass2.TabIndex = 5;
            // 
            // RegBttn
            // 
            this.RegBttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegBttn.BackgroundImage")));
            this.RegBttn.ForeColor = System.Drawing.Color.LimeGreen;
            this.RegBttn.Location = new System.Drawing.Point(96, 146);
            this.RegBttn.Name = "RegBttn";
            this.RegBttn.Size = new System.Drawing.Size(94, 29);
            this.RegBttn.TabIndex = 6;
            this.RegBttn.Text = "Register";
            this.RegBttn.UseVisualStyleBackColor = true;
            this.RegBttn.Click += new System.EventHandler(this.RegBttn_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(297, 187);
            this.Controls.Add(this.RegBttn);
            this.Controls.Add(this.tbPass2);
            this.Controls.Add(this.tbPass1);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegForm";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.RegForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass1;
        private System.Windows.Forms.TextBox tbPass2;
        private System.Windows.Forms.Button RegBttn;
    }
}