namespace The_Project
{
    partial class Index
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_ShowTime = new System.Windows.Forms.Panel();
            this.label_text = new System.Windows.Forms.Label();
            this.timer_sysdata = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工程部运作情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.研发部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shichangbuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xiaoshouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caigouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shengchanbuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_ShowTime.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ShowTime
            // 
            this.panel_ShowTime.BackColor = System.Drawing.Color.Transparent;
            this.panel_ShowTime.Controls.Add(this.label_text);
            this.panel_ShowTime.Location = new System.Drawing.Point(105, 57);
            this.panel_ShowTime.Name = "panel_ShowTime";
            this.panel_ShowTime.Size = new System.Drawing.Size(614, 39);
            this.panel_ShowTime.TabIndex = 0;
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_text.ForeColor = System.Drawing.Color.Lime;
            this.label_text.Location = new System.Drawing.Point(3, 9);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(0, 20);
            this.label_text.TabIndex = 0;
            // 
            // timer_sysdata
            // 
            this.timer_sysdata.Enabled = true;
            this.timer_sysdata.Tick += new System.EventHandler(this.timer_sysdata_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.peopleControlToolStripMenuItem,
            this.工程部运作情况ToolStripMenuItem,
            this.shichangbuToolStripMenuItem,
            this.shengchanbuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加用户ToolStripMenuItem,
            this.更改密码ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            this.添加用户ToolStripMenuItem.Click += new System.EventHandler(this.添加用户ToolStripMenuItem_Click);
            // 
            // 更改密码ToolStripMenuItem
            // 
            this.更改密码ToolStripMenuItem.Name = "更改密码ToolStripMenuItem";
            this.更改密码ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.更改密码ToolStripMenuItem.Text = "更改密码";
            this.更改密码ToolStripMenuItem.Click += new System.EventHandler(this.更改密码ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // peopleControlToolStripMenuItem
            // 
            this.peopleControlToolStripMenuItem.Name = "peopleControlToolStripMenuItem";
            this.peopleControlToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.peopleControlToolStripMenuItem.Text = "PeopleControl";
            this.peopleControlToolStripMenuItem.Click += new System.EventHandler(this.peopleControlToolStripMenuItem_Click);
            // 
            // 工程部运作情况ToolStripMenuItem
            // 
            this.工程部运作情况ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.研发部ToolStripMenuItem,
            this.测试部ToolStripMenuItem});
            this.工程部运作情况ToolStripMenuItem.Name = "工程部运作情况ToolStripMenuItem";
            this.工程部运作情况ToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.工程部运作情况ToolStripMenuItem.Text = "gongchengbu";
            // 
            // 研发部ToolStripMenuItem
            // 
            this.研发部ToolStripMenuItem.Name = "研发部ToolStripMenuItem";
            this.研发部ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.研发部ToolStripMenuItem.Text = "yanfa";
            this.研发部ToolStripMenuItem.Click += new System.EventHandler(this.研发部ToolStripMenuItem_Click);
            // 
            // 测试部ToolStripMenuItem
            // 
            this.测试部ToolStripMenuItem.Name = "测试部ToolStripMenuItem";
            this.测试部ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.测试部ToolStripMenuItem.Text = "ceshi";
            // 
            // shichangbuToolStripMenuItem
            // 
            this.shichangbuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xiaoshouToolStripMenuItem,
            this.caigouToolStripMenuItem});
            this.shichangbuToolStripMenuItem.Name = "shichangbuToolStripMenuItem";
            this.shichangbuToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.shichangbuToolStripMenuItem.Text = "shichangbu";
            // 
            // xiaoshouToolStripMenuItem
            // 
            this.xiaoshouToolStripMenuItem.Name = "xiaoshouToolStripMenuItem";
            this.xiaoshouToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.xiaoshouToolStripMenuItem.Text = "xiaoshou";
            // 
            // caigouToolStripMenuItem
            // 
            this.caigouToolStripMenuItem.Name = "caigouToolStripMenuItem";
            this.caigouToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.caigouToolStripMenuItem.Text = "caigou";
            // 
            // shengchanbuToolStripMenuItem
            // 
            this.shengchanbuToolStripMenuItem.Name = "shengchanbuToolStripMenuItem";
            this.shengchanbuToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.shengchanbuToolStripMenuItem.Text = "shengchanbu";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::The_Project.Properties.Resources._7ec695ef68549b0d78f055d6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 545);
            this.Controls.Add(this.panel_ShowTime);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.Index_Load);
            this.panel_ShowTime.ResumeLayout(false);
            this.panel_ShowTime.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ShowTime;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Timer timer_sysdata;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工程部运作情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 研发部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shichangbuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xiaoshouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caigouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shengchanbuToolStripMenuItem;
    }
}

