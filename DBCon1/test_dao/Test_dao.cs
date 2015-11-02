using DBCon1.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class Test_dao : AbstractDao
    {


        private DataSet ds = null;
        private OleDbDataAdapter sda = null;



        static MyUserDao dao = new MyUserDao();

        public  void UpdateTable()
        {
            


            OleDbConnection con = getCon(null);
            string sql = "select * From admin";
            sda = new OleDbDataAdapter(sql,con);

            OleDbCommandBuilder builder = new OleDbCommandBuilder(sda);
            sda.InsertCommand = builder.GetInsertCommand();
            sda.DeleteCommand = builder.GetDeleteCommand();
            sda.UpdateCommand = builder.GetUpdateCommand();

            this.ds = new DataSet();
            sda.Fill(this.ds, "admin");

            

        }
    }
}
