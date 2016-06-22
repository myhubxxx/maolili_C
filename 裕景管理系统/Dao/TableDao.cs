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
      private OleDbDataAdapter sda=null ;
        private DataSet ds=null;

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

            sda.Update(this.ds,tabName);

        }
        public void update(string dbName)
        {



            OleDbConnection con = getCon(dbName);
            string sql = "select * From " + dbName;
            sda = new OleDbDataAdapter(sql, con);

            OleDbCommandBuilder builder = new OleDbCommandBuilder(sda);
            sda.InsertCommand = builder.GetInsertCommand();
            sda.DeleteCommand = builder.GetDeleteCommand();
            sda.UpdateCommand = builder.GetUpdateCommand();

            this.ds = new DataSet();
            sda.Fill(this.ds, dbName);

            sda.Update(this.ds, dbName);

        }
        public DataSet get_tableds(string dbname,string tbname)
        {
            OleDbConnection con = getCon(dbname);
            string sql = "select * From " + tbname;
            OleDbDataAdapter sda = new OleDbDataAdapter(sql, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(sda);
            sda.InsertCommand = builder.GetInsertCommand();
            sda.DeleteCommand = builder.GetDeleteCommand();
            sda.UpdateCommand = builder.GetUpdateCommand();
            DataSet ds = new DataSet();
            sda.Fill(ds,tbname);
            return ds;
        }

        public OleDbDataAdapter get_tableda(string dbname, string tbname)
        {
            OleDbConnection con = getCon(dbname);
            string sql = "select * From " + tbname;
            OleDbDataAdapter sda = new OleDbDataAdapter(sql, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(sda);
            sda.InsertCommand = builder.GetInsertCommand();
            sda.DeleteCommand = builder.GetDeleteCommand();
            sda.UpdateCommand = builder.GetUpdateCommand();
            DataSet ds = new DataSet();
            sda.Fill(ds, tbname);
            return sda;
        }




    }
}
