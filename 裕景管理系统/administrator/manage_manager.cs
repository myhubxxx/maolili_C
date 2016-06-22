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

namespace 裕景管理系统.administrator
{
    public partial class manage_manager : Form
    {
        public manage_manager()
        {
            InitializeComponent();
        }

        private void manage_manager_Load(object sender, EventArgs e)
        {
            DoManager domamnger = new DoManager();
            if (!domamnger.checkmanager_if_none())
            {
                MessageBox.Show("对不起，您还没有添加任何经理");
            }
            else
            {
                dataGridView1.RowsDefaultCellStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);

                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
                DoManager domanager = new DoManager();
                List<Department> dept = domanager.getalldept_list();
                DataGridViewComboBoxColumn cbx = new DataGridViewComboBoxColumn();
                cbx.Name = "部门";
                cbx.DataPropertyName = "DeptID";
                cbx.DataSource = dept;
                cbx.DisplayMember = "Dept_name";
                cbx.ValueMember = "Id";
                this.dataGridView1.Columns.Insert(4, cbx);
                this.dataGridView1.DataSource = this.ToUsers();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result =
                 System.Windows.Forms.MessageBox.Show(
                         "确实要保存修改吗",
                         "确认",
                         MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
              var a = this.dataGridView1.DataSource as List<DisplayEntity>;
               var row = a.UpdateUser();
               //ConstatData.admin.Show();
               //this.Close();
               
            }
            else
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.admin.Show();
            this.Close();
          

        }
    }
}
