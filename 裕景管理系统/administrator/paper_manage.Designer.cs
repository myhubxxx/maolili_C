namespace 裕景管理系统.administrator
{
    partial class paper_manage
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.岗位证类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.岗位证专业 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.岗位证级别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.岗位证备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.领证时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.继续教育时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.提前提醒时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职称证书级别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职称证书专业 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.压证施工情况及项目名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.投标占用情况____项目名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.投标占用情况____预计解锁时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.社保情况 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(350, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工证书管理情况表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.姓名,
            this.岗位证类别,
            this.岗位证专业,
            this.岗位证级别,
            this.岗位证备注,
            this.领证时间,
            this.继续教育时间,
            this.提前提醒时间,
            this.职称证书级别,
            this.职称证书专业,
            this.压证施工情况及项目名称,
            this.投标占用情况____项目名称,
            this.投标占用情况____预计解锁时间,
            this.社保情况});
            this.dataGridView1.Location = new System.Drawing.Point(3, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(878, 418);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "id";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Width = 30;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "uname";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.Width = 80;
            // 
            // 岗位证类别
            // 
            this.岗位证类别.DataPropertyName = "gwz_catory";
            this.岗位证类别.HeaderText = "资格证类别";
            this.岗位证类别.Name = "岗位证类别";
            // 
            // 岗位证专业
            // 
            this.岗位证专业.DataPropertyName = "gwz_major";
            this.岗位证专业.HeaderText = "资格证专业";
            this.岗位证专业.Name = "岗位证专业";
            this.岗位证专业.Width = 80;
            // 
            // 岗位证级别
            // 
            this.岗位证级别.DataPropertyName = "gwz_level";
            this.岗位证级别.HeaderText = "资格证级别";
            this.岗位证级别.Name = "岗位证级别";
            this.岗位证级别.Width = 70;
            // 
            // 岗位证备注
            // 
            this.岗位证备注.DataPropertyName = "gwz_remark";
            this.岗位证备注.HeaderText = "资格证备注";
            this.岗位证备注.Name = "岗位证备注";
            this.岗位证备注.Width = 80;
            // 
            // 领证时间
            // 
            this.领证时间.DataPropertyName = "lz_date";
            this.领证时间.HeaderText = "领证时间";
            this.领证时间.Name = "领证时间";
            // 
            // 继续教育时间
            // 
            this.继续教育时间.DataPropertyName = "continue_edu";
            this.继续教育时间.HeaderText = "继续教育时间";
            this.继续教育时间.Name = "继续教育时间";
            // 
            // 提前提醒时间
            // 
            this.提前提醒时间.DataPropertyName = "pre_day";
            this.提前提醒时间.HeaderText = "提前提醒时间(60天）";
            this.提前提醒时间.Name = "提前提醒时间";
            this.提前提醒时间.Width = 50;
            // 
            // 职称证书级别
            // 
            this.职称证书级别.DataPropertyName = "zc_level";
            this.职称证书级别.HeaderText = "职称证书级别";
            this.职称证书级别.Name = "职称证书级别";
            // 
            // 职称证书专业
            // 
            this.职称证书专业.DataPropertyName = "zc_major";
            this.职称证书专业.HeaderText = "职称证书专业";
            this.职称证书专业.Name = "职称证书专业";
            // 
            // 压证施工情况及项目名称
            // 
            this.压证施工情况及项目名称.DataPropertyName = "remark";
            this.压证施工情况及项目名称.HeaderText = "压证施工情况及项目名称";
            this.压证施工情况及项目名称.Name = "压证施工情况及项目名称";
            this.压证施工情况及项目名称.Width = 140;
            // 
            // 投标占用情况____项目名称
            // 
            this.投标占用情况____项目名称.DataPropertyName = "tb_project";
            this.投标占用情况____项目名称.HeaderText = "投标占用情况____项目名称";
            this.投标占用情况____项目名称.Name = "投标占用情况____项目名称";
            // 
            // 投标占用情况____预计解锁时间
            // 
            this.投标占用情况____预计解锁时间.DataPropertyName = "tb_lock_time";
            this.投标占用情况____预计解锁时间.HeaderText = "投标占用情况____预计解锁时间";
            this.投标占用情况____预计解锁时间.Name = "投标占用情况____预计解锁时间";
            this.投标占用情况____预计解锁时间.Width = 80;
            // 
            // 社保情况
            // 
            this.社保情况.DataPropertyName = "ssn";
            this.社保情况.HeaderText = "社保情况";
            this.社保情况.Name = "社保情况";
            this.社保情况.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(649, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "关闭";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // paper_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(885, 550);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "paper_manage";
            this.Text = "裕锦公司---证件管理情况表";
            this.Load += new System.EventHandler(this.paper_manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 岗位证类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 岗位证专业;
        private System.Windows.Forms.DataGridViewTextBoxColumn 岗位证级别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 岗位证备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn 领证时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 继续教育时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 提前提醒时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职称证书级别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职称证书专业;
        private System.Windows.Forms.DataGridViewTextBoxColumn 压证施工情况及项目名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 投标占用情况____项目名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 投标占用情况____预计解锁时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 社保情况;
    }
}