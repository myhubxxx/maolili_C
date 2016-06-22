using DBCon1.Dao;
using DBCon1.test_dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace DBCon1.Dao
{
    class AdminDao : AbstractDao
    {

        // add the data
        public void add(string uname, string upass){
            string sql = "insert into admin(uname, upass,adminlevel) values(@uname,@upass,0)";
            OleDbConnection con = getCon(null);

            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param = { new OleDbParameter("@uname", uname), new OleDbParameter("@upass", upass) };
            cmd.Parameters.AddRange(param);

            cmd.ExecuteNonQuery();
              
            // close the con
            closeAll(con,cmd,null);
        }
        // update the data
        public void update(int id, string uname, string upass) {
            string sql = "update admin set uname=@uname,upass=@upass where id=@id";
            OleDbConnection con = getCon(null);

            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param = {new OleDbParameter("@uname",uname),new OleDbParameter("@upass",upass),new OleDbParameter("@id",id)};
            cmd.Parameters.AddRange(param);

            cmd.ExecuteNonQuery();
            
            // close the con
            closeAll(con,cmd,null);
        }
        // load the data
        public Dictionary<string,string> load(int id) {
            string sql = "select * from admin where id=@id";
            OleDbConnection con = getCon(null);

            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter param = new OleDbParameter("@id",id);
            cmd.Parameters.Add(param);

            OleDbDataReader reader = cmd.ExecuteReader();

            Dictionary<string, string> map = null;

            if (reader.Read())
            {
                map = new Dictionary<string, string>();

                map.Add(reader.GetName(0), reader.GetInt32(0) + "");
                map.Add(reader.GetName(1), reader.GetString(1));
                map.Add(reader.GetName(2), reader.GetString(2));
                map.Add(reader.GetName(3), reader.GetInt32(3) + "");
            }
            //Console.WriteLine("{0} {1} {2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));
         //   Console.Read();

            //close the con
            closeAll(con,cmd,reader);

            return map;
        
        }

        // load by name
        public Dictionary<string,string> loadByName(string uname) {
            string sql = "select * from admin where uname=@uname";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter param = new OleDbParameter("@uname", uname);
            cmd.Parameters.Add(param);

            Dictionary<string, string> map = new Dictionary<string, string>();
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) {
                map = new Dictionary<string, string>();

                map.Add(reader.GetName(0), reader.GetInt32(0) + "");
                map.Add(reader.GetName(1), reader.GetString(1));
                map.Add(reader.GetName(2), reader.GetString(2));
                map.Add(reader.GetName(3), reader.GetInt32(3) + "");
            }

            // close the con
            closeAll(con,cmd,reader);

            return map;

        }

        // delete the data
        public void delete(int id) {
            string sql = "delete from admin where id=@id";
            OleDbConnection con = getCon(null);

            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter param = new OleDbParameter("@id",id);
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con, cmd, null);
        
        }
        // search all
        public DataSet findAll() {
            string sql = "select * from admin";
            OleDbConnection con = getCon(null);

            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            // close the con
            closeAll(con, null, null);

            return ds;
        
        }

    

    }
}
