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
    class TotalTableDao : AbstractDao
    {

        // add
        public void add(string dbName,TotalTable form ) {
            string sql = "insert into totaltable(tablename) values(@tablename)";
            OleDbConnection con  = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter param = new OleDbParameter("@tablename",form.Tablename);
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con, cmd, null);

        }
        // update
        public void update(string dbName,TotalTable form) {
            string sql = "update totaltable set tablename=@tablename where id=@id";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param = {new OleDbParameter("@tablename",form.Tablename),new OleDbParameter("@id",form.Id) };
            cmd.Parameters.AddRange(param);

            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con,cmd,null);


        }
        // load
        public TotalTable load(string dbName,int id) {
            string sql = "select * from totaltable where id=@id";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter param = new OleDbParameter("@id",id);
            cmd.Parameters.Add(param);

            OleDbDataReader reader = cmd.ExecuteReader();
            TotalTable bean = null;
            if (reader.Read()) {
                bean = new TotalTable();

                bean.Id = reader.GetInt32(0);
                bean.Tablename = reader.GetString(1);
            }

            // close the con 
            closeAll(con, cmd, reader);

            return bean;
        }
        // load by name
        public TotalTable loadByName(string dbName,string tableName) {
            string sql = "select * from totaltable where tablename=@tablename";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter param = new OleDbParameter("@tablename", tableName);
            cmd.Parameters.Add(param);

            OleDbDataReader reader = cmd.ExecuteReader();
            TotalTable bean = null;
            if (reader.Read())
            {
                bean = new TotalTable();

                bean.Id = reader.GetInt32(0);
                bean.Tablename = reader.GetString(1);
            }

            // close the con 
            closeAll(con, cmd, reader);

            return bean;
        }
        // delete
        public void delete(string dbName,int id){
            string sql = "delete from totaltable where id=@id";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql,con);
            OleDbParameter param = new OleDbParameter("@id",id);
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con, cmd, null);

        }
        //  search all
        public List<TotalTable> findAll(string dbName) {
            string sql = "select * from totaltable";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);

            OleDbDataReader reader = cmd.ExecuteReader();
            List<TotalTable> list = new List<TotalTable>();
            while(reader.Read()) {
                TotalTable bean = new TotalTable();

                bean.Id = reader.GetInt32(0);
                bean.Tablename = reader.GetString(1);

                list.Add(bean);
            }
            if (list.Count() <= 0) {
                return null;
            }

            return list;
        }
        // find all dataset
        public DataSet findAll_DataSet(string dbName) {
            string sql = "select * from totaltable";
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
