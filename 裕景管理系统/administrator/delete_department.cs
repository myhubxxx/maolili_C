using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 裕景管理系统.Domain;
using DBCon1.test_dao;
using DBCon1.Dao;
using DBCon1.Domain;

namespace 裕景管理系统.administrator
{
    public partial class delete_department : Form
    {
        public delete_department()
        {
            InitializeComponent();
        }
        public string dele_dept_name
        {
           get {return comboBox1.Text;}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkuser ck = new checkuser();
            this.Hide();
            ck.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.login.Show();
            this.Close();
        }
        private void delete_department_Load(object sender, EventArgs e)
        {
            ConstatData.dele_dept = this;
            DoManager domanager = new DoManager();
            List<Department> list = new List<Department>();
            list = domanager.getalldept_list();
            if (list == null || list.Count == 0)
            {
                comboBox1.DataSource = null;
            }
            else
            comboBox1.DataSource = list.Select(a => a.Dept_name).ToList();
        }
    }
}
