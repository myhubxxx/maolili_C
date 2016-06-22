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
    public partial class delete_table : Form
    {
        public delete_table()
        {
            InitializeComponent();
        }

        private void delete_table_Load(object sender, EventArgs e)
        {
            DoManager domanager=new DoManager ();
            List<Department> dept = domanager.getalldept_list();
            comboBox1.DataSource = dept.Select(a => a.Dept_name).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoManager DM = new DoManager();
            if (!DM.check_department_totaltable(comboBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("您选择的部门还未创建任何表，请重新选择");
            }
            else
            {
                DoManager domanager = new DoManager();
                List<TotalTable> table = domanager.get_alltable_list(comboBox1.Text);
                comboBox2.DataSource = table.Select(a => a.Tablename).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             System.Windows.Forms.DialogResult result =
               System.Windows.Forms.MessageBox.Show(
                       "确实要删除该数据表吗？",
                       "确认",
                       MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Question);
             if (result == System.Windows.Forms.DialogResult.OK)
             {
                 //确认处理

                 AccessOp.DeleteAccessTab(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                 MessageBox.Show("数据表删除成功");
             }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.admin.Show();
            this.Close();
        }
    }
}
