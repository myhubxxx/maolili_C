using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    abstract class AbstractDao
    {
        
       
        // 获取数据库连接
        public static OleDbConnection getCon(string db)
        {

            return AccessOp.getCon(db);
               
         }

        // 释放连接资源
        public static void closeAll(OleDbConnection con, OleDbCommand cmd, OleDbDataReader reader)
        {
            if (reader != null)
            {
                reader.Dispose();
                reader.Close();
            }
            if (cmd != null)
            {
                cmd.Dispose();
            }
            if (con != null)
            {
                con.Dispose();
                con.Close();
            }
        }
        


    }
}
