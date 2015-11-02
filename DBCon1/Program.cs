using DBCon1.test_dao;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using DBCon1.Dao;
using System.Data;
using DBCon1.Domain;
using System.Configuration;

namespace DBCon1
{
    class Program
    {
        static void Main(string[] args)
        {

            new TestImportExcel().test1();

        //    bool status = ShareUtil.connectState(@"\\192.168.88.101\access", "administrator", "yangzeng,.1022");
            //         DirectoryInfo theFolder = new DirectoryInfo(@"\\192.168.88.101\access");
      //      test_4();
            //         string info = theFolder.FullName;
            //         Console.WriteLine(info);
 //           Console.WriteLine(status);
       //     Console.Read();

            //Console.WriteLine(ConfigurationManager.AppSettings["path"]);
            //Console.WriteLine(ConfigurationManager.AppSettings["userName"]);
            //Console.WriteLine(ConfigurationManager.AppSettings["passWord"]);
            //Console.Read();

        //    AccessOp.UpdataTabName("manager","heeh","newName");
           // Test_dao.UpdateTable();
          // AccessOp.DeleteAccessDb("人事部");
          //  AccessOp.DeleteAccessTab("人事部","测试表1");
            //test();
            //dictionary();
            //test_1();
            //thepath();
            //Access1.con2();
            //test_2();
            //test_3();
            //create_db_tab();
          //  create_totalTable();
         //   createPurviewTab();

         //   test_4();
          //  test_Dao();
          //  AccessOp.getColumns("manager","admin"); 
            //AccessOp.CreateAccessDb("test");
           // test_AdminDao();
           // test_MyUserDao();
         //  new  DepartmentDaoTest().test();

          //  new TestDbCreate().test();

          //  dept();    
          //  new TeatTotal_Dao().test();
          //  new Test_PurviewTableDao().test();

            //TableDao dao = new TableDao();
            //DataSet ds = dao.findAllByTable("人事部", "财务表");
            //DataTableReader reader = ds.CreateDataReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader.GetInt32(0) + " " + reader.GetString(1) + " " +
            //        reader.GetString(2));
            //}
            //Console.Read();
        }
        public static void dept() {
            DepartmentDao dao = new DepartmentDao();
           Department bean =  dao.loadByName("人事部");
        
        }

        public static void  test_MyUserDao(){
            MyUserDao dao = new MyUserDao();
            MyUser bean = new MyUser();
            // add
            //bean.Uname = "肖云"; bean.Upass = "123456"; bean.Userlevel = 0; bean.Dept_id = 3;
             //   dao.add(bean);
            //  update
            //bean.Id = 3; bean.Uname = "阿曼达"; bean.Upass = "qq123456"; bean.Userlevel = 0; bean.Dept_id = 3;
            //dao.update(bean);
            // load
           // bean = dao.load(3);
          //  Console.WriteLine("{0} {1} {2} {3} {4}",bean.Id,bean.Uname,bean.Upass,bean.Userlevel,bean.Dept_id);
          //  Console.Read();
                // find all
                //DataSet da = dao.findAll();
                //DataTableReader reader = da.CreateDataReader();
                //while(reader.Read())
                //Console.WriteLine("{0} {1} {2} {3} {4}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2),reader.GetInt32(3),reader.GetInt32(4));
                //Console.Read();
            // load by name
              //  bean = dao.loadByName("阿曼达");
              //  Console.WriteLine("{0} {1} {2} {3} {4}", bean.Id, bean.Uname, bean.Upass, bean.Userlevel, bean.Dept_id);
              //  Console.Read();
            // delete 
            dao.delete(5);


        }


        public static void test_AdminDao(){
            AdminDao dao = new AdminDao();

         //   dao.add("newUser","123456");
         //   dao.update(12, "changename", "890890");

            //Dictionary<string, string> map = dao.load(8);
            //Console.WriteLine(map["ID"] + " " + map["uname"] + " " + map["upass"] + " " + map["adminlevel"]);
            //Console.ReadLine();

            //DataSet ds = dao.findAll();
            //DataTableReader reader = ds.CreateDataReader();

            //Console.WriteLine("{0} {1} {2} ", reader.GetName(0), reader.GetName(1), reader.GetName(2));
            //while (reader.Read())
            //{
            //    Console.WriteLine("{0} {1} {2} {3}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2),reader.GetInt32(3));
            //}
            //Console.Read();

            dao.delete(14);
            Dictionary<string, string> map = dao.loadByName("胡");
            Console.WriteLine(map["ID"] + " " + map["uname"] + " " + map["upass"] + " " + map["adminlevel"]);
            Console.Read();
        }


        public static void test_Dao()
        {
            test_dao.Dao dao = new test_dao.Dao();
            //dao.add();
            //dao.update();
            //dao.load();
            //dao.delete();
            dao.all();

        }
        public static void test_4()
        {
            OleDbConnection con = AccessOp.getCon(null);
            OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from admin";
                cmd.Connection = con;
            OleDbDataAdapter db = new OleDbDataAdapter();
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("{0} {1} {2}", reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
            }



            AccessOp.closeAll(con, cmd, reader);
            Console.Read();
            
        }

        public static void createPurviewTab()
        {
            AccessOp.CreatePurviewTab("manager");
        }

        public static void create_totalTable() {

            AccessOp.CreateDeptTotalTab("manager");
        
        }

        public static void create_db_tab()
        {
            MyDatabase domain = new MyDatabase();
                domain.DbName = "管理";
                domain.TableName = "admin";
                Dictionary<string, string> columns = new Dictionary<string, string>();
                    columns.Add("username", "varchar(50)");
                    columns.Add("upass", "varchar(50)");
                    columns.Add("级别", "int");
                    domain.Columns = columns;
            AccessOp.CreateAccessDb(domain.DbName);
            AccessOp.CreateAccessTab(domain);    
        
        }

        public static void test_3()
        {
            MyDatabase domain = new MyDatabase();
            domain.DbName = "最烂的是C#";
            Console.WriteLine(domain.DbName);
            Console.ReadLine();
        }

        private static void test_2()
        {
            OleDbConnection con = AccessOp.getCon(null);


        }


        public static void test_1()
        {
            IDictionary<string, string> map = new Dictionary<string, string>();
                map.Add("username", "varchar(50)");
                map.Add("password", "varchar(50)");
                map.Add("adminlevel","integer");
           // AccessOp.CreateAccessTab("admin", map);
            
        
        }


        public static void test()
        {
            string file = "G:\\createAccess\\admin.accdb";
            AccessOp.CreateAccessDb(file);
            

        
        }
        public static void thepath()         
        {
            Assembly myAssembiy = Assembly.GetEntryAssembly();
            string nowPath = myAssembiy.Location;

            int index = nowPath.LastIndexOf("\\");
            nowPath = nowPath.Substring(0,index);
                

            Console.WriteLine(nowPath);
            Console.ReadLine();
        }
        
        public static void dictionary()
        { 
            IDictionary<string, object> map = new Dictionary<string,object>();

            map.Add("11","11");
            map.Add("22", "22");
            map.Add("33", "33");
            map.Add("55", "55");
            map.Add("66", "66");
            map.Add("77", "v7");
            map.Add("88", "88");

            foreach(KeyValuePair<string, object> temp in map)
            {
                Console.WriteLine(temp.Key + " : " + temp.Value);
            
            }


            //Console.WriteLine(map["77"]);
            Console.ReadLine();
        }
    }
}
