using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class TestSchema : ImportExcel
    {
        public void test(){

            //schema();
            //tebleIsNull();
            //getExcelTableName();
            importExcelAllTable("西瓜部门", "testread");
        }

        public void getExcelTableName()
        {
            OleDbConnection con = getCon("testNoName");
            List<string> names = base.getExcelTableName(con);

        }
        public void tebleIsNull() { 
            ImportExcel ie = new ImportExcel();
            OleDbConnection con = getCon("testNoName");

            Console.Write(ie.tableIsNull(con,"dd"));
            Console.Read();
        }
        public void schema() {
            OleDbConnection con = getCon("testNoName");

            DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            // 
            string name = dt.Rows[0][2].ToString().Trim();
            // num : the tables num
            int num = dt.Rows.Count;
            Console.WriteLine(num + ":" + 
                                dt.Rows[0][2].ToString().Trim()+ "," +
                                dt.Rows[1][2].ToString().Trim()+ "," +
                                dt.Rows[2][2].ToString().Trim());

       //     Console.Write(name);
            Console.Read();
        
        }

    }
}
