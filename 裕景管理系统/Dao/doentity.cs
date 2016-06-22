using 裕景管理系统.Domain;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 裕景管理系统.Dao
{
 public static  class doentity
    {

     public static List<entity>touserinfo(this object _obj)
     {
         List<entity> list = new List<entity>();
         using (OleDbConnection con = DBCon1.test_dao.AccessOp.getCon("manager"))
         {
             string sql = "select * From myuser where dept_id=" + ConstatData.department.Id;
             using (OleDbCommand cmd = new OleDbCommand(sql, con))
             {
                 var read = cmd.ExecuteReader();
                 if (read.HasRows)
                 {
                     entity ent = null;
                     while (read.Read())
                     {
                         ent = new entity();
                         ent.userinfoid = value<int>(read["ID"]);

                         ent.UserName = value<string>(read["uname"]);
                         ent.UserPwd = value<string>(read["upass"]);
                        // ent.userlevel = value<int>(read["userlevel"]);

                         list.Add(ent);
                     }
                 }
                 read.Close();
                 con.Close();
             }
         }
         for (int i = 0; i < list.Count; i++)
         {
             //list[i].DeptName = getDeptName(list[i].DeptID);
             list[i].UserfoName = getuserinfoname(list[i].userinfoid);
         }
         return list;
     }
     
     public static int updateuserinfo(this List<entity> list)
     {
         var row = 0;
         foreach (var item in list)
         {
             using (OleDbConnection con = DBCon1.test_dao.AccessOp.getCon("manager")) //修改用户
             {

                 string sql = "update myuser set uname='" + item.UserName + "',upass='" + item.UserPwd + "' where ID=" + item.userinfoid;
                 using (OleDbCommand cmd = new OleDbCommand(sql, con))
                 {
                     row += cmd.ExecuteNonQuery();
                     con.Close();

                 }
             }
             //item.DeptName
         }

         return row;


     }




     private static string getuserinfoname(int userinfoid)//根据ID获取userinfo中用户的姓名
     {
         string res = string.Empty;
         try
         {
             using (OleDbConnection con = DBCon1.test_dao.AccessOp.getCon("manager"))
             {
                 string sql = "select uname from userinfo where ID=" + userinfoid.ToString();
                 using (OleDbCommand cmd = new OleDbCommand(sql, con))
                 {
                     var result = cmd.ExecuteScalar();
                     if (result != null && result != DBNull.Value)
                         res = result.ToString();
                     con.Close();
                 }
             }
         }
         catch (Exception ex)
         {
             throw ex;
         }
         return res;





     }


     private static T value<T>(object _v)
     {
         object res = string.Empty;
         if (_v != null && _v != DBNull.Value)
             return (T)_v;
         else
         {
             if (typeof(T) == typeof(int))
             {
                 res = 0;
             }
         }
         // typeof(int)/float
         return (T)res;
     }

    }
}
