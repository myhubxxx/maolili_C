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
using 裕景管理系统.Domain;
namespace 裕景管理系统.manager
{
    public partial class add_dept_worker : Form
    {
        public add_dept_worker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoRrealManager drm = new DoRrealManager();
            if (drm.check_dept_worker(textBox1.Text, textBox2.Text))
            {
                drm.add_dept_worker(textBox1.Text, textBox2.Text, ConstatData.department.Dept_name);
                MessageBox.Show("员工账号添加成功");

            }
            else
            {

                MessageBox.Show("账号或密码已经存在");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.manager.Show();
            this.Close();
        }
    }
}
