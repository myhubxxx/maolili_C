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
using DBCon1.Domain;
using DBCon1.Dao;
using 裕景管理系统.administrator;
using 裕景管理系统.manager;
using 裕景管理系统.staff;
using 裕景管理系统.top_Manager;
namespace 裕景管理系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string username
        {
          get { return textBox1.Text; }
        }
        public string userpwd
        {
            get { return textBox2.Text; }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ConstatData.login = this;
            comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(ShareLib.LOGIN_INPUT_NULL);
            }
            else
            {
                dologic dologicadmin = new dologic();
                if (comboBox1.Text == ShareLib.Admin)
                {
                    Dictionary<string, string> map = dologicadmin.getadmin(textBox1.Text);
                    try
                    {
                        if (map["uname"] == null)
                        {
                           MessageBox.Show(ShareLib.Role_Error);
                        }
                        else
                        {
                            if (map["upass"] == textBox2.Text)
                            {
                                if (map["adminlevel"] == "1")
                                {
                                    admin admin = new administrator.admin();
                                    admin.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    Top_Manager tm = new Top_Manager();
                                    tm.Show();
                                    this.Hide();

                                }
                            }
                            else
                            {
                                MessageBox.Show(ShareLib.Pwd_Error);
                            }
                        }
                    }
                    catch (Exception )
                    {
                      MessageBox.Show(ShareLib.Username_Error);
                    }
                }
                else
                {
                    MyUser user = dologicadmin.getuser(textBox1.Text);
                    if (user == null)
                    {
                        MessageBox.Show(ShareLib.Username_Error);
                    }
                    else
                    {
                        if (user.Upass == textBox2.Text)
                        {
                            switch(user.Userlevel)
                            {
                                case 0:
                                    {
                                        Staff_index st = new Staff_index();
                                        st.Show();
                                        this.Hide();
                                    }
                                    break;
                                case 1:
                                    {
                                        Manager manger = new Manager();
                                        manger.Show();
                                        this.Hide();
                                    }
                                    break;
                                default:
                                    MessageBox.Show(ShareLib.Unknow_Level);
                                    break; 
                            }
                        }
                        else
                        {
                           MessageBox.Show(ShareLib.Error);
                        }
                    }
                }
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(ShareLib.AsureMess, ShareLib.SystemInform, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ConstatData.FormClose();
            }
            else
                e.Cancel = true;
        }
    }
}
