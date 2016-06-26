using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace 裕景管理系统.class_test
{
    public partial class Form1 : Form
    {
        List<string> list;
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.CheckBoxes = true;
            listView1.Columns.Add("name", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("age", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("country", -2, HorizontalAlignment.Center);
            ListViewItem item1 = new ListViewItem(new string[] { "mitja", "28", "Slovenia" });
            ListViewItem item2 = new ListViewItem(new string[] { "john", "29", "USA" });
            ListViewItem item3 = new ListViewItem(new string[] { "sara", "22", "Germany" });
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            list = new List<string>();
            //I will put the names and ages into the list where tick is added:
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Checked)
                    list.Add("NAME: " + listView1.Items[i].Text + "  -  " + "AGE: " + listView1.Items[i].SubItems[1].Text);
            }
            if (list.Count > 0)
            {
                //showing the names:
                string names = null;
                foreach (string name in list)
                    names += name + Environment.NewLine;
                MessageBox.Show("Selected names are:\n\n" + names);
            }
            else
                MessageBox.Show("No names selected.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
