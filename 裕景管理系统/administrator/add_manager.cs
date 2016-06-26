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
    public partial class add_manager : Form
    {
        public add_manager()
        {
            InitializeComponent();
        }

        private void add_manager_Load(object sender, EventArgs e)
        {
            DoManager domanager = new DoManager();
            List<Department> dept = new List<Department>();
            dept = domanager.getalldept_list();
            comboBox1.DataSource = dept.Select(a => a.Dept_name).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DoManager domanager = new DoManager();
            if (domanager.checkmanager(textBox1.Text, textBox2.Text))
            {
                domanager.add_manager(textBox1.Text, textBox2.Text, comboBox1.Text);
                MessageBox.Show(ShareLib.Add_Manger_sccess);
            }
            else
            {
                MessageBox.Show(ShareLib.Manager_Username_Exsist);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.admin.Show();
            this.Close();
        }
    }
}
