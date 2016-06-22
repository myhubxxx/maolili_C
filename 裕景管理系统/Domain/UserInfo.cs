using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.Domain
{
    class UserInfo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private DateTime birthday;

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        private string nation;

        public string Nation
        {
            get { return nation; }
            set { nation = value; }
        }
        private string tele;

        public string Tele
        {
            get { return tele; }
            set { tele = value; }
        }
        private string address;

        public string Address//家庭住址
        {
            get { return address; }
            set { address = value; }
        }


        //private string email;

        //public string Email
        //{
        //    get { return email; }
        //    set { email = value; }
        //}
        //private string ndress;

        //public string Ndress
        //{
        //    get { return ndress; }
        //    set { ndress = value; }
        //}
        private string idcard;

        public string Idcard
        {
            get { return idcard; }
            set { idcard = value; }
        }
       /// private string grede;

        //public string Grede
        //{
        //    get { return grede; }
        //    set { grede = value; }
        //}
        //private string hunying;

        //public string Hunying
        //{
        //    get { return hunying; }
        //    set { hunying = value; }
        //}


        private string dept;//部门 

        public string Dept//部门
        {
            get { return dept; }
            set { dept = value; }
        }
        private string birthplace;//籍贯

        public string Birthplace
        {
            get { return birthplace; }
            set { birthplace = value; }
        }
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
        private string position;
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
        private string remark; // 备注

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

    }
}
