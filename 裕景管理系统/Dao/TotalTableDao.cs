﻿using DBCon1.Domain;
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
            string sql = "insert into totaltable(tablename,createTime) values(@tablename,@createTime)";
            OleDbConnection con  = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param ={ new OleDbParameter("@tablename",form.Tablename),
                                    new OleDbParameter("@createTime",form.getMyDate()),};

            cmd.Parameters.AddRange(param);

            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con, cmd, null);

        }
        // update
        public void update(string dbName,TotalTable form) {
            string sql = "update totaltable set tablename=@tablename, createTime=@createTime where id=@id";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param = {new OleDbParameter("@tablename",form.Tablename),
                                       new OleDbParameter("@createTime",form.getMyDate()) ,
                                         new OleDbParameter("@id",form.Id) };
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
                bean.CReatetime = reader.GetDateTime(2);
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
                // init the DataTime
                bean.CReatetime = reader.GetDateTime(2);
            }

            // close the con 
            closeAll(con, cmd, reader);

            return bean;
        }
        // Similar to Search, 
        public DataSet darkSearchByTableName(string dbName, string tabName)
        {
            string sql = "SELECT * FROM totaltable WHERE tablename LIKE '%"+ tabName +"%'";
            OleDbConnection con = getCon(dbName);

            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, dbName);

            // close the con
            closeAll(con, null, null);

            return ds;
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
                // init the DataTime
                bean.CReatetime = reader.GetDateTime(2);

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
        public OleDbDataAdapter findAll_da(string dbname)
        {
            string sql = "select * from totaltable";
            OleDbConnection con = getCon(dbname);

            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            return adapter;

        }
       

        // get the data in the startTime and endTime
        public List<TotalTable> getByDate(string DBName, DateTime startTime, DateTime endTime) {
            // check the date is right
            if (startTime > endTime) {
                //return null; 
                throw new Exception("the startTime is bigger than the endTime,please check your time");
            }
            // the return value
            List<TotalTable> list = new List<TotalTable>();

            //get the connect
            OleDbConnection con = getCon(DBName);
            string sql = "select * from totaltable where (createTime > @starttime and createTime < @endTime)";
            OleDbCommand cmd = new OleDbCommand(sql, con);

            OleDbParameter[] param = {new OleDbParameter("@startTime", startTime.ToString("d")),
                                        new OleDbParameter("@endTime", endTime.ToString("d"))  };
            cmd.Parameters.AddRange(param);
            
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                TotalTable total = new TotalTable();

                total.Id = reader.GetInt32(0);
                total.Tablename = reader.GetString(1);
                total.CReatetime = reader.GetDateTime(2);
                // put the info to the set
                list.Add(total);
            }
            // close the all connect
            closeAll(con, cmd, reader);

            return list;
        
        }

        public DataSet getByDateDS(string DBName, DateTime startTime, DateTime endTime)
        {
            // check the date is right
            if (startTime > endTime)
            {
                //return null; 
                throw new Exception("the startTime is bigger than the endTime,please check your time");
            }          

            //get the connect
            OleDbConnection con = getCon(DBName);
            string sql = "select * from totaltable where (createTime >= @starttime and createTime <= @endTime)";
            OleDbCommand cmd = new OleDbCommand(sql, con);

            OleDbParameter[] param = {new OleDbParameter("@startTime", startTime.ToString("d")),
                                        new OleDbParameter("@endTime", endTime.ToString("d"))  };
            cmd.Parameters.AddRange(param);

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);            
            DataSet ds = new DataSet();
            adapter.Fill(ds, DBName);


            // close the all connect
            closeAll(con, cmd, null);

            return ds;

        }

    }
}
