using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 裕景管理系统.Dao
{
     [Serializable]
  public   class puriview
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
        /// 权限表里的针对表
        /// </summary>
        public string depettable { get; set; }
        /// <summary>
        /// 权限级别
        /// </summary>
        public int PRIVIEW { get; set; }



    }
}
