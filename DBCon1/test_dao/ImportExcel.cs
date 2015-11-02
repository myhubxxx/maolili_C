using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class ImportExcel
    {
        public ImportExcel() { }

        // the con string
        private readonly static string excelConString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                                         @"Data Source=" + "?" + ";" +
                                            "Extended Properties=\"Excel 12.0 Xml;HDR=YES\"";
 //       "Provider=Microsoft.ACE.OLEDB.12.0;DataSource="+filePath+";Extended Properties=\"Excel 12.0 Xml;HDR=No;IMEX=1\"";

        // return the cononetction 
        // param excelPath
        public static OleDbConnection getCon(string excelPath) {

            string conString = excelConString.Replace("?", excelPath);
            Console.WriteLine(conString);
            // get the con
            OleDbConnection con = new OleDbConnection(conString);
            con.Open();
            return con;
        }
        // get the columns
        public List<string> getColumns(string excelPath) {


            return null;
        }








    }
}
