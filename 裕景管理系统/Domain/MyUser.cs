using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.Domain
{
    class MyUser
    {
        private int id;
        private string uname;
        private string upass;
        private int userlevel;


        private int dept_id;

        public string Uname
        {
            get { return uname; }
            set { uname = value; }
        }
        
        public string Upass
        {
            get { return upass; }
            set { upass = value; }
        }

        public int Userlevel
        {
            get { return userlevel; }
            set { userlevel = value; }
        }
        
        public int Dept_id
        {
            get { return dept_id; }
            set { dept_id = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


    }
}
