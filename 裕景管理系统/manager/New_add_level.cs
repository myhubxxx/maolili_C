using DBCon1.Dao;
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
using 裕景管理系统.Domain;

namespace 裕景管理系统.manager
{
    public partial class New_add_level : Form
    {
      
        public New_add_level()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.CheckBoxes = true;
            DoRrealManager drm = new DoRrealManager();
            int level = 0;
            List<UserInfo> list = drm.getallworkername(level);
            
            for (int i=0; i < list.Count() ;i++ )
            {
                UserInfo bean = list[i];
                string[] param = { bean.Id.ToString(), bean.Name};
                ListViewItem item1 = new ListViewItem(param);
                listView1.Items.AddRange(new ListViewItem[] { item1 });
            }
            listView1.GridLines = true;
            listView1.ForeColor = Color.BurlyWood;
            listView1.Font = new Font(ShareLib.Font_Type, 13);
            listView2.View = View.Details;
            listView2.CheckBoxes = true;
            listView2.ForeColor = Color.BurlyWood;
            listView2.Font = new Font(ShareLib.Font_Type, 13);
            listView2.GridLines = true;
            List<TotalTable> tablelist = new List<TotalTable>();
            tablelist = drm.gettables_list(ConstatData.department.Dept_name);
            for(int j=0;j<tablelist.Count();j++)
            {
                TotalTable bean=tablelist[j];
                string[] param2 = { bean.Tablename };
                ListViewItem item2 = new ListViewItem(param2);
                listView2.Items.AddRange(new ListViewItem[] { item2 });
            }
       
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                foreach (ListViewItem item in listView2.Items)
                {
                    item.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem item in listView2.Items)
                {
                    item.Checked = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(listView1.CheckedItems.Count==0 || listView2.CheckedItems.Count==0)
            { MessageBox.Show("请选择员工和数据表");
                return;
            }
                foreach (ListViewItem it in listView1.CheckedItems)
                {
                    foreach (ListViewItem item in listView2.CheckedItems)
                    {
                        DoRrealManager drm = new DoRrealManager();
                        PurviewTable table = drm.if_has_allocated(ConstatData.department.Dept_name, int.Parse(it.SubItems[0].Text), item.SubItems[0].Text);
                        PurviewTable bean = new PurviewTable();
                        // bean.Dept_userid = drm.gettable_dept_userid(it.SubItems[1].Text);
                        bean.Dept_userid = int.Parse(it.SubItems[0].Text);
                        bean.Dept_table = item.SubItems[0].Text;

                        PurviewTableDao dao = new PurviewTableDao();

                        int purview = 0;
                        if (radioButton1.Checked) purview = 0;
                        if (radioButton2.Checked) purview = 1;
                        if (radioButton3.Checked) purview = 2;

                        //如果已经插入过就修改，不再插入，如果没插入过就直接插入
                        if (null != table)
                        {   // mean exists the purview of the table user,now if the purview'value is same as Form.value,then do nothing,not Same Form, then update
                            if (purview != table.Purview)
                            {
                                dao.update(ConstatData.department.Dept_name, table);
                            }
                        }
                        else
                        {
                            table = bean;
                            table.Purview = purview;
                            drm.addlevel(ConstatData.department.Dept_name, table);
                        }
                    }
                }

                MessageBox.Show("权限分配成功");
             }
            
          
        
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
    }
}
