using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBCon1.test_dao;
using DBCon1.Dao;
using DBCon1.Domain;
using System.Data.OleDb;
using 裕景管理系统.Dao;

namespace 裕景管理系统.administrator
{
    public partial class paper_manage : Form
    {
        public paper_manage()
        {
            InitializeComponent();
        }
        private DataSet ds = null;
        private System.Data.OleDb.OleDbDataAdapter da = null;
        private void paper_manage_Load(object sender, EventArgs e)
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
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++ )
            {
              //  DataGridViewRow gvr = dataGridView1.Rows[i];
                DateTime date = (DateTime)(dataGridView1.Rows[i].Cells[7].Value);
                DateTime lockDate = (DateTime)(dataGridView1.Rows[i].Cells[7].Value);
                int daySpan = int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());

                // 继续教育提醒
                if ((DateTime.Now > (date.AddDays(-daySpan))) && (DateTime.Now < date))
                { // 在提醒的范围内，应该红色显示
                   dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                  
                    if (DateTime.Now < lockDate)
                    {
                        // 如果该员工继续教育到期 and 也被占用，使用另一种颜色显示

                    }
                }
                else if (DateTime.Now > date)
                {// 已经超过提醒时期

                }
                else if (DateTime.Now < lockDate)
                {
                    // 如果该员工继只是被占用，使用 灰 颜色显示

                }



            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null) return;
            EmployeeCertificateDao dao = new EmployeeCertificateDao();
            OleDbDataAdapter da = dao.getDataSetALL_da();
            da.Update(ds, "员工证书管理表");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
