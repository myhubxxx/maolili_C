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
    public partial class manage_staff : Form
    {
        public manage_staff()
        {
            InitializeComponent();
        }

        private void manage_staff_Load(object sender, EventArgs e)
        {
            DoManager dopmanger = new DoManager();
            if (!dopmanger.checkmanager_if_none())
            {
                MessageBox.Show("对不起，当前还未分配员工账号");
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
                this.dataGridView1.DataSource = this.touser();
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
            
                 var a = this.dataGridView1.DataSource as List<showinfo >;
                var row = a.updateuser();
                
             

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

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
            }
        }
    }
}
