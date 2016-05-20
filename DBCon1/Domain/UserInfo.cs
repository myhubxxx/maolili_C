using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.Domain
{
    class UserInfo
    {
        private int id;
        private string dept;//部门 

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        private string name;//姓名
        private string sex;// 性别
        private string nation;//民族
        private string birthplace;//籍贯

        public string Birthplace
        {
            get { return birthplace; }
            set { birthplace = value; }
        }
        private DateTime birthday;// 出生年月
        private DateTime startworktime; // 参加工作时间

        public DateTime Startworktime
        {
            get { return startworktime; }
            set { startworktime = value; }
        }
        private DateTime joinmycompanytime;//进入本公司时间

        public DateTime Joinmycompanytime
        {
            get { return joinmycompanytime; }
            set { joinmycompanytime = value; }
        }
        private string idcard; // 身份证号码
        private string position; // 职务

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        private string zhiyezhuce; // 执业注册

        public string Zhiyezhuce
        {
            get { return zhiyezhuce; }
            set { zhiyezhuce = value; }
        }
        private string graduateschool; // 毕业院校

        public string Graduateschool
        {
            get { return graduateschool; }
            set { graduateschool = value; }
        }
        private string education; // 学历

        public string Education
        {
            get { return education; }
            set { education = value; }
        }
        private string address; // 家庭住址
        private string ssn; // 社保号码 

        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }
        private string zhichengcard; // 职称证

        public string Zhichengcard
        {
            get { return zhichengcard; }
            set { zhichengcard = value; }
        }
        private string tele; // 联系电话
        private string remark; // 备注

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        

        public string Nation
        {
            get { return nation; }
            set { nation = value; }
        }
        

        public string Tele
        {
            get { return tele; }
            set { tele = value; }
        }
        

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

     

        public string Idcard
        {
            get { return idcard; }
            set { idcard = value; }
        }
        





    }
}

