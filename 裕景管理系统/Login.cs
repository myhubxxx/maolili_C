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
                if (comboBox1.Text == "管理员")
                {
                    Dictionary<string, string> map = dologicadmin.getadmin(textBox1.Text);
                    try
                    {
                        if (map["uname"] == null)
                        {
                            MessageBox.Show("对不起，您的身份选择错误，请重新选择");
                        }
                        else
                        {
                            if (map["upass"] == textBox2.Text)
                            {
                                //this.Hide();
                                admin admin = new administrator.admin();

                                admin.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("密码错误请重新输入");
                            }
                        }
                    }
                    catch (Exception )
                    {
                        MessageBox.Show("账号有误,请重新输入");
                    }
                }
                else
                {
                    MyUser user = dologicadmin.getuser(textBox1.Text);
                    if (user == null)
                    {
                        MessageBox.Show("unknown account!");
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
                                    MessageBox.Show("Unknown access level!");
                                    break;
                                        
                            }
                        }
                        else
                        {
                            MessageBox.Show("密码或账号错误请重新输入");
                        }
                    }
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认退出程序?", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ConstatData.FormClose();
            }
            else
                e.Cancel = true;//取消退出事件
        }
           
           
        
    }
}
