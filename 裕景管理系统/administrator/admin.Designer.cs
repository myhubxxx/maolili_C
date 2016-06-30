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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("查询所有部门");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("查询部门下的数据表");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("查询信息", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("管理经理账号信息");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("管理员工账号信息");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("管理员工详细信息");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("管理员工", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("增加部门");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("删除部门");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("添加部门经理");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("删除部门经理");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("管理部门", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("导入数据表");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("导出数据表");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("操作", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("管理数据信息");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("新建数据表");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("删除数据表");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("管理部门数据信息", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.共享区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看共享区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传共享区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备忘录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看备忘录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理备忘录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加备忘录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FloralWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.共享区ToolStripMenuItem,
            this.备忘录ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.系统管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1086, 28);
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
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助信息ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.帮助ToolStripMenuItem.Text = "管理员工证书";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 查看帮助信息ToolStripMenuItem
            // 
            this.查看帮助信息ToolStripMenuItem.Name = "查看帮助信息ToolStripMenuItem";
            this.查看帮助信息ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.查看帮助信息ToolStripMenuItem.Text = "管理员工证书";
            this.查看帮助信息ToolStripMenuItem.Click += new System.EventHandler(this.查看帮助信息ToolStripMenuItem_Click);
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
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助信息ToolStripMenuItem1});
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            // 
            // 查看帮助信息ToolStripMenuItem1
            // 
            this.查看帮助信息ToolStripMenuItem1.Name = "查看帮助信息ToolStripMenuItem1";
            this.查看帮助信息ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.查看帮助信息ToolStripMenuItem1.Text = "查看帮助信息";
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
            treeNode1.Name = "节点5";
            treeNode1.Tag = "dept_query";
            treeNode1.Text = "查询所有部门";
            treeNode2.Name = "节点6";
            treeNode2.Text = "查询部门下的数据表";
            treeNode3.Name = "节点0";
            treeNode3.Text = "查询信息";
            treeNode4.Name = "节点8";
            treeNode4.Text = "管理经理账号信息";
            treeNode5.Name = "节点9";
            treeNode5.Text = "管理员工账号信息";
            treeNode6.Name = "节点10";
            treeNode6.Text = "管理员工详细信息";
            treeNode7.Name = "节点1";
            treeNode7.Text = "管理员工";
            treeNode8.Name = "节点11";
            treeNode8.Text = "增加部门";
            treeNode9.Name = "节点12";
            treeNode9.Text = "删除部门";
            treeNode10.Name = "节点13";
            treeNode10.Text = "添加部门经理";
            treeNode11.Name = "节点14";
            treeNode11.Text = "删除部门经理";
            treeNode12.Name = "节点2";
            treeNode12.Text = "管理部门";
            treeNode13.Name = "节点15";
            treeNode13.Text = "导入数据表";
            treeNode14.Name = "节点16";
            treeNode14.Text = "导出数据表";
            treeNode15.Name = "节点4";
            treeNode15.Text = "操作";
            treeNode16.Name = "节点17";
            treeNode16.Text = "管理数据信息";
            treeNode17.Name = "节点18";
            treeNode17.Text = "新建数据表";
            treeNode18.Name = "节点19";
            treeNode18.Text = "删除数据表";
            treeNode19.Name = "节点3";
            treeNode19.Text = "管理部门数据信息";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7,
            treeNode12,
            treeNode15,
            treeNode19});
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
            this.panel1.Location = new System.Drawing.Point(185, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 588);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(195, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "消息：";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1086, 684);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助信息ToolStripMenuItem1;
    }
}