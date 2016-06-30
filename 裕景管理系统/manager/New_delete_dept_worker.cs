using DBCon1.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 裕景管理系统.manager
{
    public partial class New_delete_dept_worker : Form
    {
        public New_delete_dept_worker()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.CheckBoxes = true;
            int level = 0;
            DoRrealManager drm = new DoRrealManager();
            List<UserInfo> list = drm.getallworkername(level);
            if (list == null || list.Count() == 0)
            {
                listView1.Items.Add("");
            }
            else
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    UserInfo bean = list[i];
                    string[] param = { bean.Id.ToString(), bean.Name };
                    ListViewItem item1 = new ListViewItem(param);
                    listView1.Items.AddRange(new ListViewItem[] { item1 });
                }
            }
            listView1.GridLines = true;
            listView1.ForeColor = Color.BurlyWood;
            listView1.Font = new Font(ShareLib.Font_Type, 13);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("请选择要删除的员工");
            }
            else
            {
                  System.Windows.Forms.DialogResult result =
                    System.Windows.Forms.MessageBox.Show(
                         ShareLib.Comfirm_Delete_Staff,
                            ShareLib.Make_Sure,
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question);
                  if (result == System.Windows.Forms.DialogResult.OK)
                  {
                      DoRrealManager drm = new DoRrealManager();
                      foreach (ListViewItem item in listView1.CheckedItems)
                      {
                          drm.delete_worker(item.SubItems[1].Text);
                      }
                      MessageBox.Show(ShareLib.Staff_Delete_Success);
                  }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
