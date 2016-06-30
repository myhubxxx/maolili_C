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
                MessageBox.Show(ShareLib.No_StaffInfo);
            }
            else
            {
                dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);
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
        {System.Windows.Forms.DialogResult result =
                 System.Windows.Forms.MessageBox.Show(
                         ShareLib.Confirm_Modify_Manger,
                         ShareLib.Make_Sure,
                         MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Question);
        if (result == System.Windows.Forms.DialogResult.OK)
        {
            DoManager domanger = new DoManager();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = domanger.getinfo_da();
            da.Update(ds, "userinfo");
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
    }
}
