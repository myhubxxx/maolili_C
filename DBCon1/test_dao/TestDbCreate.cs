using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class TestDbCreate
    {
        public void test() {

            createDb();
        }
        public void create(){
            
        
        }


        public void createDb() {
            AccessOp.CreateAccessDb("人事部");
        }

    }
}
