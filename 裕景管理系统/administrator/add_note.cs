using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 裕景管理系统.manager;
using 裕景管理系统.Domain;
namespace 裕景管理系统.administrator
{
    public partial class add_note : Form
    {
        public add_note()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(richTextBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show(ShareLib.Note_Not_Complete);
            }
            else
            {
                DoManager domanger = new DoManager();
            //check if the admin has add the same title
                if (domanger.check_manager_note(ConstatData.login.username, textBox1.Text))
                {
                    domanger.add_note(ConstatData.login.username, textBox1.Text, richTextBox1.Text, DateTime.Parse(dateTimePicker1.Text), int.Parse(textBox2.Text));
                    MessageBox.Show(ShareLib.Note_Add_Success);
                }
                else
                {
                    MessageBox.Show(ShareLib.Note_Title_Exsist);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void add_note_Load(object sender, EventArgs e)
        {
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;// make sure it can only accept number not string and other
            }
        }
    }
}
