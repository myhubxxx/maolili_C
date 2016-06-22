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
using 裕景管理系统.administrator;
using 裕景管理系统.Domain;
namespace 裕景管理系统.manager
{
    public partial class add_level : Form
    {
        public add_level()
        {
            InitializeComponent();
        }

        private void add_level_Load(object sender, EventArgs e)
        {
             DoRrealManager drm = new DoRrealManager();
            try
            {
                int level = 0;
           
                List<UserInfo> list = drm.getallworkername(level);
                comboBox1.DataSource = list.Select(a => a.Name).ToList();


            }
            catch
            {

                MessageBox.Show("对不起，尚存在未填写详细信息的员工，请员工登录个人界面，填写个人详细信息");


            }

            List<TotalTable> tablelist = new List<TotalTable>();
            tablelist = drm.gettables_list(ConstatData.department.Dept_name);
            comboBox2.DataSource = tablelist.Select(a => a.Tablename).ToList();
          
            comboBox3.Text = "不可见";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PurviewTable table = new PurviewTable();
           DoRrealManager drm=new DoRrealManager ();
           table.Dept_userid = drm.gettable_dept_userid(comboBox1.SelectedItem.ToString());
            table.Dept_table = comboBox2.SelectedItem.ToString();
           
            if (comboBox3.SelectedItem.ToString() == "可见")
            {
                table.Purview = 1;
                drm.addlevel(ConstatData.department.Dept_name, table);
                MessageBox.Show("权限分配成功");
            }
            if (comboBox3.SelectedItem.ToString() == "不可见")
            {
                table.Purview = 0;
                drm.addlevel(ConstatData.department.Dept_name, table);
                MessageBox.Show("权限分配成功");
            }
            if (comboBox3.SelectedItem.ToString() == "可见可写")
            {
                table.Purview = 2;
                drm.addlevel(ConstatData.department.Dept_name, table);
                MessageBox.Show("权限分配成功");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                DoRrealManager drm = new DoRrealManager();
                List<TotalTable> tablelist = new List<TotalTable>();
                tablelist = drm.gettables_list(ConstatData.department.Dept_name);
          
        }
    }
}
