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
using static The_Project.Collection;

namespace The_Project
{
    public partial class UpdatePwd : Form
    {
        string str = @"../../\UserInforMation\UserInformation.xml";      
        public UpdatePwd()
        {
            InitializeComponent();
        }

        public void UpdateUserPwd()
        {
            
            for (int i=0;i<Collection.userAllList.Count;i++) {
                Console.WriteLine(Collection.userList.Count);
                if (textBox_Pwd.Text != "" && textBox_pwd2.Text != "" && textBox_pwd2.Text == textBox_Pwd.Text) {
                    
                    if (Index.AccountNum == Collection.userAllList[i].AccountNum)
                    {                      
                        Collection.userAllList[i].PassWord.Replace(Collection.userAllList[i].PassWord,textBox_pwd2.Text);
                        XmlDocument document = new XmlDocument();
                        document.Load(str);
                        XmlNodeList xnodelist = document.SelectSingleNode("UserInfo").ChildNodes;
                        foreach (XmlNode xlist in xnodelist) {
                            
                            foreach (XmlNode xnode in xlist) {
                                
                                XmlElement ele = (XmlElement)xnode;
                                if (ele.Name== "AccountNum") {
                                   
                                    if (ele.InnerText==Index.AccountNum) {
                                        
                                        XmlNodeList xnlist = ele.ParentNode.ChildNodes;
                                        foreach (XmlNode node in xnlist) {
                                            
                                            XmlElement le = (XmlElement)node;
                                            if (le.Name== "PassWord")
                                            {                                               
                                                le.InnerText = textBox_pwd2.Text;
                                                document.Save(str);
                                                MessageBox.Show("修改成功！");
                                                this.Close();
                                            }
                                        }
                                        
                                    }
                                 }
                               
                            }
                        }

                    }
                } else if (textBox_Pwd.Text == "") {
                    label_tips.Text = "新密码不能为空！";
                } else if (textBox_pwd2.Text == "") {
                    label_tips.Text = "请确认新密码！";
                } else if (textBox_pwd2.Text!=textBox_Pwd.Text) {
                    label_tips.Text = "两次输入的密码不一致！";
                }
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            UpdateUserPwd();
        }

        private void textBox_Pwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
