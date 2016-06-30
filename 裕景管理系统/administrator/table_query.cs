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
        public  string DEPART_NAME
        {
            get { return comboBox1.Text; }

        }
        public string ck_name
        {

            get
            {
                return label3.Text;
            }
        }
      
        private DataSet ds = null;
        private void table_query_Load(object sender, EventArgs e)
        {
            ConstatData.tab_query = this;
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          // this event can't delete
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         label3.Text =dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
         show_table_infomation sh = new show_table_infomation();
            sh.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
            DoManager domanager = new DoManager();
            this.ds = domanager.darkSearchByTableName(comboBox1.Text, textBox1.Text);
            //OleDbDataAdapter da = new OleDbDataAdapter();
            //da = domanager.gettotaltable_da(comboBox1.Text);
            //da.Fill(ds, comboBox1.Text);
            this.dataGridView1.DataSource = ds.Tables[comboBox1.Text];
        }
    }
}
