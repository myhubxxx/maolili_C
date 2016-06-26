namespace 裕景管理系统.top_Manager
{
    partial class TM_search_staffinfomation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.部门});
            this.dataGridView1.Location = new System.Drawing.Point(41, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(474, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "ID";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            // 
            // 部门
            // 
            this.部门.DataPropertyName = "dept_name";
            this.部门.HeaderText = "部门";
            this.部门.Name = "部门";
            // 
            // TM_search_staffinfomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 453);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TM_search_staffinfomation";
            this.Text = "TM_search_staffinfomation";
            this.Load += new System.EventHandler(this.TM_search_staffinfomation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门;
    }
}