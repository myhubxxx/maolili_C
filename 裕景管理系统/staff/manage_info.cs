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
using 裕景管理系统.Dao;
using DBCon1.Domain;
using DBCon1.Dao;

namespace 裕景管理系统.staff
{
    public partial class manage_info : Form
    {
        public manage_info()
        {
            InitializeComponent();
        }
        private void manage_info_Load(object sender, EventArgs e)
        {
            dostaff dst = new dostaff();
            UserInfo userinfo = new UserInfo();
            userinfo = dst.getuserinfo_list(ConstatData.login.username);
            dept_name.Text = userinfo.Dept;
            info_name.Text = userinfo.Name;
            info_sex.Text = userinfo.Sex;
            info_nation.Text = userinfo.Nation;
            info_xueli.Text = userinfo.Education;
            info_tele.Text = userinfo.Tele;
            info_jiguan.Text = userinfo.Birthplace;
            info_birthday.Text = userinfo.Birthday.ToString();
            info_idcard.Text = userinfo.Idcard;
            Info_zhiwu.Text = userinfo.Position;
            info_zhichengzheng.Text = userinfo.Zhichengcard;
            info_ssn.Text = userinfo.Ssn;
            info_zhiyezhuce.Text = userinfo.Zhiyezhuce;
            info_jiatingzhuzhi.Text = userinfo.Address;
            info_startworktime.Text = userinfo.Startworktime.ToString();
            info_joinworktime.Text = userinfo.Joinmycompanytime.ToString();
            info_biyeyuanxiao.Text = userinfo.Graduateschool;
            info_beizhu.Text = userinfo.Remark;
            textBox1.Text = userinfo.Id.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dostaff dst = new dostaff();
            dst.mdf(int .Parse (textBox1.Text), info_name.Text, info_sex.Text, dept_name.Text, info_nation.Text, info_jiguan.Text,
            DateTime.Parse(info_birthday.Text), DateTime.Parse(info_startworktime.Text), DateTime.Parse(info_joinworktime.Text), info_idcard.Text, Info_zhiwu.Text, info_zhiyezhuce.Text,
            info_biyeyuanxiao.Text, info_xueli.Text, info_jiatingzhuzhi.Text, info_ssn.Text, info_zhichengzheng.Text, info_beizhu.Text, info_tele.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
