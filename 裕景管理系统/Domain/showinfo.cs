using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 裕景管理系统.Domain
{
      [Serializable]
 public    class showinfo
    {
        /// <summary>
        /// 用户信息表里的id
        /// </summary>
        public int userinfoid { get; set; }
        /// <summary>
        /// 用户的真实名字
        /// </summary>
        public string UserfoName { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string UserPwd { get; set; }
        /// <summary>
        /// 用户等级
        /// </summary>
      //  public int Userlevel { get; set; }
        /// <summary>
        /// dept_id
        /// </summary>
     //   public int Dept_id { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
      //  public string DeptName { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        public int DeptID { get; set; }


    }
}
