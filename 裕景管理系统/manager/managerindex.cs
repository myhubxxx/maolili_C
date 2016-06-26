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
using 裕景管理系统.administrator;
using System.IO;
using 裕景管理系统.staff;
namespace 裕景管理系统.manager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void manager_Load(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
            ConstatData.manager = this;
            index index = new index();
            index.TopLevel = false;
            index.Dock = System.Windows.Forms.DockStyle.Fill;
            index.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(index);
            index.Show();

            DoRrealManager drm = new DoRrealManager();
            List<string> mess = new List<string>();
           mess=drm.check_if_isdate(ConstatData.login.username);
           for (int i = 0; i < mess.Count; i++)
           {
               label6.Text += mess[i]+"  ";
           }
            label2.Text = drm.get_depatName(ConstatData.login.username);

            if (drm.cheke_userinfodetail(ConstatData.login.username))
            {
                treeView1.Nodes[4].Nodes[0].ForeColor = Color.Gray;
            }
            if (!drm.cheke_userinfodetail(ConstatData.login.username))
            {
                treeView1.Nodes[5].Nodes[0].ForeColor = Color.Gray;
            }
            
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConstatData.FormClose();
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text.Trim() == "管理数据信息")
            {
                datainfo_manage man = new datainfo_manage();
                man.TopLevel = false;
                man.Dock = System.Windows.Forms.DockStyle.Fill;
                man.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(man);
                man.Show();
            }
            if (e.Node.Text.Trim() == "添加部门员工账号")
            {
                add_dept_worker adw = new add_dept_worker();
               adw.TopLevel = false;
                adw.Dock = System.Windows.Forms.DockStyle.Fill;
                adw.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(adw);
                adw.Show();

            }
            if (e.Node.Text.Trim() == "删除部门员工账号")
            {
                delete_dept_worker ddw = new delete_dept_worker();
                ddw.TopLevel = false;
                ddw.Dock = System.Windows.Forms.DockStyle.Fill;
                ddw.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(ddw);
                ddw.Show();

            }
            if (e.Node.Text.Trim() == "管理部门员工账号信息")
            {
                manage_workerusername mw = new manage_workerusername();
                mw.TopLevel = false;
                mw.Dock = System.Windows.Forms.DockStyle.Fill;
                mw.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(mw);
                mw.Show();
            }
            if (e.Node.Text.Trim() == "管理部门员工详细信息")
            {
                manage_staffinfo ms = new manage_staffinfo();
                ms.TopLevel = false;
                ms.Dock = System.Windows.Forms.DockStyle.Fill;
                ms.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(ms);
                ms.Show();



            }
            if (e.Node.Text.Trim() == "分配部门员工权限")
            {
                DoManager domanger = new DoManager();
                if (domanger.check_department_totaltable(ConstatData.department.Dept_name))
                {


                    New_add_level al = new New_add_level();
                    al.TopLevel = false;
                    al.Dock = System.Windows.Forms.DockStyle.Fill;
                    al.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(al);
                    al.Show();
                }
                else
                {
                    MessageBox.Show("对不起，该部门还未创建任何数据表,所以暂时无法分配");


                }


            }
            if (e.Node.Text.Trim() == "管理部门员工权限")
            {
                DoRrealManager drm = new DoRrealManager();
                if (drm.check_pur_none(ConstatData.department.Dept_name))
                {
                    mannage_levels ml = new mannage_levels();
                    ml.TopLevel = false;
                    ml.Dock = System.Windows.Forms.DockStyle.Fill;
                    ml.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(ml);
                    ml.Show();
                }
                else
                {

                    MessageBox.Show("对不起，您还没有分配员工的可操作表，所以不能进行管理");
                }

            }

            if (e.Node.Text == "新建数据表格")
            {
                add_dept_table adt = new add_dept_table();
                adt.TopLevel = false;
                adt.Dock = System.Windows.Forms.DockStyle.Fill;
                adt.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(adt);
                adt.Show();


            }
            if (e.Node.Text.Trim() == "录入个人信息")
            {
                DoRrealManager drm = new DoRrealManager();
                if (!drm.cheke_userinfodetail(ConstatData.login.username))
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
            if (e.Node.Text.Trim() == "导入数据表")
            {
                OpenFileDialog file = new OpenFileDialog();
                file.InitialDirectory = Application.StartupPath;
                file.Filter = null;
                if (file.ShowDialog() == DialogResult.OK)
                {
                    string filename = file.FileName;
                   
                    ImportExcel ie = new ImportExcel();
                    ie.importExcelAllTable(ConstatData.department.Dept_name, filename);
                    MessageBox.Show("导入成功");
                }
                else
                {
                    return;
                }
            }
            if (e.Node.Text.Trim() == "导出数据表")
            {
                M_output_table mot = new M_output_table();
                mot.TopLevel = false;
                mot.Dock = System.Windows.Forms.DockStyle.Fill;
                mot.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(mot);
                mot.Show();
            }
            if (e.Node.Text.Trim() == "修改个人信息")
            {
                DoRrealManager drm = new DoRrealManager();
                if (drm.cheke_userinfodetail(ConstatData.login.username))
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
            if (e.Node.Text.Trim() == "删除数据表格")
            {
                delete_dept_table ddt = new delete_dept_table();
                ddt.TopLevel = false;
                ddt.Dock = System.Windows.Forms.DockStyle.Fill;
                ddt.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(ddt);
                ddt.Show();



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

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConstatData.FormClose();
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConstatData.login.Show();
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

        private void 查看备忘录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_notes mn = new manage_notes();
            mn.Show();
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node != null)
            {
                if (e.Node.ForeColor == SystemColors.Control)
                {
                    e.Cancel = true;  //不让选中禁用节点
                }
            }
        }
    }
}
