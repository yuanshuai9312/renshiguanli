
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
using System.Xml.Linq;
using static The_Project.Collection;

namespace The_Project
{
    public partial class Creat : Form
    {
        //yanfa
        string str = @"../../\GongchengbuXml\GongchengbuXml.xml";
        GongchengbuInfo gongchengbuInfo = new GongchengbuInfo();
        public Creat()
        {
            InitializeComponent();
        }
        public void LoadXml()
        {
            XmlDocument document = new XmlDocument();
            document.Load(str);
            int count = document.SelectSingleNode("Gongchengbu").ChildNodes.Count;
            for (int i=0;i<count;i++)
            {
                XDocument dt = XDocument.Load(str);
                XElement root = dt.Root;
                XElement ele = root.Element("GongchengbuInfo"+i);
                XElement DTime = ele.Element("DTime");
                XElement Project = ele.Element("Project");
                XElement Speed_progress = ele.Element("Speed_progress");
                XElement MakePeople = ele.Element("MakePeople");
                gongchengbuInfo.DTime = DTime.Value.ToString();
                gongchengbuInfo.Project = Project.Value.ToString();
                gongchengbuInfo.Speed_progress = Speed_progress.Value.ToString();
                gongchengbuInfo.MakePeople = MakePeople.Value.ToString();
                Collection.GInfo.Add(gongchengbuInfo);

            }
        }
        private void Creat_Load(object sender, EventArgs e)
        {

        }
    }
}
