using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 裕景管理系统.Domain;
using 裕景管理系统.Dao;
using DBCon1.Domain;
using DBCon1.Dao;
using System.Windows.Forms;
using System.Drawing;
using 裕景管理系统.manager;
using System.Data.OleDb;
using System.Data;
namespace 裕景管理系统.staff
{
    public partial class manage_data : Form
    {
        public manage_data()
        {
            InitializeComponent();
        }
        private DataSet ds = null;
        private System.Data.OleDb.OleDbDataAdapter da = null;
        private void manage_data_Load(object sender, EventArgs e)
        {
            dostaff dd=new dostaff ();
            if(dd.checkifcandao_table(ConstatData.department.Dept_name,ConstatData.login.username))
            {

                dostaff dst = new dostaff();
                int dept_userid = dst.getuserid(ConstatData.login.username);
                List<PurviewTable> table = new List<PurviewTable>();
                table = dst.gettables_cando(ConstatData.department.Dept_name, dept_userid);
                Dictionary<string, int> map = new Dictionary<string, int>();
                foreach (PurviewTable temp in table)
                {
                    if (temp.Purview >= 1)
                    {
                        map.Add(temp.Dept_table, temp.Purview);
                        comboBox1.Items.Add(temp.Dept_table);
                    }

                }
            }
        else{
           
                MessageBox.Show("对不起，经理还未为您分配您的可操作表");
              }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConstatData.tbname = comboBox1.Text;

            dataGridView1.RowsDefaultCellStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
            try
            {
                ConstatData.tbname = comboBox1.Text;
                dataGridView1.RowsDefaultCellStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);
                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
                DoRrealManager drm = new DoRrealManager();
                OleDbDataAdapter da = new OleDbDataAdapter();
                this.ds = drm.gettableds(ConstatData.department.Dept_name, ConstatData.tbname);
                da = drm.gettableda(ConstatData.department.Dept_name, ConstatData.tbname);
                dataGridView1.DataSource = ds.Tables[ConstatData.tbname];


            }
            catch (Exception ex)
            {
                MessageBox.Show("该部门还未创建任何数据表");

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
            ConstatData.staff.Show();
            this.Hide();
        }
    }
}
