using DBCon1.test_dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace DBCon1.Dao
{
    class TableDao : AbstractDao
    {
        private OleDbDataAdapter sda = null;
        private DataSet ds = null;

		// find all 
        public DataSet findAllByTable(string dbName,string tabName) {
            string sql = "select * from " + tabName;
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql,con);

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            
            // close the con
            closeAll(con,cmd,null);

            return ds;
        }

        // update by the dataset from the Form
        public void Update(string dbName, string tabName)
        {



            OleDbConnection con = getCon(dbName);
            string sql = "select * From " + tabName;
            sda = new OleDbDataAdapter(sql, con);

            OleDbCommandBuilder builder = new OleDbCommandBuilder(sda);
            sda.InsertCommand = builder.GetInsertCommand();
            sda.DeleteCommand = builder.GetDeleteCommand();
            sda.UpdateCommand = builder.GetUpdateCommand();

            this.ds = new DataSet();
            sda.Fill(this.ds, tabName);

            
        }



    }
}
