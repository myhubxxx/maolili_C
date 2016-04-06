using DBCon1.Dao;
using DBCon1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class TestBumRemind
    {

        BumRemindDao dao = new BumRemindDao();

        public void testAdd() {
            BumRemind bean = new BumRemind();
            bean.UserId = 5;
            bean.Title = "那快递";
            bean.Content = "在Add方法体中，在右击菜单中选择创建单元测试，并为这个方法创建单元测试代码的基本框架";
            bean.EndTime = System.DateTime.Now;

            bean.BeforeDay = 5;

            dao.addBumRemind(bean);

           // Console.write(bean.endtime);
           // Console.read();
        }
        public void testUpdate()
        {
            BumRemind bean = new BumRemind();
            bean.UserId = 666;
            bean.Title = "那快递,go tu kuaidi";
            bean.Content = "在Add方法体中，在右击菜单中选择";
            bean.EndTime = System.DateTime.Now;
            bean.Id = 1;

            bean.BeforeDay = 5;

            dao.updateById(bean);

            // Console.write(bean.endtime);
            // Console.read();
        }

        public void testDelete()
        {
            dao.deleteById(3);    
        }
        public void testGetById()
        {

            BumRemind bean = dao.getById(6);
            Console.Write(bean.Id+":"+bean.UserId + ":"+bean.Title + ":" + bean.Content + ":" + bean.EndTime + ":" +bean.BeforeDay);
            Console.Read();
        }

        public  void testGetByUserIdList()
        {
            List<BumRemind> beans = dao.getByUserIdList(5);
            for (int i = 0; i < beans.Count; i++)
            {
                BumRemind bean = beans[i];
                Console.Write(bean.Id + ":" + bean.UserId + ":" + bean.Title + ":" + bean.Content + ":" + bean.EndTime + ":" + bean.BeforeDay);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
