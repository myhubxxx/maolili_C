namespace 裕景管理系统.administrator
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("查询所有部门");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("查询部门下的数据表");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("查询信息", new System.Windows.Forms.TreeNode[] {
            treeNode96,
            treeNode97});
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("管理经理账号信息");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("管理员工账号信息");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("管理员工详细信息");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("管理员工", new System.Windows.Forms.TreeNode[] {
            treeNode99,
            treeNode100,
            treeNode101});
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("增加部门");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("删除部门");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("添加部门经理");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("删除部门经理");
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("管理部门", new System.Windows.Forms.TreeNode[] {
            treeNode103,
            treeNode104,
            treeNode105,
            treeNode106});
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("导入数据表");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("导出数据表");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("操作", new System.Windows.Forms.TreeNode[] {
            treeNode108,
            treeNode109});
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("管理数据信息");
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("新建数据表");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("删除数据表");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("管理部门数据信息", new System.Windows.Forms.TreeNode[] {
            treeNode111,
            treeNode112,
            treeNode113});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.共享区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看共享区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传共享区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备忘录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看备忘录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理备忘录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加备忘录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FloralWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.共享区ToolStripMenuItem,
            this.备忘录ToolStripMenuItem,
            this.系统管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 共享区ToolStripMenuItem
            // 
            this.共享区ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看共享区ToolStripMenuItem,
            this.上传共享区ToolStripMenuItem});
            this.共享区ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.共享区ToolStripMenuItem.Name = "共享区ToolStripMenuItem";
            this.共享区ToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.共享区ToolStripMenuItem.Text = "共享区";
            // 
            // 查看共享区ToolStripMenuItem
            // 
            this.查看共享区ToolStripMenuItem.Name = "查看共享区ToolStripMenuItem";
            this.查看共享区ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.查看共享区ToolStripMenuItem.Text = "查看共享区";
            this.查看共享区ToolStripMenuItem.Click += new System.EventHandler(this.查看共享区ToolStripMenuItem_Click);
            // 
            // 上传共享区ToolStripMenuItem
            // 
            this.上传共享区ToolStripMenuItem.Name = "上传共享区ToolStripMenuItem";
            this.上传共享区ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.上传共享区ToolStripMenuItem.Text = "上传到共享区";
            this.上传共享区ToolStripMenuItem.Click += new System.EventHandler(this.上传共享区ToolStripMenuItem_Click);
            // 
            // 备忘录ToolStripMenuItem
            // 
            this.备忘录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看备忘录ToolStripMenuItem,
            this.管理备忘录ToolStripMenuItem,
            this.添加备忘录ToolStripMenuItem});
            this.备忘录ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.备忘录ToolStripMenuItem.Name = "备忘录ToolStripMenuItem";
            this.备忘录ToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.备忘录ToolStripMenuItem.Text = "备忘录";
            // 
            // 查看备忘录ToolStripMenuItem
            // 
            this.查看备忘录ToolStripMenuItem.Name = "查看备忘录ToolStripMenuItem";
            this.查看备忘录ToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.查看备忘录ToolStripMenuItem.Text = "查看备忘录";
            this.查看备忘录ToolStripMenuItem.Click += new System.EventHandler(this.查看备忘录ToolStripMenuItem_Click);
            // 
            // 管理备忘录ToolStripMenuItem
            // 
            this.管理备忘录ToolStripMenuItem.Name = "管理备忘录ToolStripMenuItem";
            this.管理备忘录ToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.管理备忘录ToolStripMenuItem.Text = "管理备忘录";
            this.管理备忘录ToolStripMenuItem.Click += new System.EventHandler(this.管理备忘录ToolStripMenuItem_Click);
            // 
            // 添加备忘录ToolStripMenuItem
            // 
            this.添加备忘录ToolStripMenuItem.Name = "添加备忘录ToolStripMenuItem";
            this.添加备忘录ToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.添加备忘录ToolStripMenuItem.Text = "添加备忘录";
            this.添加备忘录ToolStripMenuItem.Click += new System.EventHandler(this.添加备忘录ToolStripMenuItem_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新登录ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 重新登录ToolStripMenuItem
            // 
            this.重新登录ToolStripMenuItem.Name = "重新登录ToolStripMenuItem";
            this.重新登录ToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.重新登录ToolStripMenuItem.Text = "重新登录";
            this.重新登录ToolStripMenuItem.Click += new System.EventHandler(this.重新登录ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助信息ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 查看帮助信息ToolStripMenuItem
            // 
            this.查看帮助信息ToolStripMenuItem.Name = "查看帮助信息ToolStripMenuItem";
            this.查看帮助信息ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.查看帮助信息ToolStripMenuItem.Text = "查看帮助信息";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Snow;
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.treeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.treeView1.Location = new System.Drawing.Point(0, 61);
            this.treeView1.Name = "treeView1";
            treeNode96.Name = "节点5";
            treeNode96.Text = "查询所有部门";
            treeNode97.Name = "节点6";
            treeNode97.Text = "查询部门下的数据表";
            treeNode98.Name = "节点0";
            treeNode98.Text = "查询信息";
            treeNode99.Name = "节点8";
            treeNode99.Text = "管理经理账号信息";
            treeNode100.Name = "节点9";
            treeNode100.Text = "管理员工账号信息";
            treeNode101.Name = "节点10";
            treeNode101.Text = "管理员工详细信息";
            treeNode102.Name = "节点1";
            treeNode102.Text = "管理员工";
            treeNode103.Name = "节点11";
            treeNode103.Text = "增加部门";
            treeNode104.Name = "节点12";
            treeNode104.Text = "删除部门";
            treeNode105.Name = "节点13";
            treeNode105.Text = "添加部门经理";
            treeNode106.Name = "节点14";
            treeNode106.Text = "删除部门经理";
            treeNode107.Name = "节点2";
            treeNode107.Text = "管理部门";
            treeNode108.Name = "节点15";
            treeNode108.Text = "导入数据表";
            treeNode109.Name = "节点16";
            treeNode109.Text = "导出数据表";
            treeNode110.Name = "节点4";
            treeNode110.Text = "操作";
            treeNode111.Name = "节点17";
            treeNode111.Text = "管理数据信息";
            treeNode112.Name = "节点18";
            treeNode112.Text = "新建数据表";
            treeNode113.Name = "节点19";
            treeNode113.Text = "删除数据表";
            treeNode114.Name = "节点3";
            treeNode114.Text = "管理部门数据信息";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode98,
            treeNode102,
            treeNode107,
            treeNode110,
            treeNode114});
            this.treeView1.Size = new System.Drawing.Size(187, 588);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 664);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "||欢迎使用成都裕锦公司信息管理系统|| ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(291, 662);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "当前用户:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(402, 662);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "系统管理员";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(185, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 618);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(-3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "功     能     菜     单";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(957, 684);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "裕锦公司--管理员";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admin_FormClosing);
            this.Load += new System.EventHandler(this.admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 共享区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看共享区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上传共享区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备忘录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看备忘录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理备忘录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助信息ToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem 添加备忘录ToolStripMenuItem;
    }
}