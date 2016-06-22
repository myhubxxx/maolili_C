using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.Domain
{
    public class Department
    {
        private int id;
        private string dept_name;

        public string Dept_name
        {
            get { return dept_name; }
            set { dept_name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


    }
}
