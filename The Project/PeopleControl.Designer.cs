namespace The_Project
{
    partial class PeopleControl
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人事调动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fire注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(864, 440);
            this.dataGridView1.TabIndex = 0;
           
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑信息ToolStripMenuItem,
            this.人事调动ToolStripMenuItem,
            this.fire注销ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 82);
            // 
            // 编辑信息ToolStripMenuItem
            // 
            this.编辑信息ToolStripMenuItem.Name = "编辑信息ToolStripMenuItem";
            this.编辑信息ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.编辑信息ToolStripMenuItem.Text = "编辑信息";
            this.编辑信息ToolStripMenuItem.Click += new System.EventHandler(this.编辑信息ToolStripMenuItem_Click);
            // 
            // 人事调动ToolStripMenuItem
            // 
            this.人事调动ToolStripMenuItem.Name = "人事调动ToolStripMenuItem";
            this.人事调动ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.人事调动ToolStripMenuItem.Text = "人事调动";
            this.人事调动ToolStripMenuItem.Click += new System.EventHandler(this.人事调动ToolStripMenuItem_Click);
            // 
            // fire注销ToolStripMenuItem
            // 
            this.fire注销ToolStripMenuItem.Name = "fire注销ToolStripMenuItem";
            this.fire注销ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.fire注销ToolStripMenuItem.Text = "Fire注销";
            this.fire注销ToolStripMenuItem.Click += new System.EventHandler(this.fire注销ToolStripMenuItem_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImage = global::The_Project.Properties.Resources._02;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Location = new System.Drawing.Point(789, 440);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 36);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "AddUser";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::The_Project.Properties.Resources._02;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Location = new System.Drawing.Point(0, 440);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 36);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // PeopleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::The_Project.Properties.Resources._4b28434d94f70371afc3abfb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 476);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeopleControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleControl";
            this.Load += new System.EventHandler(this.PeopleControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 编辑信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人事调动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fire注销ToolStripMenuItem;
    }
}