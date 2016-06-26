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
                MessageBox.Show(ShareLib.No_Manager);
            }
            else
            {
                dataGridView1.RowsDefaultCellStyle.Font = new Font(ShareLib.Font_Type, 10, FontStyle.Bold);

                dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
                DoManager domanager = new DoManager();
                List<Department> dept = domanager.getalldept_list();
                DataGridViewComboBoxColumn cbx = new DataGridViewComboBoxColumn();
                cbx.Name = ShareLib.CMB_name;
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
                         ShareLib.Confirm_Modify_Manger,
                         ShareLib.Make_Sure,
                         MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
              var a = this.dataGridView1.DataSource as List<DisplayEntity>;
               var row = a.UpdateUser();
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
