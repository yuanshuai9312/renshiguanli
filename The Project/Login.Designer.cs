namespace The_Project
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_tips4 = new System.Windows.Forms.Label();
            this.label_tips3 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Pwd = new System.Windows.Forms.TextBox();
            this.textBox_Account = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::The_Project.Properties.Resources.花;
            this.groupBox1.Controls.Add(this.label_tips4);
            this.groupBox1.Controls.Add(this.label_tips3);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Pwd);
            this.groupBox1.Controls.Add(this.textBox_Account);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登陆";
            // 
            // label_tips4
            // 
            this.label_tips4.AutoSize = true;
            this.label_tips4.ForeColor = System.Drawing.Color.Red;
            this.label_tips4.Location = new System.Drawing.Point(115, 113);
            this.label_tips4.Name = "label_tips4";
            this.label_tips4.Size = new System.Drawing.Size(0, 15);
            this.label_tips4.TabIndex = 7;
            // 
            // label_tips3
            // 
            this.label_tips3.AutoSize = true;
            this.label_tips3.BackColor = System.Drawing.Color.Transparent;
            this.label_tips3.ForeColor = System.Drawing.Color.Red;
            this.label_tips3.Location = new System.Drawing.Point(115, 63);
            this.label_tips3.Name = "label_tips3";
            this.label_tips3.Size = new System.Drawing.Size(0, 15);
            this.label_tips3.TabIndex = 6;
            // 
            // btn_login
            // 
            this.btn_login.BackgroundImage = global::The_Project.Properties.Resources._15;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.Location = new System.Drawing.Point(236, 137);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "OK";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackgroundImage = global::The_Project.Properties.Resources._15;
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancel.Location = new System.Drawing.Point(6, 137);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Concel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "账号：";
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.Location = new System.Drawing.Point(102, 81);
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.Size = new System.Drawing.Size(183, 22);
            this.textBox_Pwd.TabIndex = 1;
            this.textBox_Pwd.Enter += new System.EventHandler(this.textBox_Pwd_Enter);
            // 
            // textBox_Account
            // 
            this.textBox_Account.Location = new System.Drawing.Point(102, 35);
            this.textBox_Account.Name = "textBox_Account";
            this.textBox_Account.Size = new System.Drawing.Size(183, 22);
            this.textBox_Account.TabIndex = 0;
            this.textBox_Account.TextChanged += new System.EventHandler(this.textBox_Account_TextChanged);
            this.textBox_Account.Enter += new System.EventHandler(this.textBox_Account_Enter);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::The_Project.Properties.Resources.花;
            this.ClientSize = new System.Drawing.Size(324, 168);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Pwd;
        private System.Windows.Forms.TextBox textBox_Account;
        private System.Windows.Forms.Label label_tips4;
        private System.Windows.Forms.Label label_tips3;
    }
}