using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using The_Project.Properties;
using static The_Project.Collection;

namespace The_Project
{
    public partial class Login : Form
    {
        string str = @"../../\UserInforMation\UserInformation.xml";    
        UserAllInfoMation userAllInformation = new UserAllInfoMation();
        Jurisdiction Jdiction = new Jurisdiction();
        public static string Dpartment;
        public static string Psation;
        public Login()
        {
            InitializeComponent();
           
        }     
        public void LoadUserAllInformationXml()
        {
            try
            {
                XmlDocument dt = new XmlDocument();
                dt.Load(str);
                int count = dt.SelectSingleNode("UserInfo").ChildNodes.Count;
                for (int i = 0; i < count; i++)
                {
                    XDocument document = XDocument.Load(str);
                    XElement root = document.Root;
                    
                    XElement ele = root.Element("UserInfoMation" + i);
                    XElement Department = ele.Element("Department");
                    XElement Position = ele.Element("Position");
                    XElement TeacherLevel = ele.Element("TeacherLevel");
                    XElement PoliticalOutlook = ele.Element("PoliticalOutlook");
                    XElement Nation = ele.Element("Nation");
                    XElement Wages = ele.Element("Wages");
                    XElement Reward = ele.Element("Reward");
                    XElement ContractInformation = ele.Element("ContractInformation");
                    XElement Punishment = ele.Element("Punishment");
                    XElement AccountNum = ele.Element("AccountNum");
                    XElement PassWord = ele.Element("PassWord");
                    userAllInformation.Department = Department.Value;
                    userAllInformation.Position = Position.Value;
                    userAllInformation.TeacherLevel = TeacherLevel.Value;
                    userAllInformation.PoliticalOutlook = PoliticalOutlook.Value;
                    userAllInformation.Nation = Nation.Value;
                    userAllInformation.Wages = Wages.Value;
                    userAllInformation.Reward = Reward.Value;
                    userAllInformation.ContractInformation = ContractInformation.Value;
                    userAllInformation.Punishment = Punishment.Value;
                    userAllInformation.AccountNum = AccountNum.Value;
                    userAllInformation.PassWord = PassWord.Value;
                    Collection.userAllList.Add(userAllInformation);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("未能正确加载UserLogin信息文件！" + ex);
            }
        }
        public void CheckUser()
        {           
            for (int i=0;i<Collection.userAllList.Count;i++) {
                if ((textBox_Account.Text == Collection.userAllList[i].AccountNum) && (textBox_Pwd.Text == Collection.userAllList[i].PassWord))
                {
                    this.DialogResult = DialogResult.OK;
                    Index.AccountNum = textBox_Account.Text;
                    Dpartment = Collection.userAllList[i].Department;
                    Psation = Collection.userAllList[i].Position;
                    if (Collection.userAllList[i].Position == Collection.userAllList[i].Department+"组长") {
                       
                        Jdiction.Jurisdiction_level = 4;
                        Collection.jurisdiction.Add(Jdiction);
                    }
                    if (Collection.userAllList[i].Position == Collection.userAllList[i].Department + "经理")
                    {
                    
                        Jdiction.Jurisdiction_level = 3;
                        Collection.jurisdiction.Add(Jdiction);
                    }
                    if (Collection.userAllList[i].Position == "总经理")
                    {
                       
                        Jdiction.Jurisdiction_level = 2;
                        Collection.jurisdiction.Add(Jdiction);
                    }
                    if (Collection.userAllList[i].Position =="董事长")
                    {
                      
                        Jdiction.Jurisdiction_level = 1;
                        Collection.jurisdiction.Add(Jdiction);
                    }
                    if (Collection.userAllList[i].Position == "人事总监")
                    {
                       
                        Jdiction.Jurisdiction_level = 0;
                        Collection.jurisdiction.Add(Jdiction);
                    }

                }
                else if (textBox_Account.Text != Collection.userAllList[i].AccountNum)
                {
                    label_tips3.Text = "账号错误！请重新输入";
                    textBox_Account.Text = "";                  
                }
                else if (textBox_Pwd.Text != Collection.userAllList[i].PassWord)
                {
                    label_tips4.Text = "密码错误！请重新输入";
                    textBox_Pwd.Text = "";                   
                }
                else {
                    label_tips4.Text = "账号和密码错误！";
                    textBox_Account.Text = "";
                    textBox_Pwd.Text = "";
                }
            }
        }
       
        private void Login_Load(object sender, EventArgs e)
        {
            if (File.Exists(str))
            {
                LoadUserAllInformationXml();
            }
            else
            {
                MessageBox.Show("加载数据出错，检查数据库服务是否正常运行！");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_Cancel.BackgroundImage = Resources._14;
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            btn_login.BackgroundImage = Resources._14;
            CheckUser();
        }

        private void textBox_Account_Enter(object sender, EventArgs e)
        {
            label_tips3.Text = "";
        }

        private void textBox_Pwd_Enter(object sender, EventArgs e)
        {
            label_tips4.Text = "";
        }

        private void textBox_Account_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
