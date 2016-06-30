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
using 裕景管理系统.administrator;
namespace 裕景管理系统.manager
{
    public partial class datainfo_manage : Form
    {
        public datainfo_manage()
        {
            InitializeComponent();
        }
        private DataSet ds = null;
        private System.Data.OleDb.OleDbDataAdapter da = null;

        public string M_ck_tbname
        {

            get { return label3.Text; }
        }
        private void datainfo_manage_Load(object sender, EventArgs e)
        {
            ConstatData.dataInfo_Manage = this;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime t1 = DateTime.Parse(dateTimePicker1.Text);
            DateTime t2 = DateTime.Parse(dateTimePicker2.Text);
            dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
            TotalTableDao ttDao = new TotalTableDao();
            this.ds = ttDao.getByDateDS(ConstatData.department.Dept_name,t1,t2 );
            this.dataGridView1.DataSource = ds.Tables[ConstatData.department.Dept_name];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                return;
            }
            System.Windows.Forms.DialogResult result =
                 System.Windows.Forms.MessageBox.Show(
                         ShareLib.Confirm_Modify_Manger,
                         ShareLib.Make_Sure,
                         MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                DoRrealManager drm = new DoRrealManager();
                OleDbDataAdapter da = drm.gettableda(ConstatData.department.Dept_name, ConstatData.tbname);
                da.Update(ds, ConstatData.tbname);
                MessageBox.Show(ShareLib.Modify_Success);
            }
            else
            {
                return;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ConstatData.manager.Show();
            this.Close();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ConstatData.tbname = textBox1.Text;
            dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
            try
            {
                dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
                TotalTableDao ttDao = new TotalTableDao();
                this.ds = ttDao.darkSearchByTableName(ConstatData.department.Dept_name, textBox1.Text);
                this.dataGridView1.DataSource = ds.Tables[ConstatData.department.Dept_name];
            }
            catch (Exception)
            {
                MessageBox.Show(ShareLib.Dept_No_Table);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "") { return; }
            M_show_table_information msi = new M_show_table_information();
            msi.Show();
        }
    }
}
