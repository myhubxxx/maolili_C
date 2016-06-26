namespace 裕景管理系统.manager
{
    partial class manage_notes
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
            this.用户ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.标题 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.到期时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.提前提醒天数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(295, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "查看并管理备忘录";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.用户ID,
            this.标题,
            this.内容,
            this.到期时间,
            this.提前提醒天数});
            this.dataGridView1.Location = new System.Drawing.Point(-4, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(752, 319);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(132, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(337, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button3.Location = new System.Drawing.Point(548, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "关闭";
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
            // 用户ID
            // 
            this.用户ID.DataPropertyName = "userId";
            this.用户ID.HeaderText = "用户ID";
            this.用户ID.Name = "用户ID";
            this.用户ID.ReadOnly = true;
            this.用户ID.Width = 30;
            // 
            // 标题
            // 
            this.标题.DataPropertyName = "title";
            this.标题.HeaderText = "标题";
            this.标题.Name = "标题";
            this.标题.Width = 250;
            // 
            // 内容
            // 
            this.内容.DataPropertyName = "content";
            this.内容.HeaderText = "内容";
            this.内容.Name = "内容";
            this.内容.Width = 300;
            // 
            // 到期时间
            // 
            this.到期时间.DataPropertyName = "endTime";
            this.到期时间.HeaderText = "到期时间";
            this.到期时间.Name = "到期时间";
            // 
            // 提前提醒天数
            // 
            this.提前提醒天数.DataPropertyName = "beforeDay";
            this.提前提醒天数.HeaderText = "提前提醒天数";
            this.提前提醒天数.Name = "提前提醒天数";
            this.提前提醒天数.Width = 70;
            // 
            // manage_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(760, 484);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "manage_notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "裕锦公司--管理备忘录";
            this.Load += new System.EventHandler(this.manage_notes_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 标题;
        private System.Windows.Forms.DataGridViewTextBoxColumn 内容;
        private System.Windows.Forms.DataGridViewTextBoxColumn 到期时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 提前提醒天数;
    }
}