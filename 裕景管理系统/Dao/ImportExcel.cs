using DBCon1.Dao;
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
        //    Console.WriteLine(conString);
            // get the con
            OleDbConnection con = new OleDbConnection(conString);
            con.Open();
            return con;
        }

        public bool importExcelAllTable(string DBName, string excelPath) {
            // get the con 
            OleDbConnection con = getCon(excelPath);
            // get the tableNames
            List<string> tabNames = this.getExcelTableName(con);
            // importExcel table
            for (int i = 0; i < tabNames.Count; i++ ){
                
                importExcel(DBName, excelPath, tabNames[i]);
            
            }


            return true;
        }
        // Get the Excel info: the imported excle's Columns
        public MyDatabase getExcelDesc(string DBName, string excelPath, string tabName) {

            string sql = "Select top 1 * from [" + tabName + "$]";
            //     string sql = "select * from " + OleDbSchemaGuid.Tables;
            OleDbConnection con = getCon(excelPath);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            // use the reader to get the table head, it mean Table's  Columns, then put all Column to Dictinary_columns
            Dictionary<string, string> columns = new Dictionary<string, string>();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                // add the field name to columns
                columns.Add(reader.GetName(i), "varchar(50)");
            }
            int length = excelPath.Length;
            int lastIndex = excelPath.LastIndexOf("\\");
            int lastExec = excelPath.LastIndexOf(".");

            //     String excelName = excelPath.Substring(lastIndex + 1, lastExec - lastIndex - 1);

            //Console.WriteLine(excelName);
            //Console.Read();

            // add the info to the MyDataBase
            MyDatabase bean = new MyDatabase();
            bean.DBName = DBName;
            bean.TableName = tabName;
            foreach (KeyValuePair<string, string> entry in columns)
            {
                DBTableField field = new DBTableField();
                field.FieldName = entry.Key;
                field.Type = entry.Value;
                // add to the database.columns
                bean.Columns.Add(field);
            }

            // close all the connection
            AccessOp.closeAll(con, cmd, reader);

            /*if the excel.Table has data,then delete the Table data, There are must appear a very important Problem. this is no data,but has a Table columns is "ID F1".
             * so this IF is to solve the Situation. if the MyDatabase.Columns just has 1 clomu And the column is F1, mean the is't table.
             */
            if( bean.Columns.Count == 1 || bean.Columns[0].FieldName.Equals("F1") ){
                // just has 1 column And the column is F1
                throw new Exception("the Table is Null,has not column");
            }

            return bean;

        }

        // Import Table: include Create Table, import Data to Table
        public bool importExcel(string DBName,string excelPath, string tabName) {

            string sql = "Select * from [" + tabName + "$]";
       //     string sql = "select * from " + OleDbSchemaGuid.Tables;
            OleDbConnection con = getCon(excelPath);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            /*
            // use the reader to get the table head, it mean Table's  Columns, then put all Column to Dictinary_columns
            Dictionary<string, string> columns = new Dictionary<string, string>();
            for (int i = 0; i < reader.FieldCount; i++) { 
                // add the field name to columns
                columns.Add(reader.GetName(i), "varchar(50)");
            }
            int length = excelPath.Length;
            int lastIndex = excelPath.LastIndexOf("\\");
            int lastExec = excelPath.LastIndexOf(".");

       //     String excelName = excelPath.Substring(lastIndex + 1, lastExec - lastIndex - 1);

      //Console.WriteLine(excelName);
      //Console.Read();

            // add the info to the MyDataBase
            MyDatabase bean = new MyDatabase();
            bean.DBName = DBName;
            bean.TableName = tabName;
            foreach(KeyValuePair<string, string> entry in columns ){
                DBTableField field = new DBTableField();
                field.FieldName = entry.Key;
                field.Type = entry.Value;
                // add to the database.columns
                bean.Columns.Add(field);
            }
            */
            MyDatabase bean = null;
            try
            {
                // init the excel.table desc
                bean = getExcelDesc(DBName, excelPath, tabName);
            }
            catch (Exception e) {
                return false;
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
        // import the excel data to the assign table of database
        public bool importData(string DBName, string tabName, string excelPath)
        {
            OleDbConnection excelCon = getCon(excelPath);
            string headSql = "select ";

            // get the columns
            List<string> columns = AccessOp.getColumns(DBName, tabName);
            // add the info to the MyDataBase
            MyDatabase bean = new MyDatabase();
            bean.DBName = DBName;
            bean.TableName = tabName;
            for(int i=0; i < columns.Count ; i++)
            {   // jump the ID
                if (i != 0)
                {
                    if (i == 1) headSql = headSql + columns[i];
                    else headSql = headSql + "," + columns[i];

                    DBTableField field = new DBTableField();
                    field.FieldName = columns[i];
                    // field.Type = entry.Value;
                    // add to the database.columns
                    bean.Columns.Add(field);
                }
                
            }

            string endSql = headSql + " from [Sheet1$]";
            OleDbCommand cmd = new OleDbCommand(endSql, excelCon);
            OleDbDataReader reader = cmd.ExecuteReader();

            putDataToTable(reader, bean);

            // close all the Connection
            AccessOp.closeAll(excelCon, cmd, reader);

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
        // export the Data to the excel
        public bool exportExcel(string DBName, string table, string exportPath) {
            // get the access connect
            OleDbConnection con = AccessOp.getCon(DBName);
            string sql = "select * from " + table;
            OleDbCommand cmd = new OleDbCommand(sql, con);
            // execute the reader
            OleDbDataReader reader = cmd.ExecuteReader();

            // get the access table Columns
            List<string> tableColumns = AccessOp.getColumns(DBName, table);

            string insertSql = "insert into [Sheet1$]("; 
            string endInsertSql = " values(";
        // insert the columns name
            int columnsNum = reader.FieldCount;
            for (int i = 0; i < tableColumns.Count; i++)
            {
                if (i == 0)
                {
                    insertSql = insertSql + i;
                    endInsertSql = endInsertSql + "'" + tableColumns[i] + "'";
                }
                else
                {
                    insertSql = insertSql + "," + i;
                    endInsertSql = endInsertSql + ", '" + tableColumns[i] + "'";
                }

            }
            string columnName = insertSql + ")" + endInsertSql + ")";

           // Console.WriteLine(columnName);
            //Console.Read();

            OleDbConnection excelCon = ImportExcel.getCon(exportPath);
            OleDbCommand cmdInserSql = new OleDbCommand(columnName, excelCon);
            cmdInserSql.ExecuteNonQuery();
            AccessOp.closeAll(null, cmd, null);
        // end  insert the columns name


        // insert the data to excel

            while (reader.Read())
            {

                string dataSql = "insert into [Sheet1$](";
                string endDataSql = " values(";

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (i == 0)
                    {
                        dataSql = dataSql + i;
                        endDataSql = endDataSql + "'" + reader.GetValue(i).ToString() + "'";
                    }
                    else
                    {
                        dataSql = dataSql + "," + i;
                        endDataSql = endDataSql + ", '" + reader.GetValue(i).ToString() + "'";
                    }

                }
                string allDataSql = dataSql + ")" + endDataSql + ")";
                

                OleDbCommand dataCmd = new OleDbCommand(allDataSql, excelCon);
                dataCmd.ExecuteNonQuery();

                dataCmd.Dispose();
            }
            AccessOp.closeAll(excelCon, cmdInserSql, null);
        // end insert the data to excel



            // clsoe the connect
            AccessOp.closeAll(con, null, reader);

           return true;
        }
        // the file export
        public bool Export(String DBName, string tabName, string excelPath){

            File.Copy(@"Template.xlsx", excelPath, true);

            exportExcel(DBName, tabName, excelPath);



            return true;
        }
        // get the excel's all table name
        public List<string> getExcelTableName(OleDbConnection con) {
            List<string> tableNames = new List<string>();
            //  get the All Table Name
            DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            int tableCount = dt.Rows.Count;
            // add the Table Name to the tableNames
            for (int i = 0; i < tableCount; i++) {
                // the Table's Name
                // if the Sheet don't have any data,it don't appear.
                string name = dt.Rows[i][2].ToString().Trim().Replace("$", "");

                // check the table is null
                // now,if the Sheet has (any data) or (just has Table'Head),it will be true 
                //if ( !this.tableIsNull(con, name)) {
                    tableNames.Add(name);
                //}
            }

                return tableNames;
        }
        // check the table is null
        public bool tableIsNull(OleDbConnection con, string tableName) {
            string sql = "select count(*) from [" + tableName + "$]";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            int rowCount = (int)cmd.ExecuteScalar();
            
            // 
            if (rowCount != 0) {
                return false;
            }

            return true;
        }



    }
}
