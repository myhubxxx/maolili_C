using DBCon1.Domain;
using DBCon1.test_dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBCon1.Dao
{
    class UserInfoDao : AbstractDao
    {
        // add the info to database
        public bool add(UserInfo userinfo) {

            return false;
        }
        // update the info
        public bool update(UserInfo userinfo) {

            return false;
        }
        // delete the info
        public bool delete(int id) {

            return false;
        }
        // search the data
        public UserInfo load(int id) {

            return null;
        }
        // search by name
        public UserInfo getByName() {

            return null;
        }


    }
}
