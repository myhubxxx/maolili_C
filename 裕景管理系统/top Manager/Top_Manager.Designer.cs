namespace 裕景管理系统.top_Manager
{
    partial class Top_Manager
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
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("查询所有部门");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("查询部门下所有数据表");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("查询经理账号信息");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("查询员工账号信息");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("查询员工详细信息");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("查询", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.共享区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看共享区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.共享区ToolStripMenuItem,
            this.系统功能ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 共享区ToolStripMenuItem
            // 
            this.共享区ToolStripMenuItem.BackColor = System.Drawing.Color.FloralWhite;
            this.共享区ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看共享区ToolStripMenuItem});
            this.共享区ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.共享区ToolStripMenuItem.Name = "共享区ToolStripMenuItem";
            this.共享区ToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.共享区ToolStripMenuItem.Text = "共享区";
            this.共享区ToolStripMenuItem.Click += new System.EventHandler(this.共享区ToolStripMenuItem_Click);
            // 
            // 查看共享区ToolStripMenuItem
            // 
            this.查看共享区ToolStripMenuItem.Name = "查看共享区ToolStripMenuItem";
            this.查看共享区ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.查看共享区ToolStripMenuItem.Text = "查看共享区";
            this.查看共享区ToolStripMenuItem.Click += new System.EventHandler(this.查看共享区ToolStripMenuItem_Click);
            // 
            // 系统功能ToolStripMenuItem
            // 
            this.系统功能ToolStripMenuItem.BackColor = System.Drawing.Color.FloralWhite;
            this.系统功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新登录ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统功能ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.系统功能ToolStripMenuItem.Name = "系统功能ToolStripMenuItem";
            this.系统功能ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.系统功能ToolStripMenuItem.Text = "系统功能";
            // 
            // 重新登录ToolStripMenuItem
            // 
            this.重新登录ToolStripMenuItem.Name = "重新登录ToolStripMenuItem";
            this.重新登录ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.重新登录ToolStripMenuItem.Text = "重新登录";
            this.重新登录ToolStripMenuItem.Click += new System.EventHandler(this.重新登录ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.BackColor = System.Drawing.Color.FloralWhite;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "功   能   菜  单";
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.treeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.treeView1.Location = new System.Drawing.Point(0, 56);
            this.treeView1.Name = "treeView1";
            treeNode43.Name = "节点4";
            treeNode43.Text = "查询所有部门";
            treeNode44.Name = "节点5";
            treeNode44.Text = "查询部门下所有数据表";
            treeNode45.Name = "查询经理账号信息";
            treeNode45.Text = "查询经理账号信息";
            treeNode46.Name = "查询员工信息";
            treeNode46.Text = "查询员工账号信息";
            treeNode47.Name = "查询员工详细信息";
            treeNode47.Text = "查询员工详细信息";
            treeNode48.Name = "查询";
            treeNode48.Text = "查询";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode48});
            this.treeView1.Size = new System.Drawing.Size(192, 417);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(198, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 417);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-4, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "||欢迎使用成都裕锦公司信息管理系统|| ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(312, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "当前用户:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(459, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "总经理";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(436, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "总经理";
            // 
            // Top_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 519);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Top_Manager";
            this.Text = "裕景公司---总经理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Top_Manager_FormClosing);
            this.Load += new System.EventHandler(this.Top_Manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 共享区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看共享区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助说明ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}