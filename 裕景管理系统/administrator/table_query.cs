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
using System.Data.OleDb;

namespace 裕景管理系统.administrator
{
    public partial class table_query : Form
    {
        public table_query()
        {
            InitializeComponent();
        }
        private DataSet ds = null;
        private void table_query_Load(object sender, EventArgs e)
        {
            DoManager domanager = new DoManager();
            List<Department> dept = domanager.getalldept_list();
            comboBox1.DataSource = dept.Select(a => a.Dept_name).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
            DoManager domanager = new DoManager();
            this.ds = domanager.gettotaltable_ds(comboBox1.Text);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = domanager.gettotaltable_da(comboBox1.Text);
            da.Fill(ds, comboBox1.Text);
            this.dataGridView1.DataSource = ds.Tables[comboBox1.Text];

        }
    }
}
