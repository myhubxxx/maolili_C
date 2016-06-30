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
    public partial class M_show_table_information : Form
    {
        public M_show_table_information()
        {
            InitializeComponent();
        }
        private DataSet ds = null;
        private System.Data.OleDb.OleDbDataAdapter da = null;
        private void M_show_table_information_Load(object sender, EventArgs e)
        {
            label1.Text = ConstatData.dataInfo_Manage.M_ck_tbname;
            label1.Font = new Font(ShareLib.Font_Type, 12, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
            try
            {
                DoManager domanager = new DoManager();
                OleDbDataAdapter da = new OleDbDataAdapter();
                this.ds = domanager.gettableds(ConstatData.department.Dept_name, ConstatData.dataInfo_Manage.M_ck_tbname);
                da = domanager.gettableda(ConstatData.department.Dept_name, ConstatData.dataInfo_Manage.M_ck_tbname);
                dataGridView1.DataSource = ds.Tables[ConstatData.dataInfo_Manage.M_ck_tbname];
            }
            catch (Exception)
            {
                MessageBox.Show(ShareLib.Dept_No_Table);
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null) { return; }
            DoManager domanager = new DoManager();
            OleDbDataAdapter da = domanager.gettableda(ConstatData.department.Dept_name, ConstatData.dataInfo_Manage.M_ck_tbname);
            da.Update(this.ds, ConstatData.dataInfo_Manage.M_ck_tbname);
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
