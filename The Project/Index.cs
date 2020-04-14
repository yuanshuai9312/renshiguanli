using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Project
{
    public partial class Index : Form
    {
        public static string AccountNum;
        public static bool flg = false;
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            PanDuan();
        }
       
        private void timer_sysdata_Tick(object sender, EventArgs e)
        {
            label_text.Text = "欢迎：" + AccountNum + "使用本系统！" + "当前时间：" + DateTime.Now.ToString();
        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flg) {
                AddUser adduser = new AddUser();
                adduser.ShowDialog();
            }
            else
            {
                MessageBox.Show("无权操作！");
            }
        }
        public void PanDuan()
        {          
            for (int i = 0; i < Collection.jurisdiction.Count; i++)
            {               
                if (Collection.jurisdiction[i].Jurisdiction_level < 4)
                {
                    flg = true;
                }
                else
                {
                    flg = false;
                }
            }
        }
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePwd udata = new UpdatePwd();
            udata.ShowDialog();
        }

        private void peopleControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flg)
            {
                PeopleControl people = new PeopleControl();
                people.Show();
            }
            else {
                MessageBox.Show("无权操作！");
            }
        }

        private void 研发部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Collection.jurisdiction[0].Jurisdiction_level < 4)
            {
                if (Login.Psation == "研发部经理")
                {
                    Creat c = new Creat();
                    c.ShowDialog();
                }
                else
                {
                    MessageBox.Show("无权操作！");
                }
            }
            else {
                MessageBox.Show("无权操作！");
            }
        }
    }
}
