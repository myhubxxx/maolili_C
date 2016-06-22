using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOX;
using System.IO;
using System.Reflection;
using System.Data.OleDb;
using System.Configuration;
using DBCon1.Dao;
using DBCon1.Domain;

namespace DBCon1.test_dao
{
    class AccessOp
    {
        public static readonly string url = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;

        public static readonly string sharePath = ConfigurationManager.AppSettings["sharePath"];
        public static readonly string userName = ConfigurationManager.AppSettings["userName"];
        public static readonly string passWord = ConfigurationManager.AppSettings["passWord"];


        // get the now path
        public static string getPath()
        {
            Assembly myAssembiy = Assembly.GetEntryAssembly();
            string nowPath = myAssembiy.Location;

            int index = nowPath.LastIndexOf("\\");
            nowPath = nowPath.Substring(0, index);

            return nowPath;
        }
        // use shareutil get in
        public static void  getShare(){

            if (sharePath == null) {
                return;
            }
            
            ShareUtil.connectState(@sharePath, userName, passWord);

        }
        // 得到数据库的连接
        public static OleDbConnection getCon(string db)
        {
            getShare();

            // 默认数据库
            string dbName = "manager";

            string condb = null;
            //
            if (null != db )
            {
                condb = db;
            }else{
                condb = dbName;
            }



            OleDbConnection con = null;
            // string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;jet oledb:database password=123456;Data Source=G:\access_test\test.accdb";
            

            string conString = url + condb + ".accdb";
        //    Console.WriteLine(conString); Console.Read();
            con = new OleDbConnection(conString);
            con.Open();

            return con;
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

         /// <summary>
        /// 创建access数据库
        /// </summary>
        /// <param name="filePath">数据库文件的全路径，如 D:\\NewDb.mdb</param>
        public static bool CreateAccessDb(string accessFile)
        {

            string end = ".accdb";

            ADOX.Catalog catalog = new Catalog();
            if (!File.Exists(accessFile))
            {
                try
                {
                    catalog.Create(url + accessFile + end );
                }
                catch (System.Exception ex)
                {
                    return false;
                }
            }

            // create the db's table totalTable , purviewTable
            CreateDeptTotalTab(accessFile);
            CreatePurviewTab(accessFile);
           // end the create two table      

            return true;
        }

        // 创建表 
        //  通过遍历map对象，获取字段名称,以及字段类型
        public static bool CreateAccessTab(MyDatabase domain)
        {
//=====START==============================
            //// get the database value
            //string dbName = domain.DbName;
            //string tableName = domain.TableName;
            //Dictionary<string, string> columns = domain.Columns;
            //// end get the database value



            //// the head sql
            //string tabSql = "create table ?(id int not null identity(1,1) primary key";
            //// make suer the table name
            //tabSql = tabSql.Replace("?", tableName);
            //// the end ")"
            //string end = ")";

            //foreach(KeyValuePair<string, string> entry in columns)
            //{
            //    string column_name = entry.Key;
            //    string column_prop = entry.Value;

            //    string catSql = ", " + column_name + " " + column_prop + " not null";
            //  //  catSql = catSql.Replace("?", column_name).Replace("?", column_prop);

            //    tabSql = tabSql + catSql;
            //}
            //// the created SQL has finished
            //tabSql = tabSql + end;
            
            //// connect the db
            //OleDbConnection con = AccessOp.getCon(dbName);
            //OleDbCommand cmd = con.CreateCommand(); 
            //    cmd.Connection = con;
            //    cmd.CommandText = tabSql;

            //    try
            //    {
            //        cmd.ExecuteNonQuery();
            //    }
            //    catch (SystemException ex)
            //    {
            //        return false;
            //    }

            //    // close the con 
            //    AccessOp.closeAll(con, cmd, null);
//====END=========================================

            // the head sql
            string tabSql = "create table ?("
                             + "id int not null identity(1,1) primary key";
            // make suer the table name
            tabSql = tabSql.Replace("?", domain.TableName);
            // the end ")"
            string end = ")";

            foreach (var field in domain.Columns)
            {

                string catSql = ", " + field.FieldName + " " + field.Type.ToLower() + " not null";
                //  catSql = catSql.Replace("?", column_name).Replace("?", column_prop);

                tabSql = tabSql + catSql;
            }
            // the created SQL has finished
            tabSql = tabSql + end;

            // connect the db
            OleDbConnection con = AccessOp.getCon(domain.DBName);
            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = tabSql;
            //........
            try
            {
                cmd.ExecuteNonQuery();
                // and info to toltable 
                TotalTable table = new TotalTable();
                table.Tablename = domain.TableName;
                new TotalTableDao().add(domain.DBName, table);
            }
            catch (SystemException ex)
            {
                return false;
            }

            // close the con 
            AccessOp.closeAll(con, cmd, null);

            return true;
        }

        // create the  totalTable 
        public static bool CreateDeptTotalTab(string dbName)
        {
            string totaltableSql = "create table totaltable(id integer identity(1,1) primary key," +
                                    " tablename varchar(50) not null," +
                                    "createTime Time not null )";

            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = con.CreateCommand();
                cmd.Connection = con;
                cmd.CommandText = totaltableSql;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SystemException ex)
                {
                    Console.WriteLine(ex);
                    Console.Read();
                    return false;
                }

                // close the con
                AccessOp.closeAll(con, cmd, null);

            return true;
        }

        // create the purviewTable
        public static bool CreatePurviewTab(string dbName)
        {
            string totaltableSql = "create table purviewtable(id integer identity(1,1) primary key," +
                                    " dept_userid integer not null," +
                                    " dept_table varchar(50) not null," +
                                    " purview integer not null )";

            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = totaltableSql;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SystemException ex)
            {             
                return false;
            }

            // close the con
            AccessOp.closeAll(con, cmd, null);

            return true;
        
        }

        // alter the table name
        public static void UpdataTabName(string dbName, string tabName, string newName) {
            string sql = "exec sp_rename @tabName,@newName,'OBJECT'";
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param = { new OleDbParameter("@tabName", tabName), new OleDbParameter("@newName", newName) };
            cmd.Parameters.AddRange(param);

            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con, cmd, null);

        }

        // did't finish it 
        public static void ChangeTabName() { 
            //Dim Conn,ConnStr,oCat,oTbl;
            //ConnStr = "Provider=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=manager.accdb";
            //Set oCat=Server.CreateObject("ADOX.Catalog") ;
            //oCat.ActiveConnection = ConnStr;

            //Set oTbl = Server.CreateObject("ADOX.Table");
            //Set oTbl = oCat.Tables("OldTable"); //	'要重命名的表名：OldTable
            //oTbl.Name = "NewTable";	    //'新表名
            //Set oCat = Nothing;
            //Set oTbl = Nothing;
            //String ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("data.mdb");
            //ADOX.Catalog oCat = (ADOX.Catalog)Server.CreateObject("ADOX.Catalog");
            //oCat.ActiveConnection = ConnStr;



        }



        // you need delete the info in totalTable
        // you need finish it
        // delete the Table 
        public static bool DeleteAccessTab(string dbName,string tabName) {
            OleDbConnection con = getCon(dbName);

            // delete the tabName in totalTable
            string sql_totalTab = "delete from totaltable where tablename=@tabName";
            OleDbCommand cmd2 = new OleDbCommand(sql_totalTab, con);
            OleDbParameter param = new OleDbParameter("@tabName",tabName);
            cmd2.Parameters.Add(param);
            cmd2.ExecuteNonQuery();


            // drop the table
            string sql = "drop table " + tabName;
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();

            // close the con
            closeAll(con, cmd, null);


            return true;
        }

        // you should delete the info in Manager.Department
        // you need finish it
        // delete the Access db
        public static bool DeleteAccessDb(string dbName) {

            //  delete from the info in department
            DepartmentDao dao = new DepartmentDao();
            Department bean = dao.loadByName(dbName);
            dao.delete(bean.Id);


            // delete the access file
            string url_path = ConfigurationManager.AppSettings["path"].ToString();
 
            string path = url_path + "" + dbName + ".accdb";
            // if the file is exist,then,delete it
            if (File.Exists(path)) {
                File.Delete(path);
            }


            return true;
        }







        // get table columns
        public static List<string> getColumns(string dbName, string tabName ) 
        {
            List<string> list = new List<string>();

            string sql = "select top 1 * from " + tabName; 
            OleDbConnection con = getCon(dbName);
            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            OleDbDataReader reader = cmd.ExecuteReader();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                list.Add( reader.GetName(i));

            }
            // close the connection
            AccessOp.closeAll(con, cmd, reader);

            return list;
        }



        /// <summary>
        /// 在access数据库中创建表
        /// </summary>
        /// <param name="filePath">数据库表文件全路径如D:\\NewDb.mdb 没有则创建 </param> 
        /// <param name="tableName">表名</param>
        /// <param name="colums">ADOX.Column对象数组</param>
        //public static void createaccesstable(string filepath, string tablename, params adox.column[] colums)
        //{
        //    adox.catalog catalog = new catalog();
        //    //数据库文件不存在则创建
        //    if (!file.exists(filepath))
        //    {
        //        try
        //        {
        //            catalog.create("provider=microsoft.jet.oledb.4.0;data source=" + filepath + ";jet oledb:engine type=5");
        //        }
        //        catch (system.exception ex)
        //        {
        //        }
        //    }
        //    adodb.connection cn = new adodb.connection();
        //    cn.open("provider=microsoft.jet.oledb.4.0;data source=" + filepath, null, null, -1);
        //    catalog.activeconnection = cn;
        //    adox.table table = new adox.table();
        //    table.name = tablename;
        //    foreach (var column in colums)
        //    {
        //        table.columns.append(column);
        //    }
        //    // column.parentcatalog = catalog; 
        //    //column.properties["autoincrement"].value = true; //设置自动增长
        //    //table.keys.append("firsttableprimarykey", keytypeenum.adkeyprimary, column, null, null); //定义主键
        //    catalog.tables.append(table);
        //    cn.close();
        //}
        



    }
}
