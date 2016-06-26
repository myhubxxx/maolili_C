using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 裕景管理系统.administrator;
using 裕景管理系统.Domain;
using 裕景管理系统.manager;
namespace 裕景管理系统.staff
{
    public partial class Staff_index : Form
    {
        public Staff_index()
        {
            InitializeComponent();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConstatData.FormClose();
        }

        private void staff_Load(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
            index index = new index();
            index.TopLevel = false;
            index.Dock = System.Windows.Forms.DockStyle.Fill;
            index.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(index);
            index.Show();
            DoRrealManager drm = new DoRrealManager();
            label1.Text = drm.get_depatName(ConstatData.login.username);
            List<string> mess = new List<string>();
            mess = drm.check_if_isdate(ConstatData.login.username);
            for (int i = 0; i < mess.Count; i++)
            {
                label6.Text += mess[i] + "  ";
            }
            dostaff ds = new dostaff();
            if (ds.cheke_userinfodetail(ConstatData.login.username))
            {
                treeView1.Nodes[1].Nodes[0].ForeColor = Color.Gray;
            }
            if (!ds.cheke_userinfodetail(ConstatData.login.username))
            {
                treeView1.Nodes[2].Nodes[0].ForeColor = Color.Gray;
            }
        }

        private void 查看共享区ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show show_share = new show();
            show_share.Show();
        }

        private void 上传到共享区ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Application.StartupPath;
            file.DefaultExt = "xls";
            file.Filter = null;

            if (file.ShowDialog() == DialogResult.OK)
            {
                string filepath = file.FileName;
                FileInfo fileInfo = new FileInfo(filepath);

                string path1 = System.IO.Directory.GetCurrentDirectory() + "\\Share\\";
                File.Copy(filepath, path1 + fileInfo.Name);
                ////  File.Copy(filepath, AccessOp.sharePath +'\\' + fileInfo.Name);
                MessageBox.Show("上传成功");
            }

        }

        private void 添加备忘录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_notes ad = new add_notes();
            ad.Show();
        }

        private void 管理备忘录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_notes mn = new manage_notes();
            mn.Show();
        }

        private void Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConstatData.FormClose();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text.Trim() == "管理数据表信息")
            {
                manage_data md = new manage_data();
                md.TopLevel = false;
                md.Dock = System.Windows.Forms.DockStyle.Fill;
                md.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(md);
                md.Show();


            }
            if (e.Node.Text.Trim() == "录入个人详细信息")
            {
                dostaff ds = new dostaff();
                if (!ds.cheke_userinfodetail(ConstatData.login.username))
                {
                    add_user_info aui = new add_user_info();
                    aui.TopLevel = false;
                    aui.Dock = System.Windows.Forms.DockStyle.Fill;
                    aui.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(aui);
                    aui.Show();
                }
               
            }
            if (e.Node.Text.Trim() == "修改个人信息")
            {
                dostaff ds = new dostaff();
                if (ds.cheke_userinfodetail(ConstatData.login.username))
                {
                    manage_info mi = new manage_info();
                    mi.TopLevel = false;
                    mi.Dock = System.Windows.Forms.DockStyle.Fill;
                    mi.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(mi);
                    mi.Show();
                }
              
            }
        }

        private void 查看备忘录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_notes mn = new manage_notes();
            mn.Show();
        }
    }
}
