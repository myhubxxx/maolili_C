using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class TestAccessOP
    {
        
        public void test() { 
           
            // test method DeleteAccessTab
            deleteTable();
        
        }
        public void deleteTable() {

            AccessOp.DeleteAccessTab("人事部","he");

        }


    }
}
