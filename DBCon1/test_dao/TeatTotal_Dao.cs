using DBCon1.Dao;
using DBCon1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class TeatTotal_Dao
    {
        TotalTableDao dao = new TotalTableDao();

        public void test() {
          //  add();
          //  update();
          //  load();
          //  loadByName();  
          
           // findAll();
            delete();
        }
        public void delete(){
            dao.delete("人事部",1);
        
        }
        public void findAll(){
            List<TotalTable> list = dao.findAll("人事部");
            foreach (TotalTable bean in list) {
                Console.WriteLine(bean.Id + " " + bean.Tablename);
            }
            Console.Read();    

        }
        public void loadByName() {
            TotalTable bean = dao.loadByName("人事部","请假表");
            Console.WriteLine(bean.Id + " " + bean.Tablename);
            Console.Read();
        }
        public void load() {
            TotalTable bean = dao.load("人事部",1);
            Console.WriteLine(bean.Id + " " + bean.Tablename);
            Console.Read();
        }
        public void update() {
            TotalTable bean = new TotalTable();
            bean.Id = 2;
            bean.Tablename = "财务表";
            dao.update("人事部",bean);
        }
        public void add() {
            TotalTable bean = new TotalTable();
            bean.Tablename = "人员表";

            dao.add("人事部", bean);

        }

    }
}
