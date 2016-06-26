using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 裕景管理系统.administrator
{
    public partial class show : Form
    {
        public show()
        {
            InitializeComponent();
        }

        private void show_Load(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory()+"\\Share";

            //karas TO DO: exception 
            DirectoryInfo dinfo = new DirectoryInfo(path);
            FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
            listView1.ForeColor = Color.BlueViolet;
            listView1.Font = new Font("楷体_GB2312", 13);
           
            foreach (FileSystemInfo fs in fsinfos)
            {
                if (fs is DirectoryInfo)
                {
                    DirectoryInfo dirinfo = new DirectoryInfo(fs.FullName);
                    listView1.Items.Add(dirinfo.Name);
                   
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dirinfo.FullName);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add("");
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(dirinfo.CreationTime.ToShortDateString());

                }
                else
                {
                    FileInfo finfo = new FileInfo(fs.FullName);
                    listView1.Items.Add(finfo.Name);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(finfo.FullName);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(finfo.Length.ToString());
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(finfo.CreationTime.ToShortDateString());
                  
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string filename = listView1.SelectedItems[0].Text;
            string houzui = filename.Substring(0, filename.LastIndexOf("."));
            string hh = filename.Substring(houzui.Length);
            sfd.Filter = "所有文件(*" + hh + ")|*" + hh + "";
            string acuratepath = System.IO.Directory.GetCurrentDirectory()+"\\Share\\" + filename;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString();
                try
                {
                    File.Copy(acuratepath, localFilePath);
                }
                catch (Exception ex)
                {
                    ShareLib.Instance().HandleExcption(ex);
                }
                
            }
            else
            {
                return;
            }
        }
    }
}
