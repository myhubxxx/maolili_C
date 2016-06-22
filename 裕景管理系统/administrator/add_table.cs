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
            
            cbx.Name = "类型";
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
            if (MessageBox.Show("确定添加?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("请填写要创建的表名", "提示");
                    return;
                }
               
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
                    table.DBName = comboBox1.Text;
                    if (AccessOp.CreateAccessTab(table))
                    {
                        MessageBox.Show("数据表添加成功");
                    }
                    else
                    {
                        MessageBox.Show("数据表添加失败");
                    }

                }
                else{
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
                    table.DBName = comboBox1.Text;
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
                    MessageBox.Show("该部门已经有" +textBox1.Text.Trim()+ "这张表，请重新输入表格名称");

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
