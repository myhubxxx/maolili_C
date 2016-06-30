using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 裕景管理系统.Domain
{
    class EmployeeCertificate
    {
        private int id;
        private string uname;

        private string gwz_catory;
        private string gwz_major;
        private string gwz_level;
        private string gwz_remark;

        private DateTime lz_date;
        private DateTime continue_edu;

        private int pre_day;

        private string zc_major;        
        private string zc_level;

        private string remark;

        private string tb_project;
        private DateTime tb_lock_time;
        
        private string ssn;

        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Uname
        {
            get { return uname; }
            set { uname = value; }
        }
        public string Gwz_catory
        {
            get { return gwz_catory; }
            set { gwz_catory = value; }
        }
        public string Gwz_major
        {
            get { return gwz_major; }
            set { gwz_major = value; }
        }
        public string Gwz_level
        {
            get { return gwz_level; }
            set { gwz_level = value; }
        }
        public string Gwz_remark
        {
            get { return gwz_remark; }
            set { gwz_remark = value; }
        }
        public DateTime Lz_date
        {
            get { return lz_date; }
            set { lz_date = value; }
        }
        public DateTime Continue_edu
        {
            get { return continue_edu; }
            set { continue_edu = value; }
        }
        public int Pre_day
        {
            get { return pre_day; }
            set { pre_day = value; }
        }
        public string Zc_major
        {
            get { return zc_major; }
            set { zc_major = value; }
        }
        public string Zc_level
        {
            get { return zc_level; }
            set { zc_level = value; }
        }
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
        public string Tb_project
        {
            get { return tb_project; }
            set { tb_project = value; }
        }
        public DateTime Tb_lock_time
        {
            get { return tb_lock_time; }
            set { tb_lock_time = value; }
        }
        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }
    }
}
