using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class Dao : AbstractDao
    {
        // insert is sure
        public void add()
        {
            OleDbConnection con =  getCon(null);
            OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                string sql = "insert into admin(uname,upass,adminlevel) " +
                                " values(@uname,@upass,0)";
                OleDbParameter[] param = {new OleDbParameter("@uname","new_name"),new OleDbParameter("@upass","new_pass")};
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                closeAll(con, cmd, null);
         }
        // update 
        public void update()
        {
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;

            string sql = "update admin set uname=@uname,upass=@pass where id=@id";
            cmd.CommandText = sql;
            OleDbParameter[] param = { new OleDbParameter("@uname", "change_name"), new OleDbParameter("@upass", "change_pass"), new OleDbParameter("@id", 11) };
            cmd.Parameters.AddRange(param);

            cmd.ExecuteNonQuery();

            closeAll(con, cmd, null);
        }
        // select
        public void load()
        {
            string sql = "select * from admin where id=@id";

            OleDbConnection con = getCon(null);
            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            OleDbParameter param = new OleDbParameter("@id",11);
            cmd.Parameters.Add(param);
            OleDbDataReader reader =  cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0} {1} {1} {3}",reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetInt32(3));
            }
            Console.ReadLine();
        }
        // delete
        public void delete()
        {
            string sql = "delete from admin where id=@id";

            OleDbConnection con = getCon(null);
            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            OleDbParameter param = new OleDbParameter("@id",11);
            cmd.Parameters.Add(param);
            int num = cmd.ExecuteNonQuery();
            Console.WriteLine(num);
            Console.ReadLine();
        }
        // load all
        public void all()
        {
            string sql = "select * from admin";

            OleDbConnection con = getCon(null);
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();
            //while (reader.Read()) {
            //    Console.WriteLine("{0} {1} {2} {3}",reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetInt32(3));
            //}

            List<string> list = new List<string>();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                list.Add(reader.GetName(i));
                Console.WriteLine(reader.GetName(i) + " ");
            }
            
            Console.Read();

            
        }


    }
}
