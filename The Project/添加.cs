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
using static The_Project.Collection;

namespace The_Project
{
    public partial class AddUser : Form
    {
        string str = @"../../\UserInforMation\UserInformation.xml";
        UserAllInfoMation userallInformation = new UserAllInfoMation();
        public AddUser()
        {
            InitializeComponent();
        }

        private void 添加_Load(object sender, EventArgs e)
        {
            comboBox_Department.Items.Add("工程部");
            comboBox_Department.Items.Add("测试部");
            comboBox_Department.Items.Add("人事部");
            comboBox_Department.Items.Add("行政部");
            comboBox_Department.Items.Add("采购部");
            comboBox_Department.Items.Add("生产部");
            comboBox_Department.Items.Add("市场部");
            comboBox_Department.Text = comboBox_Department.Items[0].ToString();
            comboBox_Position.Items.Add("董事长");
            comboBox_Position.Items.Add("总经理");
            comboBox_Position.Items.Add("经理");
            comboBox_Position.Items.Add("人事总监");
            comboBox_Position.Items.Add("组长");
            comboBox_Position.Items.Add("普通职员");
            comboBox_Position.Text = comboBox_Position.Items[0].ToString();
            comboBox_TeacherLevel.Items.Add("硕士");
            comboBox_TeacherLevel.Items.Add("博士");
            comboBox_TeacherLevel.Items.Add("研究生");
            comboBox_TeacherLevel.Items.Add("高中");
            comboBox_TeacherLevel.Items.Add("初中");
            comboBox_TeacherLevel.Items.Add("小学");
            comboBox_TeacherLevel.Text = comboBox_TeacherLevel.Items[0].ToString();
            comboBox_PoliticalOutLook.Items.Add("党员");
            comboBox_PoliticalOutLook.Items.Add("群众");
            comboBox_PoliticalOutLook.Text = comboBox_PoliticalOutLook.Items[0].ToString();
            comboBox_nation.Items.Add("汉族");
            comboBox_nation.Items.Add("少数民族");
            comboBox_nation.Text = comboBox_nation.Items[0].ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (comboBox_Department.Text != "" && comboBox_Position.Text != "" && comboBox_nation.Text != "" && textBox_wages.Text != "" && textBox_Password.Text != "" && textBox_AccountNum.Text != "") {
                userallInformation.Department = comboBox_Department.SelectedText;
                userallInformation.Position = comboBox_Position.SelectedText;
                userallInformation.TeacherLevel = comboBox_TeacherLevel.SelectedText;
                userallInformation.PoliticalOutlook = comboBox_PoliticalOutLook.SelectedText;
                userallInformation.Nation = comboBox_nation.SelectedText;
                userallInformation.Wages = textBox_wages.Text;
                userallInformation.Reward = textBox_reward.Text;
                userallInformation.Punishment = textBox_punishment.Text;
                userallInformation.ContractInformation = textBox_ContractInformation.Text;
                userallInformation.AccountNum = textBox_AccountNum.Text;
                userallInformation.PassWord = textBox_Password.Text;
                Collection.userAllList.Add(userallInformation);
                this.DialogResult = DialogResult.OK;
                SaverAdduserInfo();
            } else if (comboBox_Department.Text == "")
            {
                label_tips.Text = "Department不能为空";
            } else if (comboBox_Position.Text == "")
            {
                label_tips.Text = "Position不能为空";
            } else if (comboBox_nation.Text == "") {
                label_tips.Text = "nation不能为空";
            } else if (textBox_wages.Text == "")
            {
                label_tips.Text = "Wages不能为空";
            } else if (textBox_Password.Text == "") {
                label_tips.Text = "Password不能为空";
            } else if (textBox_AccountNum.Text=="") {
                label_tips.Text = "AccountNum不能为空";
            }
            
        }
        public void SaverAdduserInfo() {
            if (File.Exists(str)) {
                int cout = Collection.userAllList.Count;              
                int sum = cout - 1;
                XmlDocument document = new XmlDocument();
                document.Load(str);
                XmlNode root = document.SelectSingleNode("UserInfo");
                XmlElement UserInfoMation = document.CreateElement("UserInfoMation"+sum);
                XmlElement Department = document.CreateElement("Department");
                Department.InnerText = Collection.userAllList[sum].Department.ToString();
                UserInfoMation.AppendChild(Department);
                root.AppendChild(UserInfoMation);
               
                XmlElement Position = document.CreateElement("Position");
                Position.InnerText = Collection.userAllList[sum].Position.ToString();
                UserInfoMation.AppendChild(Position);
                root.AppendChild(UserInfoMation);

                XmlElement TeacherLevel = document.CreateElement("TeacherLevel");
                TeacherLevel.InnerText = Collection.userAllList[sum].TeacherLevel.ToString();
                UserInfoMation.AppendChild(TeacherLevel);
                root.AppendChild(UserInfoMation);

                XmlElement PoliticalOutlook = document.CreateElement("PoliticalOutlook");
                PoliticalOutlook.InnerText = Collection.userAllList[sum].PoliticalOutlook.ToString();
                UserInfoMation.AppendChild(PoliticalOutlook);
                root.AppendChild(UserInfoMation);

                XmlElement Nation = document.CreateElement("Nation");
                Nation.InnerText = Collection.userAllList[sum].Nation.ToString();
                UserInfoMation.AppendChild(Nation);
                root.AppendChild(UserInfoMation);

                XmlElement Wages = document.CreateElement("Wages");
                Wages.InnerText = Collection.userAllList[sum].Wages.ToString();
                UserInfoMation.AppendChild(Wages);
                root.AppendChild(UserInfoMation);

                XmlElement Reward = document.CreateElement("Reward");
                Reward.InnerText = Collection.userAllList[sum].Reward.ToString();
                UserInfoMation.AppendChild(Reward);
                root.AppendChild(UserInfoMation);

                XmlElement Punishment = document.CreateElement("Punishment");
                Punishment.InnerText = Collection.userAllList[sum].Punishment.ToString();
                UserInfoMation.AppendChild(Punishment);
                root.AppendChild(UserInfoMation);

                XmlElement ContractInformation = document.CreateElement("ContractInformation");
                ContractInformation.InnerText = Collection.userAllList[sum].ContractInformation.ToString();
                UserInfoMation.AppendChild(ContractInformation);
                root.AppendChild(UserInfoMation);

                XmlElement AccountNum = document.CreateElement("AccountNum");
                AccountNum.InnerText = Collection.userAllList[sum].AccountNum.ToString();
                UserInfoMation.AppendChild(AccountNum);
                root.AppendChild(UserInfoMation);

                XmlElement PassWord = document.CreateElement("PassWord");
                PassWord.InnerText = Collection.userAllList[sum].PassWord.ToString();
                UserInfoMation.AppendChild(PassWord);
                root.AppendChild(UserInfoMation);
                document.Save(str);
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
