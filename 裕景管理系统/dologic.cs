using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 裕景管理系统.Dao;
using 裕景管理系统.Domain;
using DBCon1.Domain;
using DBCon1.Dao;


namespace 裕景管理系统
{
    class dologic
    {
        public Dictionary<string, string> getadmin(string name)
        {
            AdminDao admin = new AdminDao();
            Dictionary<string, string> map = admin.loadByName(name);
            return map;
        }


        //get user by name
        public MyUser getuser(string name)
        {
            MyUserDao dao = new MyUserDao();
            MyUser user = dao.loadByName(name);
            return user;
        }
        //get user's password
        public string getpwd(string name)
        {
            MyUserDao dao = new MyUserDao();
            MyUser user = dao.loadByName(name);
            return user.Upass;
        }
        //get user's uselevel
        public int getlevel(string name)
        {
            MyUserDao dao = new MyUserDao();
            MyUser user = dao.loadByName(name);
            return user.Userlevel;
        }









    }
}
