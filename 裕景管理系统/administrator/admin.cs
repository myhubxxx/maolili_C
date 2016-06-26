using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 裕景管理系统.Domain;
using 裕景管理系统.manager;


namespace 裕景管理系统.administrator
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
            DoManager domanger = new DoManager();
            List<string> messge = new List<string>();
           messge=domanger.check_admin_note(ConstatData.login.username);
         // label5.Text += messge;
           for (int i = 0; i < messge.Count; i++)
           {
               label5.Text += messge[i]+"   ";

           }
            ConstatData.admin = this;
            index index = new index();
            index.TopLevel = false;
            index.Dock = System.Windows.Forms.DockStyle.Fill;
            index.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(index);
            index.Show();
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
                        MessageBox.Show("对不起，您当前未创建任何部门，无法查询");
                    }

               }
            
            if (e.Node.Text.Trim() == "查询部门下的数据表")
            {
                if (domanager.checkdepartment())
                {
                    table_query tbquery = new table_query();
                    tbquery.TopLevel = false;
                    tbquery.Dock = System.Windows.Forms.DockStyle.Fill;
                    tbquery.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(tbquery);
                    tbquery.Show();
                }
                else
                {
                    MessageBox.Show("对不起，您当前未创建任何部门，无法查询");
                }

            }
            if (e.Node.Text.Trim() == "管理经理账号信息")
            {
                if (domanager.checkdepartment())
                {
                    manage_manager mm = new manage_manager();
                    mm.TopLevel = false;
                    mm.Dock = System.Windows.Forms.DockStyle.Fill;
                    mm.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(mm);
                    mm.Show();
                }
                else
                {
                    MessageBox.Show("对不起，您当前未创建任何部门，无法管理经理账号");
                }

            }
            if (e.Node.Text.Trim() == "管理员工账号信息")
            {
                 if (domanager.checkdepartment())
                {
                manage_staff staff = new manage_staff();
                staff.TopLevel = false;
                staff.Dock = System.Windows.Forms.DockStyle.Fill;
                staff.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(staff);
                staff.Show();
                }
                 else
                 {
                     MessageBox.Show("对不起，您当前未创建任何部门，无法管理员工账号");
                 }
            }
            if (e.Node.Text.Trim() == "管理员工详细信息")
            {
                if(domanager.checkdepartment())
                {
                manage_staffinfo info = new manage_staffinfo();
                info.TopLevel = false;
                info.Dock = System.Windows.Forms.DockStyle.Fill;
                info.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(info);
                info.Show();}
                else
                {
                    MessageBox.Show("对不起，您当前未创建任何部门，无法管理经理账号");
                }
            }
            if (e.Node.Text.Trim() == "增加部门")
            {
                add_department adddept = new add_department();
                adddept.TopLevel = false;
                adddept.Dock = System.Windows.Forms.DockStyle.Fill;
                adddept.FormBorderStyle = FormBorderStyle.None;
                panel1.Controls.Clear();
                panel1.Controls.Add(adddept);
                adddept.Show();
            }
            if (e.Node.Text.Trim() == "删除部门")
            {
                if (domanager.checkdepartment())
                {
                    delete_department de_dept = new delete_department();
                    de_dept.TopLevel = false;
                    de_dept.Dock = System.Windows.Forms.DockStyle.Fill;
                    de_dept.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(de_dept);
                    de_dept.Show();
                }
                else
                {

                    MessageBox.Show("对不起，您未创建任何部门，无法删除");
                }
            }
            if (e.Node.Text.Trim() == "添加部门经理")
            {
                if (domanager.checkdepartment())
                {
                    add_manager addma = new add_manager();
                    addma.TopLevel = false;
                    addma.Dock = System.Windows.Forms.DockStyle.Fill;
                    addma.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(addma);
                    addma.Show();
                }
                else
                {
                    MessageBox.Show("对不起，您当前未创建任何部门，无法添加部门经理");
                }
            }
            if (e.Node.Text.Trim() == "删除部门经理")
            {
                if (domanager.checkdepartment())
                {

                    delete_manager dele_ma = new delete_manager();
                    dele_ma.TopLevel = false;
                    dele_ma.Dock = System.Windows.Forms.DockStyle.Fill;
                    dele_ma.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(dele_ma);
                    dele_ma.Show();
                }
                else
                {
                    MessageBox.Show("对不起，您当前未创建任何部门，无法删除部门经理");
                }
            }
            if (e.Node.Text.Trim() == "导入数据表")
            {
                if (domanager.checkdepartment())
                {
                    importtable importtb = new importtable();
                    importtb.TopLevel = false;
                    importtb.Dock = System.Windows.Forms.DockStyle.Fill;
                    importtb.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(importtb);
                    importtb.Show();
                }
                else
                {
                    MessageBox.Show("对不起，您未创建任何部门，无法进行导入");
                }
            }
            if (e.Node.Text.Trim() == "导出数据表")
            {
                if (domanager.checkdepartment())
                {
                    outport_datatable out_table = new outport_datatable();
                    out_table.TopLevel = false;
                    out_table.Dock = System.Windows.Forms.DockStyle.Fill;
                    out_table.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(out_table);
                    out_table.Show();
                }
                else
                {
                    MessageBox.Show("对不起，您尚未创建任何部门，无法进行导出");
                }
            }
            if (e.Node.Text.Trim() == "管理数据信息")
            {
                if (domanager.checkdepartment())
                {
                    dept_datainfo dept_datainfo = new dept_datainfo();

                    dept_datainfo.TopLevel = false;
                    dept_datainfo.Dock = System.Windows.Forms.DockStyle.Fill;
                    dept_datainfo.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(dept_datainfo);
                    dept_datainfo.Show();
                }
                else
                {
                    MessageBox.Show("对不起，您尚未创建部门，无法管理数据信息");
                }
            }
            if (e.Node.Text.Trim() == "新建数据表")
            {
                if (domanager.checkdepartment())
                {
                    add_table adtable = new add_table();
                    adtable.TopLevel = false;
                    adtable.Dock = System.Windows.Forms.DockStyle.Fill;
                    adtable.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(adtable);
                    adtable.Show();
                }
                else
                {
                    MessageBox.Show("对不起，您尚未创建部门，无法新建数据表");
                }
            }
            if (e.Node.Text.Trim() == "删除数据表")
            {
                if (domanager.checkdepartment())
                {
                    delete_table deltetb = new delete_table();
                    deltetb.TopLevel = false;
                    deltetb.Dock = System.Windows.Forms.DockStyle.Fill;
                    deltetb.FormBorderStyle = FormBorderStyle.None;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(deltetb);
                    deltetb.Show();
                }
                else
                {
                    MessageBox.Show("对不起，您尚未创建部门，无法删除数据表");
                }
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认退出程序?", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ConstatData.FormClose();
            }
            else
                e.Cancel = true;//取消退出事件
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            this.Hide();

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConstatData.FormClose();
        }

        private void 上传共享区ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Application.StartupPath;

            //karas: here, DefualtExt just split from Filter.
            //file.DefaultExt = "xls";
            file.Filter = null;//默认为任何文件

            if (file.ShowDialog() == DialogResult.OK)//在对话框里点了导入
            {
                //karas: becareful, when you handle file, you must know error about it.
                try
                {
                    string filepath = file.FileName;
                    FileInfo fileInfo = new FileInfo(filepath);
                    string path1 = System.IO.Directory.GetCurrentDirectory() + "\\Share\\";

                    File.Copy(filepath, path1 + fileInfo.Name);
                    MessageBox.Show("上传成功");
                }
                catch(Exception ex)
                {
                    ShareLib.Instance().HandleExcption(ex);
                }
            } 
        }

        private void 查看共享区ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             show show=new show ();
             show.Show();
        }

        private void 查看备忘录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_note mn = new manage_note();
            mn.Show();
        }

        private void 添加备忘录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_note an = new add_note();
            an.Show();
        }

        private void 管理备忘录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_note mn = new manage_note();
            mn.Show();
        }
    }
}
