using DBCon1.Dao;
using DBCon1.Domain;
using DBCon1.test_dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1
{
    class TestTotalTableDao
    {
        TotalTableDao dao = new TotalTableDao();
        public void test() {
          //  Console.WriteLine( DateTime.Now.ToString("d"));
           // Console.Read();
            //add();
            //addTable();
            search();
            

        }
        public void search() {
            DateTime sta = DateTime.Parse("2015-11-10"); 
            DateTime end = DateTime.Parse("2015-11-13");

            List<TotalTable> list = dao.getByDate("西瓜部门",sta, end);
            int i =0 ;
            while (list.Count > i) {
                Console.WriteLine(list[i].Tablename + " : " + list[i].getMyDate());
                i++;
            }
            Console.Read();


        }
        public void addTable() {
            MyDatabase table = new MyDatabase();
            table.DBName = "西瓜部门";
            table.TableName = "创建一个表";
            DBTableField co = new DBTableField();
            co.FieldName = "字段1";
            co.Type = "varchar(20)";
            table.Columns.Add(co);

            AccessOp.CreateAccessTab(table);
        
        
        }
        public void add() {
            TotalTable table = new TotalTable();
            table.Tablename = "我是一张表sss";
            Console.WriteLine(table.getMyDate());
            Console.Read();
            dao.add("西瓜部门", table);
        }
       




    }
}
