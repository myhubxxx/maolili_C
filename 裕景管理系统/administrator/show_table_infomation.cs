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
    public partial class show_table_infomation : Form
    {
        public show_table_infomation()
        {
            InitializeComponent();
        }
        private DataSet ds = null;
        private System.Data.OleDb.OleDbDataAdapter da = null;
        private void show_table_infomation_Load(object sender, EventArgs e)
        {
            label1.Text = ConstatData.tab_query.ck_name;
            label1.Font = new Font(ShareLib.Font_Type, 12, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
            try
            {
                DoManager domanager = new DoManager();
                OleDbDataAdapter da = new OleDbDataAdapter();
                this.ds = domanager.gettableds(ConstatData.tab_query.DEPART_NAME,ConstatData.tab_query.ck_name);
                da = domanager.gettableda(ConstatData.tab_query.DEPART_NAME, ConstatData.tab_query.ck_name);
                dataGridView1.DataSource = ds.Tables[ConstatData.tab_query.ck_name];
            }
            catch (Exception)
            {
                MessageBox.Show(ShareLib.Dept_No_Table);
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoManager domanager = new DoManager();
            OleDbDataAdapter da = domanager.gettableda(ConstatData.tab_query.DEPART_NAME, ConstatData.tab_query.ck_name);
            da.Update(this.ds, ConstatData.tab_query.ck_name);
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
