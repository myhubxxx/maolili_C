using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.Domain
{
     /*
      * 此类主要用于 提醒用户添加的提示信息，
      * 提前定时提醒他们
      * 
      * build time : 2016.04.06 12:23
      */
    class BumRemind
    {
        private int id; // 此 id 为，该信息本身的id,唯一
        private int userId; // 该 id 为用户id
        private string title;// 表示提示标题
        private string content;// 表示提示的详细内容
        private DateTime endTime;// 提示信息结束时间
        private int beforeDay;  //  提前几天提醒，

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        

        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        

        public int BeforeDay
        {
            get { return beforeDay; }
            set { beforeDay = value; }
        }




    }
}
