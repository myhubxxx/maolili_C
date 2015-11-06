using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class ImportExcel
    {
        public ImportExcel() { }

        // the con string
        //private readonly static string excelConString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        //                                 @"Data Source=" + "?" + ";" +
        //                                    "Extended Properties=\"Excel 12.0 Xml;HDR=YES\"";

        private readonly static string excelConString = ConfigurationManager.AppSettings["excelConString"];


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
        public bool importExcel(string DBName,string excelPath) {

            string sql = "Select * from [Sheet1$]";
            OleDbConnection con = getCon(excelPath);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            Dictionary<string, string> columns = new Dictionary<string, string>();
            for (int i = 0; i < reader.FieldCount; i++) { 
                // add the field name to columns
                columns.Add(reader.GetName(i), "varchar(50)");
            }
            int length = excelPath.Length;
            int lastIndex = excelPath.LastIndexOf("\\");
            int lastExec = excelPath.LastIndexOf(".");

            String excelName = excelPath.Substring(lastIndex + 1, lastExec - lastIndex - 1);

      //Console.WriteLine(excelName);
      //Console.Read();

            // add the info to the MyDataBase
            MyDatabase bean = new MyDatabase();
            bean.DBName = DBName;
            bean.TableName = excelName;
            foreach(KeyValuePair<string, string> entry in columns ){
                DBTableField field = new DBTableField();
                field.FieldName = entry.Key;
                field.Type = entry.Value;
                // add to the database.columns
                bean.Columns.Add(field);
            }

            // create the table 
           bool flag = AccessOp.CreateAccessTab(bean);
           if (flag == false) {
               throw new Exception("create database failure");
           }
            // put the data to the table
           flag = putDataToTable(reader, bean);
           if (flag == false)
           {
               throw new Exception("import data failure");
           }

            // close all connection
           AccessOp.closeAll(con, cmd, reader); 

            return true;
        }
        // put the Date to table
        public bool putDataToTable(OleDbDataReader reader, MyDatabase database) {
            // the access connection
            OleDbConnection con = AccessOp.getCon(database.DBName);


            String headSql = "insert into " + database.TableName + "(";
            int j = 0;
            foreach (var field in database.Columns) {
                if (j == 0)
                {
                    headSql = headSql + field.FieldName + " ";
                }
                else {
                    headSql = headSql + "," + field.FieldName + " ";
                }
                j++;
            }
            headSql = headSql + ") values(";

            while(  reader.Read()   ){

                string tempSql = "" + headSql;
                for (int i = 0; i < database.Columns.Count(); i++)
                {
                    if (i == 0)
                    {
                        tempSql = tempSql + " '" + reader.GetValue(i).ToString() + "'" + " ";
                    }
                    else {
                        tempSql = tempSql + ",'" + reader.GetValue(i).ToString() + "'" + " ";
                    }
                   
                }
                tempSql = tempSql + ")";

                // insert the info to database
                OleDbCommand cmd = new OleDbCommand(tempSql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            // close the connection
            AccessOp.closeAll(con, null, null);

            return true;
        }








    }
}
