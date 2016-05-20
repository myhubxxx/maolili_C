using DBCon1.Dao;
using DBCon1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.test_dao
{
    class TestUserInfoDaoNew
    {
        private UserInfoDao dao = new UserInfoDao();

        public void testAdd() {
            UserInfo bean = new UserInfo();
                bean.Dept = "人事部";
                bean.Name = "张三";
                bean.Sex = "男";
                bean.Nation = "汉族";
                bean.Birthplace = "四川省";
                bean.Birthday = DateTime.Now;
                bean.Startworktime = DateTime.Now;
                bean.Joinmycompanytime = DateTime.Now;
                bean.Idcard = "5006514856315662155";
                bean.Position = "经理";
           //     bean.Zhiyezhuce = null;
            //    bean.Graduateschool = "西南石油";
                bean.Education = "大学";
                bean.Address = "金沙路57号1-2-5-22号";
                bean.Ssn = "011612901";
            //    bean.Zhichengcard = "职称card";
                bean.Tele = "18256871567";
                bean.Remark = "在职";

                dao.add(bean, "办公室");   
                
                int i = 1;
        }

        public void testLoad() {
            dao.load(1, "办公室");
        }
        public void getByName() {
            UserInfo bean = dao.getByName("张三", "办公室");
            int i = 9;
        }
        public void getAllByList() {
            List<UserInfo> list = dao.getAllByList("办公室");
            int i = 0;
        }
        public void testUpdate() {
            UserInfo bean = new UserInfo();
            bean.Id = 1;
            bean.Dept = "人事部-";
            bean.Name = "张三-";
            bean.Sex = "男-";
            bean.Nation = "汉族-";
            bean.Birthplace = "四川省-";
            bean.Birthday = DateTime.Now;
            bean.Startworktime = DateTime.Now;
            bean.Joinmycompanytime = DateTime.Now;
            bean.Idcard = "5006514856315662155-";
            bean.Position = "经理_chanfe";
            bean.Zhiyezhuce = "zhiyezhuce_chaneg";
            bean.Graduateschool = "西南石油_change";
            bean.Education = "大学_change";
            bean.Address = "金沙路57号1-2-5-22号_change";
            bean.Ssn = "011612901_change";
            bean.Zhichengcard = "职称card_changfe";
            bean.Tele = "18256871567_cjamge";
            bean.Remark = "在职_change";

            dao.update(bean, "办公室");  
        }


    }
}
