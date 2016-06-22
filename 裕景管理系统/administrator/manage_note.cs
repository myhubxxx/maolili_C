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
using 裕景管理系统.Domain;

namespace 裕景管理系统.administrator
{
    public partial class manage_note : Form
    {
        public manage_note()
        {
            InitializeComponent();
        }
        private DataSet ds = null;
        private System.Data.OleDb.OleDbDataAdapter da = null;
        private void manage_note_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.RowsDefaultCellStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
                DoManager domanager = new DoManager();
                this.ds = domanager.getBRds(ConstatData.login.username);
                OleDbDataAdapter da = new OleDbDataAdapter();
                da = domanager.getBRda(ConstatData.login.username);
                dataGridView1.DataSource = ds.Tables["BumRemind"];
            }
            catch (Exception ex)
            {

                MessageBox.Show("您还没有添加备忘录");

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoManager domanager = new DoManager();
            OleDbDataAdapter da =domanager.getBRda(ConstatData.login.username);
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
