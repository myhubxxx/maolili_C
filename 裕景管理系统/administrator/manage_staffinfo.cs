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

namespace 裕景管理系统.administrator
{
    public partial class manage_staffinfo : Form
    {
        public manage_staffinfo()
        {
            InitializeComponent();
        }
        private DataSet ds = null;
        private System.Data.OleDb.OleDbDataAdapter da = null;

        private void manage_staffinfo_Load(object sender, EventArgs e)
        {
            DoManager dnmanager = new DoManager();
            if (!dnmanager.checkuserinfo_if_none())
            {
                MessageBox.Show("对不起，员工信息尚无");
            }
            else
            {

                dataGridView1.RowsDefaultCellStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
                DoManager domanger = new DoManager();
                this.ds = domanger.getinfo_ds();
                OleDbDataAdapter da = new OleDbDataAdapter();
                da = domanger.getinfo_da();
                dataGridView1.DataSource = ds.Tables["userinfo"];
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.admin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoManager domanger = new DoManager();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = domanger.getinfo_da();
            da.Update(ds,"userinfo");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
            }
        }
    }
}
