namespace 裕景管理系统.administrator
{
    partial class manage_staffinfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.民族 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.籍贯 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出生年月 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.参工时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入公司时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证号码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职务 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学历 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.家庭住址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.社保号码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.执业注册 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.毕业院校 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职称证 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "裕锦公司--管理员工详细信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.姓名,
            this.部门,
            this.性别,
            this.电话,
            this.民族,
            this.籍贯,
            this.出生年月,
            this.参工时间,
            this.入公司时间,
            this.身份证号码,
            this.职务,
            this.学历,
            this.家庭住址,
            this.社保号码,
            this.执业注册,
            this.毕业院校,
            this.职称证,
            this.备注});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(7, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(886, 522);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(104, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(620, 584);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button3.Location = new System.Drawing.Point(357, 584);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "ID";
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
            this.姓名.Width = 70;
            // 
            // 部门
            // 
            this.部门.DataPropertyName = "dept";
            this.部门.HeaderText = "部门";
            this.部门.Name = "部门";
            this.部门.Width = 70;
            // 
            // 性别
            // 
            this.性别.DataPropertyName = "sex";
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            this.性别.Width = 30;
            // 
            // 电话
            // 
            this.电话.DataPropertyName = "tele";
            this.电话.HeaderText = "电话";
            this.电话.Name = "电话";
            // 
            // 民族
            // 
            this.民族.DataPropertyName = "nation";
            this.民族.HeaderText = "民族";
            this.民族.Name = "民族";
            this.民族.Width = 50;
            // 
            // 籍贯
            // 
            this.籍贯.DataPropertyName = "birthplace";
            this.籍贯.HeaderText = "籍贯";
            this.籍贯.Name = "籍贯";
            this.籍贯.Width = 80;
            // 
            // 出生年月
            // 
            this.出生年月.DataPropertyName = "birthday";
            this.出生年月.HeaderText = "出生年月";
            this.出生年月.Name = "出生年月";
            this.出生年月.Width = 80;
            // 
            // 参工时间
            // 
            this.参工时间.DataPropertyName = "startworktime";
            this.参工时间.HeaderText = "参工时间";
            this.参工时间.Name = "参工时间";
            this.参工时间.Width = 80;
            // 
            // 入公司时间
            // 
            this.入公司时间.DataPropertyName = "joinmycompanytime";
            this.入公司时间.HeaderText = "入公司时间";
            this.入公司时间.Name = "入公司时间";
            this.入公司时间.Width = 80;
            // 
            // 身份证号码
            // 
            this.身份证号码.DataPropertyName = "idcard";
            this.身份证号码.HeaderText = "身份证号码";
            this.身份证号码.Name = "身份证号码";
            this.身份证号码.Width = 180;
            // 
            // 职务
            // 
            this.职务.DataPropertyName = "positiono";
            this.职务.HeaderText = "职务";
            this.职务.Name = "职务";
            this.职务.Width = 80;
            // 
            // 学历
            // 
            this.学历.DataPropertyName = "education";
            this.学历.HeaderText = "学历";
            this.学历.Name = "学历";
            this.学历.Width = 40;
            // 
            // 家庭住址
            // 
            this.家庭住址.DataPropertyName = "addresso";
            this.家庭住址.HeaderText = "家庭住址";
            this.家庭住址.Name = "家庭住址";
            this.家庭住址.Width = 160;
            // 
            // 社保号码
            // 
            this.社保号码.DataPropertyName = "ssn";
            this.社保号码.HeaderText = "社保号码";
            this.社保号码.Name = "社保号码";
            // 
            // 执业注册
            // 
            this.执业注册.DataPropertyName = "zhiyezhuce";
            this.执业注册.HeaderText = "执业注册";
            this.执业注册.Name = "执业注册";
            // 
            // 毕业院校
            // 
            this.毕业院校.DataPropertyName = "graduateschool";
            this.毕业院校.HeaderText = "毕业院校";
            this.毕业院校.Name = "毕业院校";
            // 
            // 职称证
            // 
            this.职称证.DataPropertyName = "zhichengcard";
            this.职称证.HeaderText = "职称证";
            this.职称证.Name = "职称证";
            this.职称证.Width = 120;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "remark";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            // 
            // manage_staffinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "manage_staffinfo";
            this.Text = "裕锦公司--管理员工信息";
            this.Load += new System.EventHandler(this.manage_staffinfo_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 民族;
        private System.Windows.Forms.DataGridViewTextBoxColumn 籍贯;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出生年月;
        private System.Windows.Forms.DataGridViewTextBoxColumn 参工时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入公司时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职务;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学历;
        private System.Windows.Forms.DataGridViewTextBoxColumn 家庭住址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 社保号码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 执业注册;
        private System.Windows.Forms.DataGridViewTextBoxColumn 毕业院校;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职称证;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}