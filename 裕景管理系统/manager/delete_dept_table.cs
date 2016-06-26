using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 裕景管理系统.manager;
using 裕景管理系统.Domain;
using DBCon1.Domain;
using DBCon1.Dao;
using DBCon1.test_dao;

namespace 裕景管理系统.manager
{
    public partial class delete_dept_table : Form
    {
        public delete_dept_table()
        {
            InitializeComponent();
        }

        private void delete_dept_table_Load(object sender, EventArgs e)
        {
            try
            {
                DoRrealManager drm = new DoRrealManager();
                List<TotalTable> list = new List<TotalTable>();
                list = drm.gettables_list(ConstatData.department.Dept_name);

                comboBox1.DataSource = list.Select(a => a.Tablename).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ShareLib.Dept_No_Table);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result =
              System.Windows.Forms.MessageBox.Show(
                      ShareLib.Comfirm_Delete_Table,
                      ShareLib.Make_Sure,
                      MessageBoxButtons.OKCancel,
                      MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                
                
                AccessOp.DeleteAccessTab(ConstatData.department.Dept_name, comboBox1.SelectedItem.ToString());
                MessageBox.Show(ShareLib.Delete_Table_Success);
                DoRrealManager drm = new DoRrealManager();
                List<TotalTable> list = new List<TotalTable>();
                list = drm.gettables_list(ConstatData.department.Dept_name);
                if (list == null || list.Count() == 0)
                {
                    comboBox1.DataSource = null;
                }
                else
                {
                    comboBox1.DataSource = list.Select(a => a.Tablename).ToList();
                }
            }
        }
    }
}
