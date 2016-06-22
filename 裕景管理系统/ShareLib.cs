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
        public const string LOGIN_INPUT_NULL = "账号或密码不能为空";
        //.....

        public const string HAVE_NO_ACCESS = "未获取到相应的权限";

        //end

        private static ShareLib mySelf = new ShareLib();
    }

}
