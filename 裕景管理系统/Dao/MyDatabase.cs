using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class MyDatabase
    {
//===START================
        //private string dbName;
        //private string tableName;
        //private Dictionary<string, string> columns;

        //public string DbName
        //{
        //    get { return dbName; }
        //    set { dbName = value; }
        //}
        
        //public string TableName
        //{
        //    get { return tableName; }
        //    set { tableName = value; }
        //}
        
        //public Dictionary<string, string> Columns
        //{
        //    get { return columns; }
        //    set { columns = value; }
        //}
//===END=========================

        public MyDatabase()
        {
            Columns = new List<DBTableField>();
        }
        private string tableName;

        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        public List<DBTableField> Columns { get; set; }
        public string DBName { get; set; }

    }

    public class DBTableField
    {
        public int Key { get; set; }
        public string FieldName { get; set; }
        public string Type { get; set; }
    }
}
