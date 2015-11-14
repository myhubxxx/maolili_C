using DBCon1.Dao;
using DBCon1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1
{
    class TestUserInfoDao
    {
        UserInfoDao dao = new UserInfoDao();

        public void test() {
            //add();
            //update();
          //  delete();
           //load();
            //getByName();
            getByList();
        }
        public void getByList() {
            List<UserInfo> list = dao.getAllByList();
        
        }
        public void getByName() {
           UserInfo bean =  dao.getByName("测试4");
        
        }
        public void load() {
           UserInfo bean = dao.load(3);
        }
        public void delete() {
            dao.delete(2);
        }
        public void update() {
            UserInfo bean = new UserInfo();
            bean.Id = 3;
            bean.Name = "测试";
            bean.Age = 5;
            bean.Sex = "女";
            bean.Birthday = DateTime.Now;
            bean.Nation = "nation 是啥子";
            bean.Tele = "18428346869";
            bean.Address = "成都市二逼区";
            bean.Email = "x@xx.com";
            bean.Ndress = "这又是啥子";
            bean.Idcard = "5116021222218964";
            bean.Grede = "博士后";
            bean.Hunying = "已婚";

            dao.update(bean);
        }
        public void add() {
            UserInfo bean = new UserInfo();
            bean.Id = 3;
            bean.Name = "测试";
            bean.Age = 5;
            bean.Sex = "男";
            bean.Birthday = DateTime.Now;
            bean.Nation = "nation 是啥子";
            bean.Tele = "18428346869";
            bean.Address = "成都市二逼区";
            bean.Email = "x@xx.com";
            bean.Ndress = "这又是啥子";
            bean.Idcard = "5116021222218964";
            bean.Grede = "博士后";
            bean.Hunying = "已婚";

            dao.add(bean);
        }

    }
}
