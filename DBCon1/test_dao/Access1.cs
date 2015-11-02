using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCon1
{
    class Access1
    {
        public Access1() {}



        // 得到数据库的连接
        public static OleDbConnection getCon(string dbPath) 
        {
            OleDbConnection con = null;
           // string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;jet oledb:database password=123456;Data Source=G:\access_test\test.accdb";
            string conString = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;

            con = new OleDbConnection(conString);
            con.Open();
                        
            return con;
        }



        // 释放连接资源
        public static void closeAll(OleDbConnection con, OleDbCommand cmd, OleDbDataReader reader)
        {
            if (reader != null)
            {
                reader.Dispose();
                reader.Close();
            }
            if (cmd != null)
            {
                cmd.Dispose();
            }
            if (con != null)
            {
                con.Dispose();
                con.Close();
            }
        }

        public static void con2()
        {
            OleDbConnection con = getCon(null);

            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from 财务";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0}{1}{2}{3}",reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetInt32(3));
            }
            closeAll(con,cmd,reader);
            Console.ReadLine();
        }



        public void con1() 
        {
            // string conString = "DSN=Test1"; //tian表示ODBC的用户数据源名
            //  string sql = "select count(*) from user"; //stuinfo为用户数据源绑定的数据库中的一个表
            //  OdbcConnection con = new OdbcConnection(conString);
            //  con.Open();
            //  OdbcCommand com = new OdbcCommand(sql, con);
            //  int i = Convert.ToInt32(com.ExecuteScalar());
            //  Console.WriteLine(i);

            //OLEDB连接
            string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\access_test\test.accdb;Persist Security Info=False"; //连接Access数据库
           // string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\C#_program\test.accdb;"; //连接Access数据库

            OleDbConnection con = new OleDbConnection(conString);
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            com.CommandText = "select uid,uname,upass,ulevel from myuser";

            OleDbDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
            //    Console.WriteLine(id);
                string uname = reader.GetString(1);
             


                string upass = reader.GetString(2);
                int ulevel = reader.GetInt32(3);
                Console.WriteLine("{0}; {1}; {2}; {3}", id, uname, upass, ulevel);
            }

            //int i = Convert.ToInt32(com.ExecuteScalar());



            con.Close();      
        }

    }
}
