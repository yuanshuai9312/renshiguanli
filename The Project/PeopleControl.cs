using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static The_Project.Collection;

namespace The_Project
{
    public partial class PeopleControl : Form
    {
        string str = @"../../\UserInforMation\UserInformation.xml";
        UserAllInfoMation userAllInformation = new UserAllInfoMation();
        private string changeValue;
        private string _changValue;
        private string changText;
        public static  string SenAccountNum;
        public static string DPatment;
        public PeopleControl()
        {
            InitializeComponent();
        }
        public void LoadUserAllInformationXml()
        {
            Collection.userAllList.Clear();
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
        public void SetDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Department"));
            dt.Columns.Add(new DataColumn("Position"));
            dt.Columns.Add(new DataColumn("TeacherLevel"));
            dt.Columns.Add(new DataColumn("PoliticalOutlook"));
            dt.Columns.Add(new DataColumn("Nation"));
            dt.Columns.Add(new DataColumn("Wages"));
            dt.Columns.Add(new DataColumn("Reward"));
            dt.Columns.Add(new DataColumn("Punishment"));
            dt.Columns.Add(new DataColumn("ContractInformation"));
            dt.Columns.Add(new DataColumn("AccountNum"));
            dt.Columns.Add(new DataColumn("PassWord"));
            for (int i = 0; i < Collection.userAllList.Count; i++)
            {
                if (Collection.jurisdiction[0].Jurisdiction_level > 2)
                {
                    if (Login.Dpartment == Collection.userAllList[i].Department)
                    {
                        dt.Rows.Add(new object[] {Collection.userAllList[i].Department.ToString(),Collection.userAllList[i].Position.ToString(), Collection.userAllList[i].TeacherLevel.ToString(), Collection.userAllList[i].PoliticalOutlook.ToString(),
                    Collection.userAllList[i].Nation.ToString(),Collection.userAllList[i].Wages.ToString(),Collection.userAllList[i].Reward.ToString(),Collection.userAllList[i].Punishment.ToString(),
                    Collection.userAllList[i].ContractInformation.ToString(),Collection.userAllList[i].AccountNum.ToString(),Collection.userAllList[i].PassWord.ToString()});
                    }
                }
                else {
                    dt.Rows.Add(new object[] {Collection.userAllList[i].Department.ToString(),Collection.userAllList[i].Position.ToString(), Collection.userAllList[i].TeacherLevel.ToString(), Collection.userAllList[i].PoliticalOutlook.ToString(),
                    Collection.userAllList[i].Nation.ToString(),Collection.userAllList[i].Wages.ToString(),Collection.userAllList[i].Reward.ToString(),Collection.userAllList[i].Punishment.ToString(),
                    Collection.userAllList[i].ContractInformation.ToString(),Collection.userAllList[i].AccountNum.ToString(),Collection.userAllList[i].PassWord.ToString()});
                }
            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = dt;
           
        }
        private void PeopleControl_Load(object sender, EventArgs e)
        {         
            LoadUserAllInformationXml();
            SetDataGridView();
            dataGridView1.CurrentRow.Selected = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.ShowDialog();
            if (adduser.DialogResult==DialogResult.OK) {
                SetDataGridView();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ChangeMethod()
        {
            XmlDocument document = new XmlDocument();
            document.Load(str);
            XmlNodeList xnodelist = document.SelectSingleNode("UserInfo").ChildNodes;
            foreach (XmlNode xnode in xnodelist)
            {
                foreach (XmlNode  xlist in xnode) {
                    XmlElement ele = (XmlElement)xlist;
                    if (ele.Name==_changValue)
                    {
                        if (ele.InnerText==changeValue) {
                            XmlNodeList nodelist = ele.ParentNode.ChildNodes;
                            foreach (XmlNode node in nodelist)
                            {

                                XmlElement le = (XmlElement)node;
                                if (le.Name ==_changValue)
                                {
                                    le.InnerText = changText;
                                    document.Save(str);
                                }
                            }
                        }
                    }
                }
            }
        }
     
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {                    
            int columindex = dataGridView1.CurrentCell.ColumnIndex;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            changText =dataGridView1.CurrentCell.Value.ToString();          
            if (columindex ==0) {
                _changValue = "Department";
                changeValue = Collection.userAllList[rowIndex].Department;
                Collection.userAllList[rowIndex].Department.Replace(Collection.userAllList[rowIndex].Department, changText);
                ChangeMethod();

            } else if (columindex==1) {
                _changValue = "Position";
                changeValue = Collection.userAllList[rowIndex].Position;
                Collection.userAllList[rowIndex].Position.Replace(Collection.userAllList[rowIndex].Position, changText);
                ChangeMethod();
            }
            else if (columindex == 2)
            {
                _changValue = "TeacherLevel";
                changeValue = Collection.userAllList[rowIndex].TeacherLevel;
                Collection.userAllList[rowIndex].TeacherLevel.Replace(Collection.userAllList[rowIndex].TeacherLevel, changText);
                ChangeMethod();
            }
            else if (columindex == 3)
            {
                _changValue = "PoliticalOutlook";
                changeValue = Collection.userAllList[rowIndex].PoliticalOutlook;
                Collection.userAllList[rowIndex].PoliticalOutlook.Replace(Collection.userAllList[rowIndex].PoliticalOutlook, changText);
                ChangeMethod();
            }
            else if (columindex == 4)
            {
                _changValue = "Nation";
                changeValue = Collection.userAllList[rowIndex].Nation;
                Collection.userAllList[rowIndex].Nation.Replace(Collection.userAllList[rowIndex].Nation, changText);
                ChangeMethod();
            }
            else if (columindex == 5)
            {
                _changValue = "Wages";
                changeValue = Collection.userAllList[rowIndex].Wages;
                Collection.userAllList[rowIndex].Wages.Replace(Collection.userAllList[rowIndex].Wages, changText);
                ChangeMethod();
            }
            else if (columindex == 6)
            {
                _changValue = "Reward";
                changeValue = Collection.userAllList[rowIndex].Reward;
                Collection.userAllList[rowIndex].Reward.Replace(Collection.userAllList[rowIndex].Reward, changText);
                ChangeMethod();
            }
            else if (columindex == 7)
            {
                _changValue = "Punishment";
                changeValue = Collection.userAllList[rowIndex].Punishment;
                Collection.userAllList[rowIndex].Punishment.Replace(Collection.userAllList[rowIndex].Punishment, changText);
                ChangeMethod();
            }
            else if (columindex == 8)
            {
                _changValue = "ContractInformation";
                changeValue = Collection.userAllList[rowIndex].ContractInformation;
                Collection.userAllList[rowIndex].ContractInformation.Replace(Collection.userAllList[rowIndex].ContractInformation, changText);
                ChangeMethod();
            }
            else if (columindex == 9)
            {
                _changValue = "AccountNum";
                changeValue = Collection.userAllList[rowIndex].AccountNum;
                Collection.userAllList[rowIndex].AccountNum.Replace(Collection.userAllList[rowIndex].AccountNum, changText);
                ChangeMethod();
            }
            else if (columindex == 10)
            {
                _changValue = "PassWord";
                changeValue = Collection.userAllList[rowIndex].PassWord;
                Collection.userAllList[rowIndex].PassWord.Replace(Collection.userAllList[rowIndex].PassWord,changText);
                ChangeMethod();
            }
        }
        public void JedugMethod()
        {
            int row = dataGridView1.Rows.Count;//得到总行数    
            int cell = dataGridView1.Rows[0].Cells.Count;//得到总列数    
            for (int j = 0; j < row; j++)//得到总行数并在之内循环    
            {
                for (int k = 0; k < cell; k++)//得到总列数并在之内循环    
                {
                    if (Index.AccountNum == dataGridView1.Rows[j].Cells[k].Value.ToString())
                    {   //对比TexBox中的值是否与dataGridView中的值相同（上面这句）                                              
                        this.dataGridView1.Rows[j].Cells[1].ReadOnly = true;
                        this.dataGridView1.Rows[j].Cells[0].ReadOnly = true;
                        return;//返回    
                    }

                }
            }
        }
  

        private void 编辑信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.ReadOnly = false;
            for (int i = 0; i < Collection.userAllList.Count; i++)
            {
                if (Collection.jurisdiction[0].Jurisdiction_level == 1)
                {

                }
                else if (Index.AccountNum == Collection.userAllList[i].AccountNum)
                {
                    JedugMethod();
                }
            }
        }

        private void 人事调动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectIndexRow = dataGridView1.CurrentRow.Index;
            SenAccountNum = dataGridView1.Rows[selectIndexRow].Cells[9].Value.ToString();
            DPatment = dataGridView1.Rows[selectIndexRow].Cells[0].Value.ToString();
            SendUser adUser = new SendUser();
            adUser.ShowDialog();
            if (adUser.DialogResult==DialogResult.OK) {
                LoadUserAllInformationXml();
                SetDataGridView();
            }
        }

        private void fire注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectIndexRow = dataGridView1.CurrentRow.Index;
            SenAccountNum = dataGridView1.Rows[selectIndexRow].Cells[9].Value.ToString();
            XmlDocument document = new XmlDocument();
            document.Load(str);
            var root = document.DocumentElement;
            XmlNodeList xnodelist = document.SelectSingleNode("UserInfo").ChildNodes;
            foreach (XmlNode xnode in xnodelist) {
                XmlElement xl = (XmlElement)xnode;
                Console.WriteLine(xl.Name);
                foreach (XmlNode node in xnode) {
                    XmlElement ele = (XmlElement)node;
                    if (ele.Name== "AccountNum") {
                        if (ele.InnerText== SenAccountNum) {
                            string _str = ele.ParentNode.Name;
                           
                            ele.ParentNode.RemoveAll();
                            if (xl.Name==_str) {
                                root.RemoveChild(xl);
                            }                                                   
                            document.Save(str);
                            LoadUserAllInformationXml();
                            SetDataGridView();
                            MessageBox.Show("删除成功！");
                        }
                    }
                }
            }
        }

       
    }
}
