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

namespace 裕景管理系统.top_Manager
{
    public partial class TM_search_staffinfomation : Form
    {
        public TM_search_staffinfomation()
        {
            InitializeComponent();
        }  private DataSet ds = null;

        private void TM_search_staffinfomation_Load(object sender, EventArgs e)
        {
             DoManager domanager = new DoManager();
             if (domanager.checkdepartment())
             {
                 //  dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);
                 // dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
                 this.ds = domanager.getalldepart();
                 OleDbDataAdapter da = new OleDbDataAdapter();
                 da = domanager.getda();
                 da.Fill(ds, "department");
                 this.dataGridView1.DataSource = ds.Tables["department"];
                 for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                 {
                     if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) > 10)
                     {
                         dataGridView1.Rows[i].DefaultCellStyle.BackColor= Color.Red;


                     }

                 }
             }
              
        }
    }
}
