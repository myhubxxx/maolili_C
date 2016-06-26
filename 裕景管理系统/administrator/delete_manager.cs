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
using System.Diagnostics;
namespace 裕景管理系统.administrator
{
    public partial class delete_manager : Form
    {
        public delete_manager()
        {
            InitializeComponent();
        }
        private void delete_manager_Load(object sender, EventArgs e)
        {
            try
            {
                int id = 1;
                DoManager domanager = new DoManager();
                List<UserInfo> list = domanager.getmangername_list(id);
                comboBox1.DataSource = list.Select(a => a.Name).ToList();
            }
            catch(Exception)
            {
                //here need to modify
                MessageBox.Show("还存在未填写详细信息的经理账号，请先请填写详细信息");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请选择要删除的经理");
            }
             System.Windows.Forms.DialogResult result =
                 System.Windows.Forms.MessageBox.Show(
                         ShareLib.Confirm_DeletManager,
                         ShareLib.Make_Sure,
                         MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Question);
             if (result == System.Windows.Forms.DialogResult.OK)
             {
                 DoManager domanger = new DoManager();
                 domanger.delete_woker(comboBox1.Text);
                 MessageBox.Show(ShareLib.Mnager_Delete_Success);
                 int id = 1;
                 DoManager domanager = new DoManager();
                 List<UserInfo> list = domanager.getmangername_list(id);
                 if (list == null || list.Count() == 0)
                 { 
                     comboBox1.DataSource = null;
                 }
                 comboBox1.DataSource = list.Select(a => a.Name).ToList();
                 
               
             }
             else
             {
                 return;
             }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.admin.Show();
            this.Hide();
        }
    }
}
