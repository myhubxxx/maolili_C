using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 裕景管理系统.Domain;
using DBCon1.Domain;
using DBCon1.Dao;
using System.Data.OleDb;
using 裕景管理系统.administrator;
using 裕景管理系统.manager;
namespace 裕景管理系统.manager
{
    class DoRrealManager
    {
        //获得经理的部门名称
        public string get_depatName(string username)
        {
            int dept_id;
            MyUser user = new MyUser();
            MyUserDao dao = new MyUserDao();
            DepartmentDao dept_dao=new DepartmentDao ();
            user = dao.loadByName(username);
            dept_id = user.Dept_id;
            ConstatData.department = dept_dao.load(dept_id);
            return ConstatData.department.Dept_name;

            

        }

        //获得某部门下totaltable的内容
        public List<TotalTable> gettables_list(string dbname)
        {
            TotalTableDao dao = new TotalTableDao();
            List<TotalTable> list = dao.findAll(dbname);
            return list;


        }

        //根据时间获得某部门下的某表

        public List<TotalTable> gettables_list( string dbname, DateTime t1,DateTime t2)
    {
            TotalTableDao dao = new TotalTableDao();
            List<TotalTable> list = dao.getByDate(dbname, t1, t2);
            return list;

    }
        //获得某部门某表的dataset
        public DataSet gettableds(string dbname, string tbname)
        {
            TableDao dao = new TableDao();
            DataSet ds = dao.get_tableds(dbname, tbname);
            return ds;
        }
        //获得某部门某表的dataadapter
        public OleDbDataAdapter gettableda(string dbname, string tbname)
        {
            TableDao dao = new TableDao();
            OleDbDataAdapter da = dao.get_tableda(dbname, tbname);
            return da;

        }
        //增加部门的员工

        public void add_dept_worker(string uername, string userpwd, string dept_name)
        {

            Department dept = new Department();
            DepartmentDao dao = new DepartmentDao();
            MyUser myuser = new MyUser();
            MyUserDao userdao = new MyUserDao();
            dept = dao.loadByName(dept_name);
            myuser.Uname = uername;
            myuser.Upass = userpwd;
            myuser.Userlevel = 0;
            myuser.Dept_id = dept.Id;
            userdao.add(myuser);
        }
        //检查新建的表名称是否在部门已经存在
        public bool checktablename(string dbname, string newtablename)
        {
            List<TotalTable> totaltable = new List<TotalTable>();
            TotalTableDao dao = new TotalTableDao();
            totaltable = dao.findAll(dbname);
            bool isnotexesit = true;
            foreach (TotalTable t in totaltable)
            {
                if (t.Tablename == newtablename)
                {
                    isnotexesit = false;
                    break;

                }
            }
            return isnotexesit;


        }
        //检查某部门是否totaltable为空
        public bool check_department_totaltable(string dbname)
        {
            List<TotalTable> totaltable = new List<TotalTable>();
            TotalTableDao dao = new TotalTableDao();
            totaltable = dao.findAll(dbname);
            if (totaltable == null)
                return false;
            else
                return true;
        }
        //检查用户是否已经录入了信息
        public bool cheke_userinfodetail(string username)
        {
            MyUser myuser = new MyUser();
            MyUserDao myuserdao = new MyUserDao();
            UserInfo userinfo = new UserInfo();
            UserInfoDao dao = new UserInfoDao();
            myuser = myuserdao.loadByName(username);
            userinfo = dao.load(myuser.Id);
            if (userinfo == null)
                return false;
            else
                return true;


        }

        //检查是否已经有了这个员工的账号和密码
        public bool check_dept_worker(string managername, string userpwd)
        {
            bool isnotexesit_manager = true;
            MyUserDao dao = new MyUserDao();
            List<MyUser> myuser = new List<MyUser>();
            myuser = dao.findalldept_worker();
            if (myuser == null || myuser.Count() == 0)
            {
                return true;
            }
            else
            {
                foreach (MyUser user in myuser)
                {
                    if (user.Uname == managername)
                    {
                        isnotexesit_manager = false;
                        break;
                    }

                }
            }
            return isnotexesit_manager;
        }

        //获得员工的真实姓名
        public List<UserInfo> getallworkername(int id)
        {
           

            MyUserDao dao = new MyUserDao();
            List<MyUser> user = dao.loadbydepet_id(ConstatData.department.Id,id);
            UserInfoDao d = new UserInfoDao();
            List<UserInfo> list = new List<UserInfo>();
            List<int> listId = user.Select(a => a.Id).ToList();
            for (int i = 0; i < listId.Count; i++)
            {

                UserInfo bean = d.load(listId[i]);
                if (bean != null)
                {
                    list.Add(bean);
                }
            }
            return list;

        }
        //删除一个员工
        public void delete_worker(string name)
        {
            UserInfoDao userinfodao = new UserInfoDao();
            UserInfo userinfo = userinfodao.getByName(name);
            int id = userinfo.Id;
            MyUserDao dao = new MyUserDao();
            dao.delete(id);

        }

        // 分配员工权限
        public void addlevel(string dbname, PurviewTable table)
        {
            PurviewTableDao dao = new PurviewTableDao();
            dao.add(dbname, table);


        }
        //检查某个员工是否已经被分配了权限
        public PurviewTable if_has_allocated( string dbname,int dept_user, string tablename)
        {
            //bool has_allocated = true;
            
              PurviewTableDao dao=new PurviewTableDao ();
              PurviewTable bean = dao.loadbyallinfomation(dbname, tablename, dept_user);
              if (bean != null)
              {// mean this user has the purview to the table,must check the Purview'value is same as the From'value,Same do no nothing, Not Same update Purivew'value


                  return bean;
                  
              }
              return null;

        }
        //修改用户权限
        public void changepurview(string dbname, PurviewTable table)
        {
            PurviewTableDao dao = new PurviewTableDao();
            dao.updatepur(dbname, table);

        }


        //获得purviewtable的dept_userid
        public int  gettable_dept_userid(string username)
        {
            PurviewTable table = new PurviewTable();
            UserInfoDao userinfodao = new UserInfoDao();
            UserInfo userinfo = new UserInfo();
               userinfo=userinfodao.getByName(username);
            table.Dept_userid = userinfo.Id;
            return table.Dept_userid;

        }
        //检查员工是否已经被分配了可操作表
        public bool check_worker_cando(string realname,string dbname)
        {
            UserInfoDao dao = new UserInfoDao();
            UserInfo user = new UserInfo();
            user = dao.getByName(realname);
            PurviewTableDao purdao = new PurviewTableDao();
            List<PurviewTable> list = new List<PurviewTable>();
            list = purdao.loadByUserid(dbname, user.Id);
            if (list==null)
                return false;
            else
                return true;



        }
        //检查是否purviewtable中有没有值
        public bool check_pur_none(string dbname)
        {
            List<PurviewTable> list = new List<PurviewTable>();
            PurviewTableDao dao = new PurviewTableDao();
            list = dao.findAll_List(dbname);
            if (list == null)
                return false;
            else
                return true;



        }


        //根据dept_userid查找puriewtable里的所有表格
        public List<PurviewTable> getpuriviewtables_list(string username,string dbname)
        {
            List<PurviewTable> list = new List<PurviewTable>();
            PurviewTableDao dao = new PurviewTableDao();
            UserInfoDao userinfodao = new UserInfoDao();
            UserInfo userinfo = new UserInfo();
            userinfo = userinfodao.getByName(username);
            list = dao.loadByUserid(dbname, userinfo.Id);
            return list;
           

        }
        // 通过表名去获得purviewtable的内容
        public PurviewTable get_pruiview(string dbname, string tbname)
        {
         
            PurviewTableDao dao = new PurviewTableDao();
            PurviewTable table = new PurviewTable();
            table = dao.getPVT(dbname, tbname);
            return table;
          
           


        }
        //更新权限表
        public void updatepriviewtable(string dbname, PurviewTable table)
        {
            PurviewTableDao dao = new PurviewTableDao();
             dao.update(dbname, table);

        }
        //检查增加的备忘录的标题是否一样
        public bool check_notes(string username,string title)
        {
            bool is_not_same=true;
            MyUser myuser = new MyUser();
            MyUserDao dao = new MyUserDao();
            List<BumRemind> note = new List<BumRemind>();
            BumRemindDao bumdao = new BumRemindDao();
            myuser = dao.loadByName(username);
            note = bumdao.getByUserIdList(myuser.Id);
            foreach (BumRemind e in note)
            {
                if (e.Title == title)
                {
                    is_not_same = false;
                    break;

                }
                  
            }
            return is_not_same;
        }
       

        //增加备忘录
        public void add_notes(string username, string title, string content, DateTime endtime, int beforday)
        {
            BumRemindDao dao = new BumRemindDao();
            BumRemind remind = new BumRemind();
            MyUserDao userdao = new MyUserDao();
            MyUser myuser = userdao.loadByName(username);
            remind.UserId = myuser.Id;
            remind.Title = title;
            remind.Content = content;
            remind.EndTime = endtime;
            remind.BeforeDay = beforday;
            dao.addBumRemind(remind);

        }
        //get notes 's ds
        public DataSet getBRds(string username)
        {
            MyUserDao userdao = new MyUserDao();
            MyUser myuser = userdao.loadByName(username);
            BumRemindDao dao = new BumRemindDao();
            DataSet ds = new DataSet();
            ds = dao.get_BR_ds(myuser.Id);
            return ds;

        }
        //get notes's da
        public OleDbDataAdapter getBRda(string username)
        {
            MyUserDao userdao = new MyUserDao();
            MyUser myuser = userdao.loadByName(username);
            BumRemindDao dao = new BumRemindDao();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = dao.get_BR_da(myuser.Id);
            return da;

        }

        public int  getPVT_id(string dbname, string tablename)
        {
            PurviewTable table = new PurviewTable();
            PurviewTableDao dao = new PurviewTableDao();
            table = dao.getPVT(dbname, tablename);
            return table.Id;


        }
        //检测是否备忘录中的时间到期
        public List<string > check_if_isdate(string username)
        {
            List<string> listnote = new List<string>();
            DateTime currenttime = DateTime.Now;  
            MyUserDao dao = new MyUserDao();
            MyUser myuser = new MyUser();
            BumRemindDao bumdao = new BumRemindDao();
            List<BumRemind> list = new List<BumRemind>();
            myuser = dao.loadByName(username);
            list = bumdao.getByUserIdList(myuser.Id);
            foreach (BumRemind remind in list)
            {
                int year = remind.EndTime.Year;
                int month = remind.EndTime.Month;
                int preday = remind.EndTime.Day;
                int day = remind.EndTime.Day - remind.BeforeDay;
               
                int cuday = currenttime.Day;
            
                string time = year + "/" + month + "/" + preday;
                if (currenttime >= remind.EndTime)
                {
                   //  删除该事务
                    bumdao.deleteById(remind.Id);

                }
                if (day - cuday <= remind.BeforeDay)
                {
                    listnote.Add("请您在" + time + "处理 " + remind.Content);
                }
            }
            return listnote;
        }

       

    }
}
