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

                //karas: here can't directly use userName to show, we just obey the userid to show it, if it have userName, replace id, if not just show userId is ok.                            
                comboBox1.DataSource = list.Select(a => a.Name).ToList();
            }
            catch(Exception ex)
            {
                //karas: i strong suggest use this function to debug
                //Debug.Assert(false, "%s", ex.ToString());
                MessageBox.Show("还存在未填写详细信息的经理账号，请先请填写详细信息");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
             System.Windows.Forms.DialogResult result =
                 System.Windows.Forms.MessageBox.Show(
                         "确实要删除该经理吗",
                         "确认",
                         MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Question);
             if (result == System.Windows.Forms.DialogResult.OK)
             {
                 DoManager domanger = new DoManager();
                 domanger.delete_woker(comboBox1.Text);
                 MessageBox.Show("该经理已经删除");
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
