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


namespace 裕景管理系统.administrator
{
    public partial class checkuser : Form
    {
        public checkuser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!= ConstatData.login.userpwd)
            {
                MessageBox.Show("对不起，操作失败，请确认密码");

            }
            else
            {
                     System.Windows.Forms.DialogResult result =
                    System.Windows.Forms.MessageBox.Show(
                            "确实要删除该部门吗？",
                            "确认",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question);
                     if (result == System.Windows.Forms.DialogResult.OK)
                     {
                         DoManager domanager = new DoManager();
                         domanager.delete_dept(ConstatData.dele_dept.dele_dept_name);
                         MessageBox.Show("删除成功");
                       
                     }

                     else
                     {
                         return;

                     }




            }
                
        }

        private void checkuser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
      
            this.Close();
        }
    }
}
