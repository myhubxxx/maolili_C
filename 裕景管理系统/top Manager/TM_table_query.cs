using DBCon1.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 裕景管理系统.administrator;
using 裕景管理系统.Domain;
using DBCon1.test_dao;
using DBCon1.Dao;
namespace 裕景管理系统.top_Manager
{
    public partial class TM_table_query : Form
    {
        public TM_table_query()
        {
            InitializeComponent();
        }
        public string TM_deptname
        {
            get { return comboBox1.Text; }

        }
        public string TM_tbname
        {

            get
            {
                return label3.Text;
            }
        }
        private DataSet ds = null;
        private void TM_table_query_Load(object sender, EventArgs e)
        {
            ConstatData.TM_TB = this;
            DoManager domanager = new DoManager();
            List<Department> dept = domanager.getalldept_list();
            comboBox1.DataSource = dept.Select(a => a.Dept_name).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
            DoManager domanager = new DoManager();
            this.ds = domanager.gettotaltable_ds(comboBox1.Text);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = domanager.gettotaltable_da(comboBox1.Text);
            da.Fill(ds, comboBox1.Text);
            this.dataGridView1.DataSource = ds.Tables[comboBox1.Text];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TM_show_table_info tm = new TM_show_table_info();
            tm.Show();
        }
    }
}
