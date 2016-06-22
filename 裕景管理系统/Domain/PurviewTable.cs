using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.Domain
{
    class PurviewTable
    {

        private int id;
        private int dept_userid;
        private string dept_table;
        private int purview;

        public int Purview
        {
            get { return purview; }
            set { purview = value; }
        }

        public string Dept_table
        {
            get { return dept_table; }
            set { dept_table = value; }
        }

        public int Dept_userid
        {
            get { return dept_userid; }
            set { dept_userid = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


    }
}
