using DBCon1.test_dao;
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
    public partial class add_dept_table : Form
    {
        public add_dept_table()
        {
            InitializeComponent();
        }
        private MyDatabase table = new MyDatabase();
        private List<string> typeList = new List<string>();
        private void add_dept_table_Load(object sender, EventArgs e)
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
             bool error = false;
            table.TableName = textBox1.Text;
         DoRrealManager drm=new DoRrealManager ();

         if (MessageBox.Show(ShareLib.Comfoirm_Info, ShareLib.Notification, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
         {
             if (string.IsNullOrEmpty(textBox1.Text))
             {
                 MessageBox.Show(ShareLib.Notify_Add_TabName,ShareLib.Notification);
                 return;
             }
             if (!drm.check_department_totaltable(ConstatData.department.Dept_name))
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
                                 MessageBox.Show(string.Concat(ShareLib.Add_Table_notif, (i + 1).ToString(),ShareLib.Row_Content), ShareLib.Notification);
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
                 if (error)
                     return;
                 table.DBName = ConstatData.department.Dept_name;
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



                 if (drm.checktablename(ConstatData.department.Dept_name, textBox1.Text))
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
                                     MessageBox.Show(string.Concat("请填写完整第", (i + 1).ToString(), "行的内容"), "提示");
                                     break;
                                 }
                             }
                             else if (type == null && name != null && !string.IsNullOrEmpty(name.ToString()))
                             {
                                 error = true;
                                 MessageBox.Show(string.Concat("请填写第", (i + 1).ToString(), "行的字段类型"), "提示");
                                 break;
                             }
                             else if (type != null && name == null)
                             {
                                 error = true;
                                 MessageBox.Show(string.Concat("请填写第", (i + 1).ToString(), "行的字段名称"), "提示");
                                 break;
                             }
                         }
                     }
                     if (error)
                         return;
                     table.DBName = ConstatData.department.Dept_name;
                     if (AccessOp.CreateAccessTab(table))
                     {
                         MessageBox.Show("数据表添加成功");
                     }
                     else
                     {
                         MessageBox.Show("数据表添加失败");
                     }
                 }
                 else
                 {
                     MessageBox.Show("该部门已经有" + textBox1.Text.Trim() + "这张表，请重新输入表格名称");

                 }
             }
         }
         else
         {

         }
        
              

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConstatData.manager.Show();
            this.Hide();
        }
    }
}
    

