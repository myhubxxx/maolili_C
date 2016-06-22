using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using 裕景管理系统.Domain;
namespace cj.Domain
{
    public static class SystemExc
    {
        /// <summary>
        /// 获取用户集合
        /// </summary>
        /// <returns></returns>
        public static List<DisplayEntity> ToUsers(this object _obj)
        {
            List<DisplayEntity> list = new List<DisplayEntity>();
            using (OleDbConnection con = DBCon1.test_dao.AccessOp.getCon("manager"))
            {
                string sql = "select * from myuser where userlevel=1";
                using (OleDbCommand cmd = new OleDbCommand(sql, con))
                {
                   var read= cmd.ExecuteReader();
                   if (read.HasRows)
                   {
                       DisplayEntity ent = null;
                       while (read.Read())
                       {
                           ent = new DisplayEntity();
                          ent.userinfoid = value<int>(read["ID"]);
                          
                          ent.UserName = value<string>(read["uname"]);
                           ent.UserPwd = value<string>(read["upass"]);
                           ent.DeptID=value<int>(read["dept_id"]);
                          // ent.Userlevel=value <int>(read ["userlevel"]);
                         //  ent.Dept_id = value<int>(read["dept_id"]);
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
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int UpdateUser(this List<DisplayEntity> list)
        {
            var row = 0;
            foreach (var item in list)
            {
                using (OleDbConnection con = DBCon1.test_dao.AccessOp.getCon("manager")) //修改用户
                {

                    string sql = "update myuser set uname='" + item.UserName + "',upass='" + item.UserPwd + "',dept_id=" + item.DeptID + " where id=" + item.userinfoid; 
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
        private static string getDeptName(int DeptID)
        {
            string res = string.Empty;
            try
            {
                using (OleDbConnection con = DBCon1.test_dao.AccessOp.getCon("manager"))
                {
                    string sql = "select dept_name from department where  id=" + DeptID.ToString();
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            res = result.ToString();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)//
            {
                throw ex;
            }
           
            return res;
        }
        private static string getuserinfoname(int userinfoid)
        {
            string res = string.Empty;
            try {
                using (OleDbConnection con = DBCon1.test_dao.AccessOp.getCon("manager"))
                {
                    string sql = "select u_name from UserInfo where id=" + userinfoid.ToString();
                    using (OleDbCommand cmd = new OleDbCommand(sql, con))
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            res = result.ToString();
                        con.Close();
                    }
                }
            }catch (Exception  ex)
            {
                throw ex;
            }
            return  res;
            
            
                   


        }

      


        private static T value<T>(object _v)
        {
            object res = string.Empty;
            if (_v != null && _v != DBNull.Value)
                return (T)_v;
            else
            {
                if(typeof(T)==typeof(int))
                {
                    res=0;
                }
            }
            // typeof(int)/float
            return (T)res;
        }
    }
}
