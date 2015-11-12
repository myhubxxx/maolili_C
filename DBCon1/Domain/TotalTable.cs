using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.Domain
{
    class TotalTable
    {

        private int id;
        private string tablename;
        private DateTime createtime = DateTime.Now;

        public DateTime Createtime
        {
            get { return createtime; }
            set { createtime = value; }
        }

        public string getMyDate() {
            return createtime.ToString("d");
        }

        public string Tablename
        {
            get { return tablename; }
            set { tablename = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        



    }
}
