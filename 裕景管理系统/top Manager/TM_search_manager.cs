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
using 裕景管理系统.administrator;
namespace 裕景管理系统.top_Manager
{
    public partial class TM_search_manager : Form
    {
        public TM_search_manager()
        {
            InitializeComponent();
        }

        private void TM_search_manager_Load(object sender, EventArgs e)
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
    }
}
