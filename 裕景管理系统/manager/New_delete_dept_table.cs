using DBCon1.Domain;
using DBCon1.test_dao;
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

namespace 裕景管理系统.manager
{
    public partial class New_delete_dept_table : Form
    {
        public New_delete_dept_table()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.CheckBoxes = true;
            DoRrealManager drm = new DoRrealManager();
            List<TotalTable> list = new List<TotalTable>();
            list = drm.gettables_list(ConstatData.department.Dept_name);
            if (list == null || list.Count() == 0)
            { listView1.Items.Add(""); }
            for (int i = 0; i < list.Count(); i++)
            {
                TotalTable bean = list[i];
                string[] param = { bean.Id.ToString(), bean.Tablename };
                ListViewItem item1 = new ListViewItem(param);
                listView1.Items.AddRange(new ListViewItem[] { item1 });

            }
            listView1.GridLines = true;
            listView1.ForeColor = Color.BurlyWood;
            listView1.Font = new Font(ShareLib.Font_Type, 13);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("请选择数据表格");
            }
            else
            {
                  System.Windows.Forms.DialogResult result =
              System.Windows.Forms.MessageBox.Show(
                      ShareLib.Comfirm_Delete_Table,
                      ShareLib.Make_Sure,
                      MessageBoxButtons.OKCancel,
                      MessageBoxIcon.Question);
                  if (result == System.Windows.Forms.DialogResult.OK)
                  {
                      foreach (ListViewItem it in listView1.CheckedItems)
                      {
                          AccessOp.DeleteAccessTab(ConstatData.department.Dept_name, it.SubItems[1].Text);
                      }
                  }
            }
            MessageBox.Show(ShareLib.Delete_Table_Success);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Checked = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
