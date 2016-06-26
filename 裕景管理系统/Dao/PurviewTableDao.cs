using DBCon1.Domain;
using DBCon1.test_dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace DBCon1.Dao
{
    class PurviewTableDao : AbstractDao
    {

        // add
        public void add(string dbName,PurviewTable form) {
            string sql = "insert into purviewtable(dept_userid,dept_table,purview) values(@dept_userid,@dept_table,@purview)";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param = {new OleDbParameter("@dept_userid",form.Dept_userid),new OleDbParameter("@dept_table",form.Dept_table),
                                     new OleDbParameter("@purview",form.Purview)};
            cmd.Parameters.AddRange(param);

            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con,cmd,null);


        }
        // update 
        public void update(string dbName,PurviewTable form) {
            string sql = "update purviewtable set dept_userid=@dept_userid,dept_table=@dept_table,purview=@purview where id=@id";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param = {new OleDbParameter("@dept_userid",form.Dept_userid),new OleDbParameter("@dept_table",form.Dept_table),
                                     new OleDbParameter("@purview",form.Purview),new OleDbParameter("@id",form.Id)};
            cmd.Parameters.AddRange(param);

            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con, cmd, null);
            
        
        }
        public void updatepur(string dbname, PurviewTable table)
        {
            string sql = "update purviewtable set dept_table=@dept_table,purview=@purview where dept_userid=@dept_userid";
            OleDbConnection con = getCon(dbname);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param = {new OleDbParameter("@dept_userid",table.Dept_userid),new OleDbParameter("@dept_table",table.Dept_table),
                                     new OleDbParameter("@purview",table.Purview),new OleDbParameter("@dept_userid",table.Dept_userid)};
            cmd.Parameters.AddRange(param);

            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con, cmd, null);

        }
        // load by id
        public PurviewTable load(string dbName,int id) {
            string sql = "select * from purviewtable where id=@id";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter param = new OleDbParameter("@id",id);
            cmd.Parameters.Add(param);

            OleDbDataReader reader = cmd.ExecuteReader();
            PurviewTable bean = null;
            if (reader.Read()) {
                bean = new PurviewTable();

                bean.Id = reader.GetInt32(0);
                bean.Dept_userid = reader.GetInt32(1);
                bean.Dept_table = reader.GetString(2);
                bean.Purview = reader.GetInt32(3);
            }

            // close the con
            closeAll(con, cmd, null);

            return bean;
        }
        //  delete
        public void delete(string dbName,int id) {
            string sql = "delete from purviewtable where id=@id";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql,con);
            OleDbParameter param = new OleDbParameter("@id", id);
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con, cmd, null);
            
        }
        // find all get DataSet
        public DataSet findAll_DataSet(string dbName) {
            string sql = "select * from purviewtable";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            // close the con
            closeAll(con, cmd, null);

            return ds;
        }
        // find all get List<PurviewTable>
        public List<PurviewTable> findAll_List(string dbName) {
            string sql = "select * from purviewtable";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);

            OleDbDataReader reader = cmd.ExecuteReader();
            List<PurviewTable> list = new List<PurviewTable>();
            while (reader.Read()) {
                PurviewTable bean = new PurviewTable();

                bean.Id = reader.GetInt32(0);
                bean.Dept_userid = reader.GetInt32(1);
                bean.Dept_table = reader.GetString(2);
                bean.Purview = reader.GetInt32(3);

                list.Add(bean);
            }
            
            // close the con
            closeAll(con,cmd,reader);

            if (list.Count <= 0)
            {
                return null;
            }

            return list;
        }


        // load  by dept_userid
        public List<PurviewTable> loadByUserid(string dbName,int dept_userid) {
            string sql = "select * from purviewtable where dept_userid=@dept_userid";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql,con);
            OleDbParameter param = new OleDbParameter("@dept_userid", dept_userid);
            cmd.Parameters.Add(param);

            OleDbDataReader reader = cmd.ExecuteReader();
            List<PurviewTable> list = new List<PurviewTable>();
            while (reader.Read())
            {
                PurviewTable bean = new PurviewTable();

                bean.Id = reader.GetInt32(0);
                bean.Dept_userid = reader.GetInt32(1);
                bean.Dept_table = reader.GetString(2);
                bean.Purview = reader.GetInt32(3);

                list.Add(bean);
            }
            
            // close the con
            closeAll(con, cmd, reader);

            if (list.Count() <= 0) {
                return null;
            }

            return list;
        }
        // load by dept_userid
        public DataSet loadByUseeid_DataSet(string dbName, int dept_userid)
        {
            string sql = "select * from purviewtable where dept_userid=" + dept_userid;
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);

            OleDbDataAdapter adapter = new OleDbDataAdapter(sql,con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            // close the con
            closeAll(con, null, null);

            return ds;
        }

        // load by dept_table
        public List<PurviewTable> loadByTable(string dbName,string dept_table) {
            string sql = "select * from purviewtable where dept_table=@dept_table";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter param = new OleDbParameter("@dept_table",dept_table);
            cmd.Parameters.Add(param);

            OleDbDataReader reader = cmd.ExecuteReader();
            List<PurviewTable> list = new List<PurviewTable>();
            while (reader.Read())
            {
                PurviewTable bean = new PurviewTable();

                bean.Id = reader.GetInt32(0);
                bean.Dept_userid = reader.GetInt32(1);
                bean.Dept_table = reader.GetString(2);
                bean.Purview = reader.GetInt32(3);

                list.Add(bean);
            }

            // close the con
            closeAll(con, cmd, reader);

            if (list.Count() <= 0)
            {
                return null;
            }

            return list;

        }
        public PurviewTable loadbyallinfomation(string dbName, string dept_table,int dept_user)
        {
            string sql = "select * from purviewtable where dept_userid=@dept_userid and dept_table=@dept_table";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param ={new OleDbParameter("@dept_userid",dept_user),
                                        new OleDbParameter("@dept_table", dept_table)
                                        };
            cmd.Parameters.AddRange(param);

            OleDbDataReader reader = cmd.ExecuteReader();
            PurviewTable bean = null;
            if (reader.Read())
            {
                bean = new PurviewTable();

                bean.Id = reader.GetInt32(0);
                bean.Dept_userid = reader.GetInt32(1);
                bean.Dept_table = reader.GetString(2);
                bean.Purview = reader.GetInt32(3);
            }

            // close the con
            closeAll(con, cmd, reader);

            return bean;


        }

        //load by table
        public PurviewTable getPVT(string dbname, string dept_table)
        {
            string sql = "select * from purviewtable where dept_table=@dept_table";
            OleDbConnection con = getCon(dbname);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter param = new OleDbParameter("@dept_table", dept_table);
            cmd.Parameters.Add(param);
            PurviewTable table = null;
               OleDbDataReader reader = cmd.ExecuteReader();
               if (reader.Read())
               {
                    table = new PurviewTable();
                    table.Id = reader.GetInt32(0);
                    table.Dept_userid = reader.GetInt32(1);
                    table.Dept_table = reader.GetString(2);
                    table.Purview = reader.GetInt32(3);


               }
               closeAll(con, cmd, reader);
               return table;


        }
        // load by dept_table
        public DataSet loadByTable_DataSet(string dbName, string dept_table) {
            string sql = "select * from purviewtable where dept_table=" + dept_table;
            OleDbConnection con = getCon(dbName);

            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            // close the con
            closeAll(con, null, null);

            return ds;


        
        }

    }
}
