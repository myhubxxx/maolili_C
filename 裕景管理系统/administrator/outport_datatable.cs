using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 裕景管理系统.Domain;
using DBCon1.test_dao;
using DBCon1.Dao;
using DBCon1.Domain;

namespace 裕景管理系统.administrator
{
    public partial class outport_datatable : Form
    {
        public outport_datatable()
        {
            InitializeComponent();
        }
        private void outport_datatable_Load(object sender, EventArgs e)
        {
            DoManager domanager = new DoManager();
            List<Department> list = domanager.getalldept_list();
            comboBox1.DataSource = list.Select(a => a.Dept_name).ToList();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              DoManager domanager = new DoManager();
            if(domanager.check_department_totaltable(comboBox1.SelectedItem.ToString()))
            {
                string dbname = comboBox1.Text;
                List<TotalTable> tables = domanager.get_alltable_list(dbname);
                comboBox2.DataSource = tables.Select(a => a.Tablename).ToList();
            }
            else
            {
                MessageBox.Show(ShareLib.Dept_No_Table);
                comboBox2.DataSource = null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
           // sfd.Filter = ShareLib.Type;
            sfd.FileName = comboBox2.Text+".xlsx";
               

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString();
                ImportExcel ie = new ImportExcel();
                ie.Export(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), localFilePath);
                MessageBox.Show("导出成功");
            }
            else
            {
                return;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.admin.Show();
            this.Close();
        }
    }
}
