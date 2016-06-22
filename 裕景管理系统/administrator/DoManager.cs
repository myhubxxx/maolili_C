using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBCon1.Domain;
using 裕景管理系统;
using System.Data;
using System.Data.OleDb;

using DBCon1.test_dao;
using DBCon1.Dao;
using System.Windows.Forms;

namespace 裕景管理系统.administrator
{
    class DoManager
    {
        //获得所有部门的dataset集合
        public DataSet getalldepart()
        {
            DepartmentDao dao = new DepartmentDao();
            DataSet ds = new DataSet();
          
            ds = dao.findAll_DataSet();
      
            return ds;
        }
      

        //以列表的形式获得所有部门
        public List<Department> getalldept_list()
        {
            DepartmentDao dao = new DepartmentDao();
            List<Department> list = dao.findAll();
            return list;
        }
        //以列表的形式查出某部门下的所有表格
        public List<TotalTable> get_alltable_list(string dept_name)
        {
            List<TotalTable> tables = new List<TotalTable>();
            TotalTableDao tabledao = new TotalTableDao();
            tables = tabledao.findAll(dept_name);
            return tables;


        }




       //按时间查询某不们下的某个表
        public List<TotalTable> getalltable_list(string dbname,DateTime t1,DateTime t2)
        {
            TotalTableDao dao = new TotalTableDao();
            List<TotalTable> list = dao.getByDate(dbname, t1, t2);
            return list;

        }  
        // 获得所有部门表中的所有部门的 dataadpter
        public OleDbDataAdapter getda()
        {
            DepartmentDao dao = new DepartmentDao();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = dao.getadpter();
            return da;
        }

        //获得部门下某个表的内容的dataset
        public DataSet gettableds(string dbname, string tbname)
        {
            TableDao dao = new TableDao();
            DataSet ds = dao.get_tableds(dbname, tbname);
            return ds;
        }

        //获得部门下某个表的内容的dataadapter
        public OleDbDataAdapter gettableda(string dbname, string tbname)
        {
            TableDao dao = new TableDao();
            OleDbDataAdapter da = dao.get_tableda(dbname, tbname);
            return da;

        }

        //获得用户详细表中的所有内容的dataset
        public DataSet getinfo_ds()
        {
            UserInfoDao dao = new UserInfoDao();
            DataSet ds = new DataSet();
            ds = dao.getallinfo_ds();
            return ds;


        }
        //获得用户详细表中的所有内容的dataadapter
        public OleDbDataAdapter getinfo_da()
        {
            UserInfoDao dao = new UserInfoDao();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = dao.getallinfo_da();
            return da;


        }

        //获得模拟部门下总表的内容的dataset
        public DataSet gettotaltable_ds(string dbname)
        {
            TotalTableDao dao = new TotalTableDao();
            DataSet ds = new DataSet();
            ds = dao.findAll_DataSet(dbname);
            return ds;


        }
        //获得模拟部门下总表的内容的adapter
        public OleDbDataAdapter gettotaltable_da(string dbname)
        {
            TotalTableDao dao = new TotalTableDao();
            OleDbDataAdapter da = dao.findAll_da(dbname);
            return da;
        }
        //增加一个部门
        public void adddepart(string newdepartment)
        {

            AccessOp.CreateAccessDb(newdepartment);
            AccessOp.CreateDeptTotalTab(newdepartment);
            AccessOp.CreatePurviewTab(newdepartment);
            DepartmentDao dao = new DepartmentDao();
            Department depe_name = new Department();
            depe_name.Dept_name = newdepartment;
            dao.add(depe_name);
           


        }
        //删除一个部门
        public void delete_dept(string dept)
        {
            AccessOp.DeleteAccessDb(dept);
        }

        //检查新建的部门是否已经存在
        public bool checkdept(string newdept)
        {
            List<Department> list = new List<Department>();
            list = getalldept_list();
            bool isnotexsit =true;
            foreach (Department e in list)
            {
                if (e.Dept_name == newdept)
                {
                    isnotexsit = false;
                    break;
                }
                
            }
            return isnotexsit;
           

        }
        //检查是否已经分配了一个经理账号
        public bool checkmanager_if_none()
        {
            List<MyUser> myuser = new List<MyUser>();
            MyUserDao dao = new MyUserDao();
            myuser = dao.findallmanager_list();
            if (myuser == null)
                return false;
            else
                return true;
        }
        //检查是否已经分配了一个员工账号
        public bool checkworker_if_none()
        {
            List<MyUser> myuser = new List<MyUser>();
            MyUserDao dao = new MyUserDao();
            myuser = dao.findalldept_worker();
            if (myuser == null)
                return false;
            else
                return true;

        }
        //检查是否用户详细信息表为空
        public bool checkuserinfo_if_none()
        {
            List<UserInfo> listinfo = new List<UserInfo>();
            UserInfoDao dao = new UserInfoDao();
            listinfo = dao.getAllByList();
            if(listinfo==null)
                return false;
            else
                return true;

        }
            
       
       
        
        //增加一个经理
        public void add_manager(string uername, string userpwd,string dept_name)
        {
            Department dept = new Department();
            DepartmentDao dao = new DepartmentDao();
            MyUser myuser = new MyUser();
            MyUserDao userdao = new MyUserDao();
            dept = dao.loadByName(dept_name);
            myuser.Uname = uername;
            myuser.Upass = userpwd;
            myuser.Userlevel = 1;
            myuser.Dept_id = dept.Id;
            userdao.add(myuser);

        }
        //检查是否经理的名字和密码是否已经有分配了
        public bool checkmanager(string managername,string userpwd)
        {
            bool isnotexesit_manager = true;
            MyUserDao dao = new MyUserDao();
            List<MyUser> myuser = new List<MyUser>();
            myuser = dao.findallmanager_list();
            foreach (MyUser user in myuser)
            {
                if (user.Uname == managername || user.Upass == userpwd)
                {
                    isnotexesit_manager = false;
                    break;
                }

            }
            return isnotexesit_manager;
        }

        //删除经理
        public void delete_woker(string name)
        {

            UserInfoDao userinfodao = new UserInfoDao();
            UserInfo userinfo = userinfodao.getByName(name);
            int id = userinfo.Id;
            MyUserDao dao = new MyUserDao();
            dao.delete(id);
        }

        //检查department表是否为空，是否已经分配了一个部门
        public bool checkdepartment()
        {
            DepartmentDao dao = new DepartmentDao();
            Department department = new Department();
            department = dao.loadall();
            if (department == null)
                return false;
            else
                return true;

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

        //检查新建的表名是否已经存在 
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

                    }
                }
            
            return isnotexesit;


        }

        //获得所有的经理的真实姓名
        public List<UserInfo> getmangername_list(int id)
        {
            MyUserDao userdao = new MyUserDao();
            List<MyUser> user = new List<MyUser>();
            UserInfoDao userinfodao = new UserInfoDao();
            List<UserInfo> infolist = new List<UserInfo>();
            List<int> listid = new List<int>();
            user =userdao .findBylevelList(id);
            listid = user.Select(a => a.Id).ToList();
            for (int i = 0; i < listid.Count; i++)
            {
                UserInfo userInfo = userinfodao.load(listid[i]);
                infolist.Add(userInfo);

            }
            return infolist;

        }
        //增加一个备忘录
        public void add_note(string username, string title, string content, DateTime endtime, int beforday)
        {
            BumRemindDao dao = new BumRemindDao();
            BumRemind remind = new BumRemind();
            AdminDao adao = new AdminDao();
            Dictionary<string, string> map = new Dictionary<string, string>();
            map = adao.loadByName(username);
            remind.UserId = int.Parse( map["ID"]);
            remind.Title = title;
            remind.Content = content;
            remind.EndTime = endtime;
            remind.BeforeDay = beforday;
            dao.addBumRemind(remind);
        }

        //根据账号查询备忘录信息的dataset
        public DataSet getBRds(string username)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            AdminDao addao = new AdminDao();
            map = addao.loadByName(username);
            BumRemindDao dao = new BumRemindDao();
            DataSet ds = new DataSet();
            ds = dao.get_BR_ds(8);
            return ds;
        }
        //根据账号查询备忘录信息的adpter
        public OleDbDataAdapter getBRda(string username)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            AdminDao addao = new AdminDao();
            BumRemindDao dao = new BumRemindDao();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = dao.get_BR_da(8);
            return da;

        }

        //检查管理员一天假的备忘录标题是不是一样
        public bool check_manager_note(string userna, string title)
        {
            bool is_not_same = true;
            BumRemindDao dao = new BumRemindDao();
            List<BumRemind> remind = new List<BumRemind>();
            AdminDao adao = new AdminDao();
            Dictionary<string, string> map = new Dictionary<string, string>();
            map = adao.loadByName(userna);
            remind = dao.getByUserIdList((int.Parse(map["ID"])));
            foreach (BumRemind e in remind)
            {if(e.Title==title)
                is_not_same = false;
                break;
            }
            return is_not_same;

        }
        //检查管理员添加的备忘录是否到期
        public void check_admin_note(string username)
        {
            DateTime currenttime = DateTime.Now;
            AdminDao admindao = new AdminDao();
            Dictionary<string, string> map = new Dictionary<string, string>();
            BumRemindDao bumdao = new BumRemindDao();
            List<BumRemind> list = new List<BumRemind>();
            try
            {
                map = admindao.loadByName(username);
                list = bumdao.getByUserIdList(int.Parse(map["ID"]));
            }
            catch(Exception ex)
            {
                ShareLib.Instance().HandleExcption(ex);
            }
            
            //karas: becareful, this will cause crash, because our db will changed by another one.

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
                    MessageBox.Show("您有一项事务到期了,请尽快处理:    " + remind.Content);
                    // 删除该事务
                     bumdao.deleteById(remind.Id);
                }
                if (day - cuday <= remind.BeforeDay)
                {
                    MessageBox.Show("您将在   " + time + "   有一项事务,请记得处理：    " + remind.Content);
                }
            }
        }
    }
}
