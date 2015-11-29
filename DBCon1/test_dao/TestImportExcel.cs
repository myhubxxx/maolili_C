using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class TestImportExcel
    {
        public void test() {
            //importExcel();
            excelExport();
        }
        public void excelExport() {
            new ImportExcel().Export("人事部","purviewtable", "E://video//C#//dd.xlsx");
          //  Console.WriteLine(File.Exists("Template.xlsx"));
          //  Console.Read();
        }

        public void test1() {
            OleDbConnection con = ImportExcel.getCon("testread.xlsx");

            DataSet ds = new DataSet();
            string sql = "Select * from [Sheet1$]";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();


            Console.WriteLine("all:" + reader.FieldCount + reader.GetName(0)+"="+reader.GetName(1)+"="+reader.GetName(2));

            Console.WriteLine(reader.GetFieldType(0) + "=" + reader.GetFieldType(1) + "=" + reader.GetFieldType(2));

            while(reader.Read()){
                Console.WriteLine(reader.GetString(0)+"="+reader.GetDouble(1)+"="+reader.GetString(2));
                
            }
  
            con.Close();
            reader.Close();

            Console.Read();
        
        }

        public void importExcel() {
            MyDatabase data = new MyDatabase();
            data.TableName = "测试表";
            data.DBName = "人事部";
            for (int i = 0; i < 4; i++) {
                DBTableField field = new DBTableField();
                field.FieldName = "c#是垃圾" + i;
                field.Type = "varchar(50)";
                data.Columns.Add(field);
            }

          //  new ImportExcel().importExcel("人事部","G:\\C#_program\\mao_li_li\\DBCon1\\maolili_C\\DBCon1\\bin\\Debug\\testread.xlsx");
        
        }



    }
}
