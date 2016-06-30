using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBCon1.Domain;
using 裕景管理系统.staff;
using 裕景管理系统.Domain;
using 裕景管理系统.administrator;
using 裕景管理系统.manager;
using 裕景管理系统.top_Manager;
namespace 裕景管理系统.Domain
{
   public class ConstatData
    {/*
   
       /// <summary>
       /// 部门信息
       /// </summary>
       public static Department department { get; set; }
       /// <summary>
       /// myuser信息
       /// </summary>
       //public static MyUser useruser { get; set; }
       /// <summary>
       /// 内存中的Form1对象
       /// </summary>
       public static Form1 form1 { get; set; }
       public static string username { get; set; }
       public static string pwd { get; set; }
       /// <summary>
       /// 内存中的Form2对象
       /// </summary>
     //  public static form2 form2 { get; set; }
       public static Form27 form27 { get; set; }
       public static string DBName { get; set; }
       public static string tbName { get; set; }


       //内存中form17的对象
       public static Form17 form17 { get; set; }
     
      public static Department pdepartment { get; set; }//普通员工进入时的部门名字

       //内存中form4的对象
      public static Form4 form4 { get; set; }
       //内存中form9的对象
    //  public static Form9 form9 { get; set; }
    //  public static string dabsname { get; set; }

       //form20中的对象
      public static Form20 form20 { get; set; }
      public static string combox { get; set; }
       /// <summary>
       /// 彻底关闭程序
       /// </summary>
       /// 

       public static void FormClose()
       {
           System.Environment.Exit(0);
       }
 */

        /// <summary>
        /// 管理员首页
        /// </summary>
        /// 
       public static admin admin { get; set; }





       /// <summary>
       /// login中的账号密码信息
       /// </summary>
       public static Login login { get; set; }
       public static string username { get; set; }
       public static string userpwd { get; set; }


       /// <summary>
       /// 保存选定的部门
       /// </summary>
       ///
       public static dept_datainfo dept_info { get; set; }
       public static string dbname { get; set; }
       public static string tbname { get; set; }

       ///<summary>
       ///保存要删除的部门
       ///</summary>
       ///
       public static delete_department dele_dept { get; set; }
       public static string dele_dept_name { get; set; }


       // onabove are object for admin,below are object for manager

       ///部门经理登录主页
       ///
       public static Manager manager{get;set;}
       
       
     
       ///员工登录首页
       ///
       public static Staff_index staff { get; set; }


       /// <summary>
       /// 部门信息
       /// </summary>
       public static Department department { get; set; }


       public static table_query tab_query { get; set; }
       public static string DEPART_NAME { get; set; }
       public static string ck_name { get; set; }

       public static datainfo_manage dataInfo_Manage { get; set; }
       public static string M_ck_tbname { get; set; }


       public static TM_table_query TM_TB { get; set; }
       public static string TM_deptname { get; set; }
       public static string TM_tbname { get; set; }

       /// <summary>
       /// 关闭程序并结束进程
       /// </summary>
       public static void FormClose()
       {
           System.Environment.Exit(0);
       }

    }
}
