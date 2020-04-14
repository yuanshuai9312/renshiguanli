using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace The_Project
{
    public partial class SendUser : Form
    {
        string str = @"../../\UserInforMation\UserInformation.xml";
        public SendUser()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendUser_Load(object sender, EventArgs e)
        {
            comboBox_start.Items.Add(PeopleControl.DPatment);
            comboBox_start.Text = comboBox_start.Items[0].ToString();
            comboBox_toEnd.Items.Add("工程部");
            comboBox_toEnd.Items.Add("人事部");
            comboBox_toEnd.Items.Add("行政部");
            comboBox_toEnd.Items.Add("测试部");
            comboBox_toEnd.Items.Add("生产部");
            comboBox_toEnd.Items.Add("采购部");
            comboBox_toEnd.Items.Add("市场部");
            comboBox_toEnd.Text = comboBox_toEnd.Items[0].ToString();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {          
            for (int i=0;i<Collection.userAllList.Count;i++)
            {
                if (PeopleControl.SenAccountNum==Collection.userAllList[i].AccountNum) {
                    Collection.userAllList[i].Department.Replace(Collection.userAllList[i].Department,comboBox_toEnd.SelectedText);
                    XmlDocument document = new XmlDocument();
                    document.Load(str);
                    XmlNodeList xnodelist = document.SelectSingleNode("UserInfo").ChildNodes;
                    foreach (XmlNode xnode in xnodelist)
                    {
                        foreach (XmlNode node in xnode) {
                            XmlElement ele = (XmlElement)node;
                            if (ele.Name== "AccountNum") {
                                if (ele.InnerText==PeopleControl.SenAccountNum) {
                                    XmlNodeList xlist = ele.ParentNode.ChildNodes;
                                    foreach (XmlNode nodelist in xlist) {
                                        if (nodelist.Name== "Department") {
                                            nodelist.InnerText = comboBox_toEnd.SelectedItem.ToString();
                                            document.Save(str);
                                            this.DialogResult = DialogResult.OK;
                                            MessageBox.Show("调度成功！");                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
