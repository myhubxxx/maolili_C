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
using 裕景管理系统.Dao;
using System.Data.OleDb;
namespace 裕景管理系统.manager
{
    public partial class manage_notes : Form
    {
        public manage_notes()
        {
            InitializeComponent();
        }
        private DataSet ds = null;
        private System.Data.OleDb.OleDbDataAdapter da = null;
        private void manage_notes_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
                DoRrealManager drm = new DoRrealManager();
                this.ds = drm.getBRds(ConstatData.login.username);
                OleDbDataAdapter da = new OleDbDataAdapter();
                da = drm.getBRda(ConstatData.login.username);
                dataGridView1.DataSource = ds.Tables["BumRemind"];
            }
            catch(Exception)
            {
                MessageBox.Show (ShareLib.No_Note);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DoRrealManager drm = new DoRrealManager();
            OleDbDataAdapter da = drm.getBRda(ConstatData.login.username);
            da.Update(ds, "BumRemind");
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
