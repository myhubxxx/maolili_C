using DBCon1.Dao;
using DBCon1.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class Test_PurviewTableDao
    {
        PurviewTableDao dao = new PurviewTableDao();

        public void test() {
           // add();
           // update();
           //   load();  
          //  findallList();
           // findDataSet();
            //loadByUserid();
            //loadbytable();
            
        }
        public void loadbytable() {
            List<PurviewTable> list = dao.loadByTable("人事部","新表");
            foreach (PurviewTable bean in list)
            {
                Console.WriteLine(bean.Id + " " + bean.Dept_userid + " " + bean.Dept_table + " " + bean.Purview);
            }
            Console.Read();
        
        }
        public void loadByUserid() {
            List<PurviewTable> list = dao.loadByUserid("人事部",9);
            foreach (PurviewTable bean in list)
            {
                Console.WriteLine(bean.Id + " " + bean.Dept_userid + " " + bean.Dept_table + " " + bean.Purview);
            }
            Console.Read();

        }
        public void findDataSet() {
            DataSet ds = dao.findAll_DataSet("人事部");
            DataTableReader reader = ds.CreateDataReader();
            while (reader.Read()) {
                Console.WriteLine(reader.GetInt32(0)+" "+reader.GetInt32(1)+" "+
                    reader.GetString(2)+" "+reader.GetInt32(3));
            }
            Console.Read();

        }
        public void findallList() {
            List<PurviewTable> list = dao.findAll_List("人事部");
            foreach (PurviewTable bean in list) {
                Console.WriteLine(bean.Id + " " + bean.Dept_userid + " " + bean.Dept_table + " " + bean.Purview);
            }
            Console.Read();
        }
        public void load(){
            PurviewTable bean = dao.load("人事部",6);
            Console.Write(bean.Id + " " +bean.Dept_userid+" " +bean.Dept_table+" "+bean.Purview);
            Console.Read();
        
        }
        public void update() {
            PurviewTable bean = new PurviewTable();
            bean.Id = 1;

            bean.Dept_userid = 8;
            bean.Dept_table = "新表";
            bean.Purview = 1;

            dao.update("人事部",bean);
        }

        public void add() {
            PurviewTable bean = new PurviewTable();
            bean.Dept_userid = 9;
            bean.Dept_table = "资源表";
            bean.Purview = 1;

            dao.add("人事部", bean);
        }
    }
}
