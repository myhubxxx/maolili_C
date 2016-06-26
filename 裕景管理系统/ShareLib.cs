using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace 裕景管理系统
{
    class ShareLib
    {
        private ShareLib()
        {
        }

        public static ShareLib Instance()
        {
            return mySelf;
        }
        // exception handle
        public void HandleExcption(Exception ex)
        {
            Debug.Assert(false, "%s", ex.ToString());

            switch(ex.GetType().ToString())
            {
                case "syste.KeyNotFoundException":
                    break;
                case "System.IO.DirectoryNotFoundException":
                    break;
                default:
                    //unhandle error ex.GetType().ToString(),please contact dev team. 
                    break;
            }
        }  
     

        //pulibc string
        //Login:
        //role
        public const string Admin = "管理员";
        public const string LOGIN_INPUT_NULL = "账号或密码不能为空";
        public const string Role_Error = "对不起，您的角色选择错误，请重新选择";
        public const string Pwd_Error = "密码错误请重新输入";
        public const string Username_Error = "账号有误,请重新输入";
        public const string Unknow_Nsername = "未知账号";
        public const string Unknow_Level = "未知角色";
        public const string Error ="密码或账号错误请重新输入";
        public const string AsureMess = "确认退出程序?";
        public const string SystemInform = "系统提示";
        public const string HAVE_NO_ACCESS = "未获取到相应的权限";
        //end

        //Administrator:
        //Add department
        public const string Add_Success = "部门创建成功";
        public const string Dept_Has_Exsist = "部门已经存在，请重新添加";
        //Add Manager
        public const string Add_Manger_sccess = "部门经理添加成功";
        public const string Manager_Username_Exsist = "账号或密码已经存在";
        //Add Note
        public const string Note_Not_Complete = "请将信息填写完整再提交";
        public const string Note_Add_Success = "备忘录添加成功";
        public const string Note_Title_Exsist = "对不起，您添加的备忘录标题已经存在";
        //Add_Tale
        public const string Combox_Name = "类型";
        public const string Comfoirm_Info = "确定添加?";
        public const string Notification = "提示";
        public const string Notify_Add_TabName = "请填写要创建的表名";
        public const string Add_Table_notif = "请填写完整第";
        public const string Row_Content = "行的内容";
        public const string Feild_Type = "行的字段类型";
        public const string Feild_Name = "行的字段名称";
        public const string Add_Table_Success = "数据表添加成功";
        public const string Add_Table_Faild = "数据表添加失败";
        public const string Table_Has_Exsist_notifi = "该部门已经存在";
        public const string Notifi_Add_NewName = "这张表，请重新输入表格名称";
        //importtable
        public const string Importtable_Name_Include_Space = "excel表格底部的Sheet名称不能有空格";
        public const string Importtable_has_exsist = "该数据表已经存在，无需导入";
        //Admin index
        //.....
        //checkuser
        public const string Check_pwd = "对不起，操作失败，请确认密码";
        public const string Comfirm_delete_dept = "确实要删除该部门吗？";
        public const string Make_Sure = "确认";
        public const string Delete_Dept_Success = "删除成功";
        //delet manager
        public const string Confirm_DeletManager = "确实要删除该经理吗";
        public const string Mnager_Delete_Success = "经理删除成功";
        //delete tables
        public const string Dept_No_Table = "您选择的部门还未创建任何表，请重新选择";
        public const string Comfirm_Delete_Table = "确实要删除该数据表吗？";
        public const string Delete_Table_Success = "数据表删除成功";
        //dept_datainfo
        public const string Time_Error = "建表时间不能大于当前时间";
        public const string Font_Type = "微软雅黑";
        //manage manager
        public const string No_Manager = "对不起，您还没有添加任何经理";
        public const string CMB_name = "部门";
        public const string Confirm_Modify_Manger = "确实要保存修改吗";
        public const string Modify_Success = "修改成功";
        //manage_note
        public const string No_Note = "您还没有添加备忘录";
        public const string No_Staff = "对不起，当前还未分配员工账号";
        //manage_staffinfo
        public const string No_StaffInfo = "对不起，员工信息尚无";
       public const string Type = "Excel文件(*.xlsx)|*.xlsx";
        //add_dept_worker
        public const string Add_Staff_Success = "员工账号添加成功";
        public const string Staff_Username_Exsist = "账号或密码已经存在";
        //add level
        public const string No_Level_tosee = "不可见";
        public const string Level_tosee = "可见";
        public const string Can_ReadandWrite = "可见可写";
        public const string Add_Level_Success = "权限分配成功";
       //delete staff
        public const string Comfirm_Delete_Staff = "确实要删除该员工吗";
        public const string Staff_Delete_Success = "该员工已经被删除";
        //manage_level
        public const string Staff_NoLevel_Table = "对不起，该员工尚未被分配可操作表";
        //add user info
        public const string Add_User_Info_Success="信息录入成功";
        public const string Add_Info_Failed = "信息录入失败，请填写完整信息";
        //manager don't give level to staff
        public const string NotGivenLevel = "对不起，经理还未为您分配您的可操作表";
        


   










        

       

        private static ShareLib mySelf = new ShareLib();
    }

}
