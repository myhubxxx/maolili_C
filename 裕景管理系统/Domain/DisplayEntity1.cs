using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 裕景管理系统.Domain
{
      [Serializable]
    class DisplayEntity1
    {
        /// <summary>
        /// 用户名，
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPwd { get; set; }
        /// <summary>
        /// 用户等级
        /// </summary>
        public int Userlevel { get; set; }
        /// <summary>
        /// dept_id
        /// </summary>
        public int Dept_id { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DeptName { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        public int DeptID { get; set; }
    }
}
