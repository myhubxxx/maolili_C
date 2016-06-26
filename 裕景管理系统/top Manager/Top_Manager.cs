using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 裕景管理系统.administrator;
using 裕景管理系统.Domain;

namespace 裕景管理系统.top_Manager
{
    public partial class Top_Manager : Form
    {
        public Top_Manager()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
                 DoManager domanager = new DoManager();
            if (e.Node.Text.Trim() == "查询所有部门")
               {
                    if (domanager.checkdepartment())
                    {
                        dept_query dept = new dept_query();
                       dept.TopLevel = false;
                       dept.Dock = System.Windows.Forms.DockStyle.Fill;
                       dept.FormBorderStyle = FormBorderStyle.None;
                       panel1.Controls.Clear();
                       panel1.Controls.Add(dept);
                       dept.Show();
                    
                    }
                    else
                    {
                        MessageBox.Show("当前没有任何部门，无法查询");
                    }


            }
            if (e.Node.Text.Trim() == "查询部门下所有数据表")
            {
                TM_table_query tmtq = new TM_table_query();
                tmtq.TopLevel = false;
                tmtq.Dock = System.Windows.Forms.DockStyle.Fill;
                tmtq.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(tmtq);
                tmtq.Show();

            }
            if (e.Node.Text.Trim() == "查询经理账号信息")
            {
                TM_search_manager tsm = new TM_search_manager();
                tsm.TopLevel = false;
                tsm.Dock = System.Windows.Forms.DockStyle.Fill;
                tsm.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(tsm);
                tsm.Show();

            }
            if (e.Node.Text.Trim() == "查询员工账号信息")
            {
                TM_search_staff tss = new TM_search_staff();
                tss.TopLevel = false;
                tss.Dock = System.Windows.Forms.DockStyle.Fill;
                tss.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(tss);
                tss.Show();


            }
        }

        private void 共享区ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查看共享区ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show sh = new show();
            sh.Show();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConstatData.login.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConstatData.FormClose();
        }

        private void Top_Manager_Load(object sender, EventArgs e)
        {
            index index = new index();
            index.TopLevel = false;
            index.Dock = System.Windows.Forms.DockStyle.Fill;
            index.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(index);
            index.Show();
        }

        private void Top_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConstatData.FormClose();
        }
    }
}
