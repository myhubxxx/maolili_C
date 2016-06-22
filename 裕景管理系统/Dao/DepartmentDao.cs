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
    class DepartmentDao : AbstractDao
    {

        // add
        public void add(Department bean) {
            string sql = "insert into department(dept_name) values(@dept_name)";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql,con);
            OleDbParameter param = new OleDbParameter("@dept_name",bean.Dept_name);
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con,cmd,null);
        
        }
        // update
        public void update(Department bean) {
            string sql = "update department set dept_name=@dept_name where id=@id";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql,con);
            OleDbParameter[] param = {new OleDbParameter("@dept_name",bean.Dept_name),new OleDbParameter("@id",bean.Id)};
            cmd.Parameters.AddRange(param);

            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con, cmd, null);

        
        }
        // load
        public Department load(int id) {
            string sql = "select * from department where id=@id";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter param = new OleDbParameter("@id",id);
            cmd.Parameters.Add(param);

            OleDbDataReader reader = cmd.ExecuteReader();
            Department bean = null;
            if (reader.Read()) {
                bean = new Department();

                bean.Id = id;
                bean.Dept_name = reader.GetString(1);
                
            }

            // close the con
            closeAll(con, cmd, reader);

            return bean;

        }
        // search by name
        public Department loadByName(string dept_name) {
            string sql = "select * from department where dept_name=@dept_name";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql,con);
            OleDbParameter param = new OleDbParameter("@dept_name",dept_name);
            cmd.Parameters.Add(param);

            OleDbDataReader reader = cmd.ExecuteReader();
            Department bean = null;
            if (reader.Read()) {
                bean = new Department();

                bean.Id = reader.GetInt32(0);
                bean.Dept_name = reader.GetString(1);
            }

            return bean;
        }

        public Department loadall()
        {
            string sql = "select * from department ";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            Department bean = null;
            if (reader.Read())
            {
                bean = new Department();
                bean.Id = reader.GetInt32(0);
                bean.Dept_name = reader.GetString(1);

            }
            return bean;



        }
        // delete
        public void delete(int id) {
            string sql = "delete from department where id=@id";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql,con);
            OleDbParameter param = new OleDbParameter("@id",id);
            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con,cmd,null);

        
        }
        // find all
        public List<Department> findAll() {
            string sql = "select * from department";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql,con);

            OleDbDataReader reader = cmd.ExecuteReader();
            List<Department> list = new List<Department>();
            while (reader.Read()) {
                Department bean = new Department();

                bean.Id = reader.GetInt32(0);
                bean.Dept_name = reader.GetString(1);

                list.Add(bean);
            }
            if (list.Count() <= 0) {
                return null;
            }

            return list;
        }
        // find all
        public DataSet findAll_DataSet() {
            string sql = "select * from department";
            OleDbConnection con = getCon(null);

            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            // close the con
            closeAll(con, null, null);

            return ds;
        
        }

        public OleDbDataAdapter getadpter()
        {
            string sql = "select * from department";
            OleDbConnection con = getCon(null);
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            return da;
        }
        


    }
}
