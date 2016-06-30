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
    public partial class add_table : Form
    {
        public add_table()
        {
            InitializeComponent();
        }
        private MyDatabase table = new MyDatabase();
        private List<string> typeList = new List<string>();
        private void add_table_Load(object sender, EventArgs e)
        {
            typeList.AddRange
                (
                    new[]{
                       "Int",
                        "Varchar",
                        "NVarChar",
                        "Float",
                        "datetime"
                    }
                );
            DataGridViewComboBoxColumn cbx = new DataGridViewComboBoxColumn();
            cbx.Name =ShareLib.Combox_Name;
            cbx.DataSource = typeList;
            this.dataGridView1.Columns.Insert(1, cbx);
            DoManager domanager = new DoManager();
            List<Department> dept = new List<Department>();
            dept = domanager.getalldept_list();
            comboBox1.DataSource = dept.Select(a => a.Dept_name).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool error = false;
            table.TableName = textBox1.Text;
            DoManager domanager = new DoManager();
            if (MessageBox.Show(ShareLib.Comfoirm_Info, ShareLib.Notification, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show(ShareLib.Notify_Add_TabName, ShareLib.Notification);
                    return;
                }
                //check totaltable whether have tables if no ,just add directly
                if(!domanager.check_department_totaltable(comboBox1.SelectedItem.ToString()))
                {
                    for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                    {
                        if (!table.Columns.Any(a => a.Key == i))
                        {
                            var name = dataGridView1.Rows[i].Cells[0].Value;
                            var type = dataGridView1.Rows[i].Cells[1].Value;
                            if (name != null && type != null)
                            {
                                if (!string.IsNullOrWhiteSpace(name.ToString()) &&
                                    !string.IsNullOrWhiteSpace(type.ToString()))
                                {
                                    table.Columns.Add(new DBTableField() { Key = i, FieldName = name.ToString(), Type = type.ToString() });
                                }
                                else
                                {
                                    error = true;
                                    MessageBox.Show(string.Concat(ShareLib.Add_Table_notif, (i + 1).ToString(),ShareLib.Row_Content),ShareLib.Notification);
                                    break;
                                }
                            }
                            else if (type == null && name != null && !string.IsNullOrEmpty(name.ToString()))
                            {
                                error = true;
                                MessageBox.Show(string.Concat(ShareLib.Add_Table_notif, (i + 1).ToString(), ShareLib.Feild_Type),ShareLib.Notification);
                                break;
                            }
                            else if (type != null && name == null)
                            {
                                error = true;
                                MessageBox.Show(string.Concat(ShareLib.Add_Table_notif, (i + 1).ToString(), ShareLib.Feild_Name),ShareLib.Notification);
                                break;
                            }
                        }
                    }
                    if (error)  return;   
                    table.DBName = comboBox1.Text;
                    if (AccessOp.CreateAccessTab(table))
                    {
                        MessageBox.Show(ShareLib.Add_Table_Success);
                    }
                    else
                    {
                        MessageBox.Show(ShareLib.Add_Table_Faild);
                    }
                }
                else
                {
                    //or check if  the tablename has been added 
                if (domanager.checktablename(comboBox1.Text, textBox1.Text))
                {
                    for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                    {
                        if (!table.Columns.Any(a => a.Key == i))
                        {
                            var name = dataGridView1.Rows[i].Cells[0].Value;
                            var type = dataGridView1.Rows[i].Cells[1].Value;
                            if (name != null && type != null)
                            {
                                if (!string.IsNullOrWhiteSpace(name.ToString()) &&
                                    !string.IsNullOrWhiteSpace(type.ToString()))
                                {
                                    table.Columns.Add(new DBTableField() { Key = i, FieldName = name.ToString(), Type = type.ToString() });
                                }
                                else
                                {
                                    error = true;
                                    MessageBox.Show(string.Concat(ShareLib.Add_Table_notif, (i + 1).ToString(), ShareLib.Row_Content), ShareLib.Notification);
                                    break;
                                }
                            }
                            else if (type == null && name != null && !string.IsNullOrEmpty(name.ToString()))
                            {
                                error = true;
                                MessageBox.Show(string.Concat(ShareLib.Add_Table_notif, (i + 1).ToString(), ShareLib.Feild_Type), ShareLib.Notification);
                                break;
                            }
                            else if (type != null && name == null)
                            {
                                error = true;
                                MessageBox.Show(string.Concat(ShareLib.Add_Table_notif, (i + 1).ToString(),ShareLib.Feild_Name),ShareLib.Notification);
                                break;
                            }
                        }
                    }
                    if (error)return; 
                    table.DBName = comboBox1.Text;
                    if (AccessOp.CreateAccessTab(table))
                    {
                        MessageBox.Show(ShareLib.Add_Table_Success);
                    }
                    else
                    {
                        MessageBox.Show(ShareLib.Add_Table_Faild);
                    }
                }
                else
                {
                    MessageBox.Show(ShareLib.Table_Has_Exsist_notifi +textBox1.Text.Trim()+ ShareLib.Notifi_Add_NewName);
                }
            }
            }
            else
            {
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.admin.Show();
            this.Close();
        }
    }
}
