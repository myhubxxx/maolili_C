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
using 裕景管理系统.Dao;

namespace 裕景管理系统.administrator
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
        private DataSet ds = null;
        private System.Data.OleDb.OleDbDataAdapter da = null;
        private void test_Load(object sender, EventArgs e)
        {
            EmployeeCertificateDao dao = new EmployeeCertificateDao();
            OleDbDataAdapter da = new OleDbDataAdapter();
            this.ds = dao.getDataSetAll_ds();
            da = dao.getDataSetALL_da();
            if (ds == null)
            { dataGridView1.DataSource = null; }
            else
            {
                dataGridView1.DataSource = ds.Tables["员工证书管理表"];
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                //  DataGridViewRow gvr = dataGridView1.Rows[i];
                DateTime date = (DateTime)(dataGridView1.Rows[i].Cells[7].Value);
                DateTime lockDate = (DateTime)(dataGridView1.Rows[i].Cells[13].Value);
                int daySpan = int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());

                //1继续教育（提醒期内） 人员占用
                if (DateTime.Now >= (date.AddDays(-daySpan)) && (DateTime.Now <= date) && lockDate >= DateTime.Now)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }
                //2 继续教育（提醒期内）  人员空闲
                if (DateTime.Now >= (date.AddDays(-daySpan)) && (DateTime.Now <= date) && lockDate < DateTime.Now)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                //3 继续教育过期 人员占用
                if((DateTime.Now > date)&& lockDate >= DateTime.Now)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                }
                //4 继续教育过期 人员空闲
                if((DateTime.Now > date)&& lockDate < DateTime.Now)
                {
                    //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                }
                //5 继续教育（提醒期外） 人员占用
                 if (DateTime.Now < (date.AddDays(-daySpan)) && lockDate >= DateTime.Now)
                 {
                     dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                 }
                //6 继续教育（提醒期外） 人员空闲
                  if (DateTime.Now < (date.AddDays(-daySpan)) && lockDate < DateTime.Now)
                 {
                     //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                 }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null) return;
            EmployeeCertificateDao dao = new EmployeeCertificateDao();
            OleDbDataAdapter da = dao.getDataSetALL_da();
            da.Update(ds, "员工证书管理表");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
