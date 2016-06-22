using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 裕景管理系统.Domain;
using 裕景管理系统.Dao;
using DBCon1.Domain;
using DBCon1.Dao;
namespace 裕景管理系统.staff
{
    class dostaff
    {

        //通过账号获得id
        public int getuserid(string username)
        {
            MyUser myuser = new MyUser();
            MyUserDao dao = new MyUserDao();
            myuser = dao.loadByName(username);
            return myuser.Id;


        }





        //获得员工可操作表
        public List<PurviewTable> gettables_cando(string dbname, int deptuser_id)
        {
            List<PurviewTable> table = new List<PurviewTable>();
            PurviewTableDao dao = new PurviewTableDao();
            table = dao.loadByUserid(dbname, deptuser_id);
            return table;



        }

       // 增加用户详细信息
        public void addinfo(string username,string name, string sex, string db, string nation, string jiguan, DateTime birthday,
            DateTime joinworktime, DateTime joincompanytime, string idcard, string zhiwu, string zhiyezhuce, string biyeyuanxiao,
            string xueli, string jiatingzhuzhi, string shebaohaoma, string zhichengzheng, string beizhu,string tele)
        {
            MyUserDao userdao = new MyUserDao();
            MyUser myuser = userdao.loadByName(username);
       
            UserInfoDao d = new UserInfoDao();
            UserInfo user = new UserInfo();
            user.Id = myuser.Id;
            user.Name = name;
            user.Sex = sex;
            user.Dept = db;
            user.Nation = nation;
            user.Birthplace = jiguan;
            user.Birthday = birthday;
            user.Startworktime = joinworktime;
            user.Joinmycompanytime = joincompanytime;
            user.Idcard = idcard;
            user.Position = zhiwu;
            user.Zhiyezhuce = zhiyezhuce;
            user.Graduateschool = biyeyuanxiao;
            user.Education = xueli;
            user.Address = jiatingzhuzhi;
            user.Ssn = shebaohaoma;
            user.Zhichengcard = zhichengzheng;
            user.Remark = beizhu;
            user.Tele = tele;
            d.add(user);




        }
        //检查是否该员工有可操作表

        public bool checkifcandao_table(string dbname,string username)
        {
           List<PurviewTable>list=new List<PurviewTable> ();
            PurviewTableDao dao = new PurviewTableDao();
            MyUser myuser = new MyUser();
            MyUserDao myuserdao = new MyUserDao();
            myuser = myuserdao.loadByName(username);
            list = dao.loadByUserid(dbname, myuser.Id);
            if (list == null)
                return false;
            else
                return true;

        }
        //检查员工是否已经填写了详细信息
        public bool cheke_userinfodetail(string username)
        {
            MyUser myuser=new MyUser ();
            MyUserDao myuserdao=new MyUserDao ();
            UserInfo userinfo = new UserInfo();
            UserInfoDao dao = new UserInfoDao();
            myuser = myuserdao.loadByName(username);
            userinfo = dao.load(myuser.Id);
            if (userinfo == null)
                return false;
            else
                return true;
         

        }

        //加载用户详细信息
        public UserInfo getuserinfo_list(string username)
        {
            MyUserDao userdao = new MyUserDao();
            MyUser myuser = userdao.loadByName(username);
            UserInfo user = new UserInfo();
            UserInfoDao dao = new UserInfoDao();
            user = dao.load(myuser.Id);
            return user;

        }
        //修改用户详细信息
        public void mdf(int id,string name, string sex, string db, string nation, string jiguan, DateTime birthday,
            DateTime joinworktime, DateTime joincompanytime, string idcard, string zhiwu, string zhiyezhuce, string biyeyuanxiao,
            string xueli, string jiatingzhuzhi, string shebaohaoma, string zhichengzheng, string beizhu, string tele)
        {
            UserInfo user = new UserInfo();
            UserInfoDao dao = new UserInfoDao();
         
            user.Id = id;
            user.Name = name;
            user.Sex = sex;
            user.Dept = db;
            user.Nation = nation;
            user.Address = jiatingzhuzhi;
            user.Birthplace = jiguan;
            user.Idcard = idcard;
            user.Position = zhiwu;
            user.Zhiyezhuce = zhiyezhuce;
            user.Education = xueli;
            user.Graduateschool = biyeyuanxiao;
            user.Birthday = birthday;
            user.Startworktime = joinworktime;
            user.Joinmycompanytime = joincompanytime;
            user.Ssn = shebaohaoma;
            user.Zhichengcard = zhichengzheng;
            user.Remark = beizhu;
            user.Tele = tele;
            dao.update(user);
          
   

        }
    }
}
