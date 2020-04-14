namespace The_Project
{
    partial class SendUser
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.comboBox_toEnd = new System.Windows.Forms.ComboBox();
            this.comboBox_start = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.btn_Ok);
            this.groupBox1.Controls.Add(this.comboBox_toEnd);
            this.groupBox1.Controls.Add(this.comboBox_start);
            this.groupBox1.Location = new System.Drawing.Point(39, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "人员调动";
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::The_Project.Properties.Resources._01;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Location = new System.Drawing.Point(33, 154);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(121, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackgroundImage = global::The_Project.Properties.Resources._01;
            this.btn_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ok.Location = new System.Drawing.Point(33, 120);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(121, 23);
            this.btn_Ok.TabIndex = 5;
            this.btn_Ok.Text = "确认";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // comboBox_toEnd
            // 
            this.comboBox_toEnd.FormattingEnabled = true;
            this.comboBox_toEnd.Location = new System.Drawing.Point(33, 79);
            this.comboBox_toEnd.Name = "comboBox_toEnd";
            this.comboBox_toEnd.Size = new System.Drawing.Size(121, 23);
            this.comboBox_toEnd.TabIndex = 4;
            // 
            // comboBox_start
            // 
            this.comboBox_start.FormattingEnabled = true;
            this.comboBox_start.Location = new System.Drawing.Point(33, 23);
            this.comboBox_start.Name = "comboBox_start";
            this.comboBox_start.Size = new System.Drawing.Size(121, 23);
            this.comboBox_start.TabIndex = 3;
            // 
            // SendUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::The_Project.Properties.Resources._2130511313;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendUser";
            this.Text = "SendUser";
            this.Load += new System.EventHandler(this.SendUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.ComboBox comboBox_toEnd;
        private System.Windows.Forms.ComboBox comboBox_start;
        private System.Windows.Forms.Button btn_close;
    }
}