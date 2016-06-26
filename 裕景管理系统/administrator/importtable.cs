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
    public partial class importtable : Form
    {
        public importtable()
        {
            InitializeComponent();
        }
        private void importtable_Load(object sender, EventArgs e)
        {
            DoManager domanager = new DoManager();
            List<Department> dept = domanager.getalldept_list();
            comboBox1.DataSource = dept.Select(a => a.Dept_name).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Application.StartupPath;
            file.Filter = null;
            if (file.ShowDialog() == DialogResult.OK)
            {DoManager domanager=new DoManager ();
                string filename = file.FileName;
                string dbname = comboBox1.SelectedItem.ToString();
                try
                {
                    ImportExcel ie = new ImportExcel();
                    try
                    {
                        ie.importExcelAllTable(dbname, filename);
                    }catch(Exception){
                        MessageBox.Show(ShareLib.Importtable_Name_Include_Space);
                    }
                    MessageBox.Show("导入成功");
                }
                catch (Exception)
                {
                    MessageBox.Show(ShareLib.Importtable_has_exsist);
                }
               
            }
            else
            {
                return;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.admin.Show();
        }
    }
}
