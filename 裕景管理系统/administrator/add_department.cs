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
    public partial class add_department : Form
    {
        public add_department()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoManager domanage = new DoManager();
            if (!domanage.checkdepartment())
            {
                domanage.adddepart(textBox1.Text);
                MessageBox.Show("部门创建成功");

            }
            else
            {
                if (domanage.checkdept(textBox1.Text))
                {
                    domanage.adddepart(textBox1.Text);
                    MessageBox.Show("部门创建成功");
                }
                else
                {
                    MessageBox.Show("部门已经存在，请重新添加");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.admin.Show();
            this.Close();
        }

        private void add_department_Load(object sender, EventArgs e)
        {

        }
    }
}
