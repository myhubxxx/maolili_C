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
using 裕景管理系统.manager;

namespace 裕景管理系统.administrator
{
    public partial class New_delete_manager : Form
    {
        public New_delete_manager()
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

        private void New_delete_manager_Load(object sender, EventArgs e)
        {

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
        { DoManager domanger = new DoManager();
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("请选择经理");
            }
            foreach (ListViewItem it in listView1.CheckedItems)
            {
               
                domanger.delete_woker(it.SubItems[1].Text);
               
            }
            MessageBox.Show(ShareLib.Mnager_Delete_Success);
        }
    }
}
