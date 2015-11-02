using DBCon1.Dao;
using DBCon1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class DepartmentDaoTest
    {
        DepartmentDao dao = new DepartmentDao();



        public void test() { 
          //  test_add();
         //   update();
           // load();
           // findAll();
            delete();


        }
        public void delete() {

            dao.delete(3);
        
        }

        public void findAll(){
            List<Department> list = dao.findAll();
            foreach(Department bean in list){
                Console.WriteLine("{0} {1}",bean.Id,bean.Dept_name);
            }
            Console.Read();
        }

        public void load() {
            Department bean = dao.load(2);
            Console.WriteLine("{0} {1}",bean.Id,bean.Dept_name);
            Console.Read();
        }

        public void update() {
            Department bean = new Department();
            bean.Id = 3;
            bean.Dept_name = "机械部";
            dao.update(bean);
        }

        // add test
        public void test_add() {
            Department bean = new Department();
            bean.Dept_name = "财务部";
            dao.add(bean);
        }




    }
}
