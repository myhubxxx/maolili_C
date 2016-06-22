namespace 裕景管理系统.manager
{
    partial class Manager
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("管理数据信息");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("管理部门数据信息", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("添加部门员工账号");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("删除部门员工账号");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("管理部门员工账号信息");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("管理部门员工详细信息");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("管理部门员工", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("分配部门员工权限");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("管理部门员工权限");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("权限", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("新建数据表格");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("删除数据表格");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("管理部门数据表", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("录入个人信息");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("录入个人信息", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("修改个人信息");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("修改个人信息", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.共享区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看共享区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传到共享区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备忘录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加备忘录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理备忘录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看备忘录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
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
            this.系统管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 共享区ToolStripMenuItem
            // 
            this.共享区ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看共享区ToolStripMenuItem,
            this.上传到共享区ToolStripMenuItem});
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
            // 上传到共享区ToolStripMenuItem
            // 
            this.上传到共享区ToolStripMenuItem.Name = "上传到共享区ToolStripMenuItem";
            this.上传到共享区ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.上传到共享区ToolStripMenuItem.Text = "上传到共享区";
            this.上传到共享区ToolStripMenuItem.Click += new System.EventHandler(this.上传到共享区ToolStripMenuItem_Click);
            // 
            // 备忘录ToolStripMenuItem
            // 
            this.备忘录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加备忘录ToolStripMenuItem,
            this.管理备忘录ToolStripMenuItem,
            this.查看备忘录ToolStripMenuItem});
            this.备忘录ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.备忘录ToolStripMenuItem.Name = "备忘录ToolStripMenuItem";
            this.备忘录ToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.备忘录ToolStripMenuItem.Text = "备忘录";
            // 
            // 添加备忘录ToolStripMenuItem
            // 
            this.添加备忘录ToolStripMenuItem.Name = "添加备忘录ToolStripMenuItem";
            this.添加备忘录ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.添加备忘录ToolStripMenuItem.Text = "添加备忘录";
            this.添加备忘录ToolStripMenuItem.Click += new System.EventHandler(this.添加备忘录ToolStripMenuItem_Click);
            // 
            // 管理备忘录ToolStripMenuItem
            // 
            this.管理备忘录ToolStripMenuItem.Name = "管理备忘录ToolStripMenuItem";
            this.管理备忘录ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.管理备忘录ToolStripMenuItem.Text = "管理备忘录";
            this.管理备忘录ToolStripMenuItem.Click += new System.EventHandler(this.管理备忘录ToolStripMenuItem_Click);
            // 
            // 查看备忘录ToolStripMenuItem
            // 
            this.查看备忘录ToolStripMenuItem.Name = "查看备忘录ToolStripMenuItem";
            this.查看备忘录ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.查看备忘录ToolStripMenuItem.Text = "查看备忘录";
            this.查看备忘录ToolStripMenuItem.Click += new System.EventHandler(this.查看备忘录ToolStripMenuItem_Click);
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
            this.查看帮助说明ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 查看帮助说明ToolStripMenuItem
            // 
            this.查看帮助说明ToolStripMenuItem.Name = "查看帮助说明ToolStripMenuItem";
            this.查看帮助说明ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.查看帮助说明ToolStripMenuItem.Text = "查看帮助说明";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Snow;
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.treeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.treeView1.Location = new System.Drawing.Point(0, 53);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "管理数据信息";
            treeNode1.Text = "管理数据信息";
            treeNode2.Name = "管理部门数据信息";
            treeNode2.Text = "管理部门数据信息";
            treeNode3.Name = "添加部门员工账号";
            treeNode3.Text = "添加部门员工账号";
            treeNode4.Name = "删除部门员工账号";
            treeNode4.Text = "删除部门员工账号";
            treeNode5.Name = "管理部门员工账号信息";
            treeNode5.Text = "管理部门员工账号信息";
            treeNode6.Name = "管理部门员工详细信息";
            treeNode6.Text = "管理部门员工详细信息";
            treeNode7.Name = "管理部门员工";
            treeNode7.Text = "管理部门员工";
            treeNode8.Name = "分配部门员工权限";
            treeNode8.Text = "分配部门员工权限";
            treeNode9.Name = "管理部门员工权限";
            treeNode9.Text = "管理部门员工权限";
            treeNode10.Name = "权限";
            treeNode10.Text = "权限";
            treeNode11.Name = "新建数据表格";
            treeNode11.Text = "新建数据表格";
            treeNode12.Name = "删除数据表格";
            treeNode12.Text = "删除数据表格";
            treeNode13.Name = "管理部门数据表";
            treeNode13.Text = "管理部门数据表";
            treeNode14.Name = "录入个人信息";
            treeNode14.Text = "录入个人信息";
            treeNode15.Name = "录入个人信息";
            treeNode15.Text = "录入个人信息";
            treeNode16.Name = "修改个人信息";
            treeNode16.Text = "修改个人信息";
            treeNode17.Name = "修改个人信息";
            treeNode17.Text = "修改个人信息";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode7,
            treeNode10,
            treeNode13,
            treeNode15,
            treeNode17});
            this.treeView1.Size = new System.Drawing.Size(187, 615);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(-4, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "功     能      菜      单";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(463, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(187, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 598);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(-3, 671);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "||欢迎使用成都裕锦公司信息管理系统|| ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(294, 671);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "当前用户:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(422, 671);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "部门经理";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 692);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "裕锦公司--部门经理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            this.Load += new System.EventHandler(this.manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 共享区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看共享区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上传到共享区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备忘录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加备忘录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理备忘录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看备忘录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助说明ToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}