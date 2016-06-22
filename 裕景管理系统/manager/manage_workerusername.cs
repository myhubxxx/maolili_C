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
using 裕景管理系统.Dao;
namespace 裕景管理系统.manager
{
    public partial class manage_workerusername : Form
    {
        public manage_workerusername()
        {
            InitializeComponent();
        }

        private void manage_workerusername_Load(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);

            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;
            this.dataGridView1.DataSource = this.touserinfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             System.Windows.Forms.DialogResult result =
                 System.Windows.Forms.MessageBox.Show(
                         "确实要保存修改吗",
                         "确认",
                         MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Question);
             if (result == System.Windows.Forms.DialogResult.OK)
             {
                 var a = this.dataGridView1.DataSource as List<entity>;
                 var row = a.updateuserinfo();
                 MessageBox.Show("修改成功");
                 
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

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
            }
        }
    }
}
