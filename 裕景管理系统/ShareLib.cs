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

        /// <summary>
        ///  this method use to handle all exception.
        ///  Attention : i just get the exception's message to return, 
        ///  but i want to found the best solution.
        /// </summary>
        /// <param name="ex"></param>
        public string HandleExcption(Exception ex)
        {
            return ex.Message;
        }       

        //pulibc string
        //Login:
        public const string LOGIN_INPUT_NULL = "账号或密码不能为空";
        //.....

        public const string HAVE_NO_ACCESS = "未获取到相应的权限";

        //end

        private static ShareLib mySelf = new ShareLib();
    }

}
