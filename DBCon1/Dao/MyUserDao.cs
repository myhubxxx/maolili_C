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
    class MyUserDao : AbstractDao
    {

        // add 
        public void add(MyUser domain) {
            string sql = "insert into myuser(uname,upass,userlevel,dept_id) " +
                           "values(@uname,@upass,@userlevel,@dept_id) ";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param = {new OleDbParameter("@uname",domain.Uname),new OleDbParameter("@upass",domain.Upass),
                                     new OleDbParameter("@userlevel",domain.Userlevel),new OleDbParameter("@dept_id",domain.Dept_id)};
            cmd.Parameters.AddRange(param);

            cmd.ExecuteNonQuery();
             
            // close the con
            closeAll(con,cmd, null);

        }
        // update
        public void update(MyUser domain) {
            string sql = "update myuser set uname=@uname,upass=@upass,userlevel=@userlevel,dept_id=@dept_id where id=@id";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param = {new OleDbParameter("@uname",domain.Uname),new OleDbParameter("@upass",domain.Upass),
                                     new OleDbParameter("@userlevel",domain.Userlevel),new OleDbParameter("@dept_id",domain.Dept_id),
                                     new OleDbParameter("@id",domain.Id)};
            cmd.Parameters.AddRange(param);
            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con,cmd,null);

        }
        // load 
        public MyUser load(int id) {
            string sql = "select * from myuser where id=@id";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter param = new OleDbParameter("@id", id);
            cmd.Parameters.Add(param);

            MyUser domain = null;
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) {
                domain = new MyUser();

                domain.Id = reader.GetInt32(0);
                domain.Uname = reader.GetString(1);
                domain.Upass = reader.GetString(2);
                domain.Userlevel = reader.GetInt32(3);
                domain.Dept_id = reader.GetInt32(4);
            }


            // close the con
            closeAll(con, cmd, reader);

            return domain;

        }
        // load by name
        public MyUser loadByName(string uname) {
            string sql = "select * from myuser where uname=@uname";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql,con);
            OleDbParameter param = new OleDbParameter("@uname", uname);
            cmd.Parameters.Add(param);

            MyUser domain = null;
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) {
                domain = new MyUser();

                domain.Id = reader.GetInt32(0);
                domain.Uname = reader.GetString(1);
                domain.Upass = reader.GetString(2);
                domain.Userlevel = reader.GetInt32(3);
                domain.Dept_id = reader.GetInt32(4);
            }

            // close the con
            closeAll(con,cmd,reader);

            return domain;

        }

        // delete
        public void delete(int id) {
            string sql = "delete from myuser where id=@id";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter param = new OleDbParameter("@id",id);
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            //close the con
            closeAll(con, cmd, null);
        
        }

        // find by department
        public DataSet findByDept(int dept_id) {
            string sql = "select * from myuser where dept_id=" + dept_id;
            OleDbConnection con = getCon(null);

            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            //close the con
            closeAll(con, null, null);

            return ds;


        }


        // find all
        public DataSet findAll() {
            string sql = "select * from myuser";
            OleDbConnection con = getCon(null);

            OleDbDataAdapter adapter = new OleDbDataAdapter(sql,con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            //close the con
            closeAll(con,null,null);

            return ds;
        }
          
        // find all by list 
        public List<MyUser> findAll_List()
        {
            string sql = "select * from myuser";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);

            List<MyUser> list = new List<MyUser>();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                MyUser bean = new MyUser();

                bean.Id = reader.GetInt32(0);
                bean.Uname = reader.GetString(1);
                bean.Upass = reader.GetString(2);
                bean.Userlevel = reader.GetInt32(3);
                bean.Dept_id = reader.GetInt32(4);

                list.Add(bean);
            }
            
            //close the con
            closeAll(con, null, null);

            if (list.Count <= 0)
            {
                return null;
            }
            else
            {

                return list;
            }
        }

    }
}
