using DBCon1.test_dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 裕景管理系统.Dao
{
    class EmployeeCertificateDao : AbstractDao
    {

        public DataSet getDataSetAll() {
            OleDbConnection con = getCon(null);
            string sql = "select * from 员工证书管理表";
            

            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            //close the con
            closeAll(con, null, null);

            return ds;
        }


    }
}
