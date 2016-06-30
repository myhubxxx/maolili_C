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

        public DataSet getDataSetAll_ds() {
            OleDbConnection con = getCon(null);
            string sql = "select * from 员工证书管理表";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            DataSet ds = new DataSet();
            adapter.Fill(ds, "员工证书管理表");

            //close the con
            //closeAll(con, null, null);

            return ds;
        }

        public OleDbDataAdapter getDataSetALL_da()
        {
            OleDbConnection con = getCon(null);
            string sql = "select * from 员工证书管理表";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            DataSet ds = new DataSet();
            adapter.Fill(ds, "员工证书管理表");

            //close the con
          //  closeAll(con, null, null);
            return adapter;

        }


    }
}
