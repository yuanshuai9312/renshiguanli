using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Project
{
    public class Collection
    {
        public static List<UserLoginInfoMation> userList = new List<UserLoginInfoMation>();
        public static List<UserAllInfoMation> userAllList = new List<UserAllInfoMation>();
        public static List<Jurisdiction> jurisdiction = new List<Jurisdiction>();
        public static List<GongchengbuInfo> GInfo = new List<GongchengbuInfo>();
        public struct UserLoginInfoMation
        {
            public string Department;
            public string AccountNum;
            public string PassWord;
            public string Position;
        }

        public struct UserAllInfoMation
        {
            public string Department;
            public string Position;//zhiwei          
            public string TeacherLevel;
            public string PoliticalOutlook;//zhengzhimianmao
            public string Nation;//mingzu
            public string Wages;//gongzi
            public string Reward;//jiangli
            public string Punishment;//chengfa
            public string ContractInformation;//hetongxinxi
            public string AccountNum;
            public string PassWord;          
        }
        //权限
        public struct Jurisdiction
        {
            public int Jurisdiction_level;       
        }


        public struct GongchengbuInfo
        {
            public string DTime;
            public string Project;
            public string Speed_progress;
            public string MakePeople;
        }
    }
  
}
