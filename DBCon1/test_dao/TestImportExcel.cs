using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class TestImportExcel
    {
        public void test1() {
            OleDbConnection con = ImportExcel.getCon("testread.xlsx");

            DataSet ds = new DataSet();
            string sql = "Select * from [Sheet1$]";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            Console.WriteLine(reader.GetName(0)+"="+reader.GetName(1)+"="+reader.GetName(2));

            Console.WriteLine(reader.GetFieldType(0) + "=" + reader.GetFieldType(1) + "=" + reader.GetFieldType(2));

            while(reader.Read()){
                Console.WriteLine(reader.GetString(0)+"="+reader.GetString(0)+"="+reader.GetString(2));
            
            }
            con.Close();
            reader.Close();

            Console.Read();
        
        }



    }
}
