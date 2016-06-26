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
    public partial class delete_dept_worker : Form
    {
        public delete_dept_worker()
        {
            InitializeComponent();
        }
        private void delete_dept_worker_Load(object sender, EventArgs e)
        {
            try{    
                int level = 0;
                DoRrealManager drm = new DoRrealManager();
                List<UserInfo> list = drm.getallworkername(level);
                comboBox1.DataSource = list.Select(a => a.Name).ToList();
            }
            catch
            {
                MessageBox.Show("对不起，尚存在未填写详细信息的员工，请员工登录个人界面，填写个人详细信息");
            }
        }
        private void button1_Click(object sender, EventArgs e)
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
                 drm.delete_worker(comboBox1.Text);
                 MessageBox.Show(ShareLib.Staff_Delete_Success);
                 int level = 0;
                // DoRrealManager drm = new DoRrealManager();
                 List<UserInfo> list = drm.getallworkername(level);
                 if (list == null || list.Count == 0)
                 {
                     comboBox1.DataSource = null;
                 }
                 else
                 {
                     comboBox1.DataSource = list.Select(a => a.Name).ToList();
                 }

             }
             else
             {
                 return;
             }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.manager.Show();
            this.Hide();
        }
    }
}
