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
namespace 裕景管理系统.manager
{
    public partial class add_notes : Form
    {
        public add_notes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(richTextBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("请将信息填写完整再提交");

            }
            else
            { DoRrealManager drm = new DoRrealManager();

            if (drm.check_notes(ConstatData.login.username, textBox1.Text))
            {
                drm.add_notes(ConstatData.login.username, textBox1.Text, richTextBox1.Text, DateTime.Parse(dateTimePicker1.Text), int.Parse(textBox2.Text));
                MessageBox.Show("添加成功");
            }
            else
            {

                MessageBox.Show("对不起，您添加的标题已经存在");
            }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;

            }
         
        }

        private void add_notes_Load(object sender, EventArgs e)
        {

        }
    }
}
