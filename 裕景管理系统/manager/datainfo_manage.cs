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
    public partial class datainfo_manage : Form
    {
        public datainfo_manage()
        {
            InitializeComponent();
        }
        private DataSet ds = null;
        private System.Data.OleDb.OleDbDataAdapter da = null;

        private void datainfo_manage_Load(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConstatData.tbname = comboBox1.Text;
           
            dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
            try
            {
                ConstatData.tbname = comboBox1.Text;
                DoRrealManager drm = new DoRrealManager();
                OleDbDataAdapter da = new OleDbDataAdapter();
                this.ds = drm.gettableds(ConstatData.department.Dept_name, ConstatData.tbname);
                da = drm.gettableda(ConstatData.department.Dept_name, ConstatData.tbname);
                dataGridView1.DataSource = ds.Tables[ConstatData.tbname];
            }
            catch (Exception)
            {
                MessageBox.Show(ShareLib.Dept_No_Table);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DoRrealManager drm = new DoRrealManager();
            OleDbDataAdapter da = drm.gettableda(ConstatData.department.Dept_name, ConstatData.tbname);
            da.Update(ds, ConstatData.tbname);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ConstatData.manager.Show();
            this.Close();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            List<TotalTable> list = new List<TotalTable>();
            DoRrealManager drm = new DoRrealManager();
            DateTime t1 = DateTime.Parse(dateTimePicker1.Text);
            DateTime t2 = DateTime.Parse(dateTimePicker2.Text);
            list = drm.gettables_list(ConstatData.department.Dept_name, t1, t2);
            comboBox1.DataSource = list.Select(a => a.Tablename).ToList();
        }
    }
}
