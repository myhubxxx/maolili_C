using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Data.OleDb;


namespace 裕景管理系统.administrator
{
    public partial class dept_query : Form
    {
        public dept_query()
        {
            InitializeComponent();
        }
        private DataSet ds = null;
        private void dept_query_Load(object sender, EventArgs e)
        {     DoManager domanager = new DoManager();
        if (domanager.checkdepartment())
        {
           dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);
           dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
            this.ds = domanager.getalldepart();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da = domanager.getda();
            da.Fill(ds, "department");
            this.dataGridView1.DataSource = ds.Tables["department"];
         
              
           
        }
        }
       
    }
}
