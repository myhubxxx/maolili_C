using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using 裕景管理系统.administrator;
using System.Reflection;

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
        /// the method main for admin's solve the all Node'click
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void AdminGenericMethod(object sender, TreeViewEventArgs e, Panel p)
        {
            string className = "裕景管理系统.administrator.dept_query";//e.Node.Tag.ToString();
            // create the instance by className
            Type type = Type.GetType(className);
            // create instance
            Object obj = Activator.CreateInstance(type);
            //now get property TopLevel
            MethodInfo methodInfo = null;
            methodInfo = getMethod(type, "set_TopLevel");
            object[] param = {false};
            methodInfo.Invoke(obj, param);
         
            // get property Dock
            methodInfo = getMethod(type, "set_Dock");
            object[] param2 = { System.Windows.Forms.DockStyle.Fill };
            methodInfo.Invoke(obj, param2);

            //get property FormBorderStyle
            methodInfo = getMethod(type, "set_FormBorderStyle");
            object[] param3 = {FormBorderStyle.None};
            methodInfo.Invoke(obj, param3);

            // the panel 's method
            p.Controls.Clear();
            p.Controls.Add((Form)obj);

            // get method Show
            Type[] typeParam = System.Type.EmptyTypes;
            MethodInfo method = type.GetMethod("Show", typeParam);
            method.Invoke(obj, null);

        
        }
      
        private MethodInfo getMethod(Type type, string name) {
            try
            {
                MethodInfo method = type.GetMethod(name);
                
                /*
                FieldInfo[] fAll = type.GetFields();
                FieldInfo[] f = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance
                                       | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.IgnoreCase);
                MethodInfo[] mm = type.GetMethods();
                //int count = methods.Count();
                for (int i = 0; i < mm.Count(); i++)
                {
                    string temp = mm[i].Name.ToString();
                    if (temp.IndexOf("Show") != -1)
                    {
                        MessageBox.Show(mm[i].ToString() + ":" + temp);
                    }
                }
                */

                return method;
            }catch(Exception ex){
                return null;
            }

        }

        /// <summary>
        /// not finish
        ///  this method use to handle all exception.
        ///  Attention : i just get the exception's message to return, 
        ///  but i want to found the best solution.
        /// </summary>
        /// <param name="ex"></param>
        public string HandleExcption(Exception ex)
        {
            string exceptionType = ex.GetType().ToString();
            MessageBox.Show(exceptionType);

            switch( exceptionType ){
                
                case "" :
                    break;
                case "-" :
                    break;
                default:
                    break;

            }

            return null;
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
