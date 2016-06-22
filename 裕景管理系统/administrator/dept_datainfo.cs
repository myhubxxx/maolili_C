using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBCon1.test_dao;
using DBCon1.Dao;
using DBCon1.Domain;

using System.Data.OleDb;
using 裕景管理系统.Domain;

namespace 裕景管理系统.administrator
{
    public partial class dept_datainfo : Form
    {
        public dept_datainfo()
        {
            InitializeComponent();
        }
        private DataSet ds = null;
        private System.Data.OleDb.OleDbDataAdapter da = null;
        public string dbname
        {

            get { return comboBox1.SelectedItem.ToString(); }
        }
        public string tbname
        {

            get { return comboBox2.SelectedItem.ToString(); }

        }
        private void dept_datainfo_Load(object sender, EventArgs e)
        {
            ConstatData.dept_info = this;
            DoManager domanager = new DoManager();
            List<Department> list = domanager.getalldept_list();
            comboBox1.DataSource = list.Select(a => a.Dept_name).ToList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string db = comboBox1.SelectedItem.ToString(); 
            DateTime t1 = DateTime.Parse(dateTimePicker1.Text);
            DateTime t2 = DateTime.Parse(dateTimePicker2.Text);
            DoManager domanager = new DoManager();

            try
            {
                List<TotalTable> alltable = domanager.getalltable_list(db, t1, t2);
                comboBox2.DataSource = alltable.Select(a => a.Tablename).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("开始时间不能大于结束时间");


            }
         


        }

        private void button1_Click(object sender, EventArgs e)
        {     
            ConstatData.tbname = comboBox2.Text;
            ConstatData.dbname = comboBox1.Text;
            dataGridView1.RowsDefaultCellStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.BurlyWood;

            try
            {
                DoManager domanager = new DoManager();
                OleDbDataAdapter da = new OleDbDataAdapter();
                this.ds = domanager.gettableds(ConstatData.dbname, ConstatData.tbname);
                da = domanager.gettableda(ConstatData.dbname, ConstatData.tbname);

                dataGridView1.DataSource = ds.Tables[ConstatData.tbname];
            }
            catch (Exception ex)
            {
                MessageBox.Show("该部门还未创建任何数据表");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //karas: i suggest we don't call DB function in this layer.
            DoManager domanager = new DoManager();
            OleDbDataAdapter da = domanager.gettableda(ConstatData.dbname, ConstatData.tbname);
            da.Update(ds,ConstatData.tbname);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConstatData.admin.Show();
            this.Hide();
        }
    }
}
