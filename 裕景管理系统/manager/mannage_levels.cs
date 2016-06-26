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
using 裕景管理系统.staff; 
namespace 裕景管理系统.manager
{
    public partial class mannage_levels : Form
    {
        public mannage_levels()
        {
            InitializeComponent();
        }
        private void mannage_levels_Load(object sender, EventArgs e)
        {
            try
            {
                int level = 0;
                DoRrealManager drm = new DoRrealManager();
                List<UserInfo> list = drm.getallworkername(level);
                comboBox1.DataSource = list.Select(a => a.Name).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("对不起，尚存在未填写详细信息的员工，请员工登录个人界面，填写个人详细信息");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoRrealManager drm = new DoRrealManager();
            if (drm.check_worker_cando(comboBox1.SelectedItem.ToString(), ConstatData.department.Dept_name))
            {
                List<PurviewTable> list = new List<PurviewTable>();
                list = drm.getpuriviewtables_list(comboBox1.SelectedItem.ToString(), ConstatData.department.Dept_name);
                comboBox2.DataSource = list.Select(a => a.Dept_table).ToList();
            }
            else
            {
                MessageBox.Show(ShareLib.Staff_NoLevel_Table);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
               PurviewTable table = new PurviewTable();
              DoRrealManager drm = new DoRrealManager();
              table.Dept_userid = drm.gettable_dept_userid(comboBox1.SelectedItem.ToString());
              table.Dept_table = comboBox2.SelectedItem.ToString();
              table.Id = drm.getPVT_id(ConstatData.department.Dept_name, comboBox2.SelectedItem.ToString());
              table.Purview = int.Parse(textBox1.Text);
              drm.updatepriviewtable(ConstatData.department.Dept_name, table);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.manager.Show();
            this.Hide();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoRrealManager drm = new DoRrealManager();
            PurviewTable table = new PurviewTable();
            table = drm.get_pruiview(ConstatData.department.Dept_name,comboBox2.SelectedItem.ToString());
            textBox1.Text = table.Purview.ToString();
        }
    }
}
