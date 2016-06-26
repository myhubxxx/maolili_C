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
using 裕景管理系统.administrator;
using System.IO;
using 裕景管理系统.staff;

namespace 裕景管理系统.manager
{
    public partial class M_output_table : Form
    {
        public M_output_table()
        {
            InitializeComponent();
        }

        private void M_output_table_Load(object sender, EventArgs e)
        {
            DoManager domanager = new DoManager();
            if (domanager.check_department_totaltable(ConstatData.department.Dept_name))
            {
                List<TotalTable> list = domanager.get_alltable_list(ConstatData.department.Dept_name);
                comboBox1.DataSource = list.Select(a => a.Tablename).ToList();
            }
            else
            {
                MessageBox.Show(ShareLib.Dept_No_Table);
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
          
            sfd.FileName = comboBox1.Text+".xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString();
                ImportExcel ie = new ImportExcel();
                ie.Export(ConstatData.department.Dept_name, comboBox1.SelectedItem.ToString(), localFilePath);
                MessageBox.Show("导出成功");
            }
            else
            {
                return;
            }
        }
    }
}
