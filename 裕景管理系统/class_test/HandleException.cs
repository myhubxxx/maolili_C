using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 裕景管理系统.class_test
{
    class HandleException
    {

        public static void HandleExceptionTest( ) {

            try {

                Object a = 5;
              //  DateTime d = (DateTime)a;
                
            }catch(Exception e){

                MessageBox.Show(e.GetType()+":"+ShareLib.Instance().HandleExcption(e));
                
                
            }

        
        }

        public static string MyHandleException(Exception e) {
            // get the exception info ,then handle it by effective

            Console.WriteLine( e.ToString() );
           
            Console.ReadLine();


            return null;
        }
    }
}
