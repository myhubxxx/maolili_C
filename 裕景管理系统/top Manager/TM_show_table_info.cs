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

namespace 裕景管理系统.top_Manager
{
    public partial class TM_show_table_info : Form
    {
        public TM_show_table_info()
        {
            InitializeComponent();
        }
  private DataSet ds = null;
        private System.Data.OleDb.OleDbDataAdapter da = null;
        private void TM_show_table_info_Load(object sender, EventArgs e)
        {
            label1.Text = ConstatData.TM_TB.TM_tbname;
            label1.Font = new Font(ShareLib.Font_Type, 12, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
            try
            {
                DoManager domanager = new DoManager();
                OleDbDataAdapter da = new OleDbDataAdapter();
                this.ds = domanager.gettableds(ConstatData.TM_TB.TM_deptname, ConstatData.TM_TB.TM_tbname);
                da = domanager.gettableda(ConstatData.TM_TB.TM_deptname, ConstatData.TM_TB.TM_tbname);
                dataGridView1.DataSource = ds.Tables[ConstatData.TM_TB.TM_tbname];
            }
            catch (Exception)
            {
                MessageBox.Show(ShareLib.Dept_No_Table);
            }
          
        }
    }
}
