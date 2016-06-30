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
            if (textBox1.Text =="")
            {
                MessageBox.Show(ShareLib.No_Fill_dept);
            }
            else
            {
                DoManager domanage = new DoManager();
                //check if has had dept,if not had you can add directly ,if has had added 
                //already you shou avoid adding the same dept name
                if (!domanage.checkdepartment())
                {
                    domanage.adddepart(textBox1.Text);
                    MessageBox.Show(ShareLib.Add_Success);
                }
                else
                {//check if have the same dept name
                    if (domanage.checkdept(textBox1.Text))
                    {
                        domanage.adddepart(textBox1.Text);
                        MessageBox.Show(ShareLib.Add_Success);
                    }
                    else
                    {
                        MessageBox.Show(ShareLib.Dept_Has_Exsist);
                    }
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
