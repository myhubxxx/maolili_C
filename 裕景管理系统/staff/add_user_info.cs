using DBCon1.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 裕景管理系统.administrator;
using 裕景管理系统.Domain;

namespace 裕景管理系统.staff
{
    public partial class add_user_info : Form
    {
        public add_user_info()
        {
            InitializeComponent();
        }
        private void add_user_info_Load(object sender, EventArgs e)
        {
            DoManager domanager = new DoManager();
            List<Department> list = domanager.getalldept_list();
            comboBox1.DataSource = list.Select(a => a.Dept_name).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dostaff DST = new dostaff();
                string dbnae = comboBox1.SelectedItem.ToString();
                string name = textBox2.Text;
                string nation = textBox1.Text;
                string xueli = textBox5.Text;
                string tele = textBox6.Text;
                string jiguan = textBox3.Text;
                string idcard = textBox4.Text;
                string zhiwu = textBox9.Text;
                string zhiochengzheng = textBox11.Text;
                string ssn = textBox8.Text;
                string zhiyezhuce = textBox12.Text;
                string sex;
                string jaitingzhizhi = textBox10.Text;
                string biyeyuanxiao = textBox7.Text;
                string beizhu = textBox13.Text;
                if (radioButton1.Checked)
                {
                    sex = radioButton1.Text;
                }
                else
                {
                    sex = radioButton2.Text;
                }
                DateTime birthday = DateTime.Parse(dateTimePicker1.Text);
                DateTime startwork = DateTime.Parse(dateTimePicker2.Text);
                DateTime joincompay = DateTime.Parse(dateTimePicker3.Text);
                DST.addinfo(ConstatData.login.username, name, sex, dbnae, nation, jiguan, birthday, startwork, joincompay, idcard, zhiwu, zhiyezhuce, biyeyuanxiao, xueli, jaitingzhizhi, ssn, zhiochengzheng, beizhu,tele);
                MessageBox.Show(ShareLib.Add_User_Info_Success);
            }
            catch(Exception)
            {
                MessageBox.Show(ShareLib.Add_Info_Failed);
            }
        }
    }
}
