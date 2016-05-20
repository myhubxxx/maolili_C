using DBCon1.Domain;
using DBCon1.test_dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace DBCon1.Dao
{
    class UserInfoDao : AbstractDao
    {
        public static void nullToSpace(UserInfo userinfo) { 
            int a = 0;
            userinfo.Dept = userinfo.Dept != null ? userinfo.Dept : " ";
            userinfo.Sex = userinfo.Sex != null ? userinfo.Sex : " ";
            userinfo.Nation = userinfo.Nation != null ? userinfo.Nation : " ";
            userinfo.Birthplace = userinfo.Birthplace != null ? userinfo.Birthplace : " ";
            userinfo.Idcard = userinfo.Idcard != null ? userinfo.Idcard : " ";
            userinfo.Position = userinfo.Position != null ? userinfo.Position : " ";
            userinfo.Zhiyezhuce = userinfo.Zhiyezhuce != null ? userinfo.Zhiyezhuce : " ";
            userinfo.Graduateschool = userinfo.Graduateschool != null ? userinfo.Graduateschool : " ";
            userinfo.Education = userinfo.Education != null ? userinfo.Education : " ";
            userinfo.Address = userinfo.Address != null ? userinfo.Address : " ";
            userinfo.Ssn = userinfo.Ssn != null ? userinfo.Ssn : " ";
            userinfo.Zhichengcard = userinfo.Zhichengcard != null ? userinfo.Zhichengcard : " ";
            userinfo.Tele = userinfo.Tele != null ? userinfo.Tele : " ";
            userinfo.Remark = userinfo.Remark != null ? userinfo.Remark : " ";
            

        }
        // add the info to database
        public bool add(UserInfo userinfo, string dbName)
        {
            // 将值为null 的变量转为空格
            nullToSpace(userinfo);

            OleDbConnection con = getCon(dbName);
            string sql = "insert into userinfo( dept, uname, sex, nation, birthplace," +
                                " birthday, startworktime, joinmycompanytime, idcard, positiono, zhiyezhuce, graduateschool,education,addresso,ssn,zhichengcard,tele,remark) " +
                                "values(@dept, @uname, @sex, @nation, @birthplace, @birthday, @startworktime, " +
                                "@joinmycompanytime, @idcard, @position, @zhiyezhuce, @graduateschool,@education,@addresso,@ssn,@zhichengcard,@tele,@remark)";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param = {   new OleDbParameter("@dept", userinfo.Dept),
                                         new OleDbParameter("@uname", userinfo.Name), new OleDbParameter("@sex", userinfo.Sex),
                                         new OleDbParameter("@nation", userinfo.Nation), new OleDbParameter("@birthplace", userinfo.Birthplace),
                                         new OleDbParameter("@birthday", userinfo.Birthday.ToString("d")), new OleDbParameter("@startworktime", userinfo.Startworktime.ToString("d")),
                                         new OleDbParameter("@joinmycompanytime", userinfo.Joinmycompanytime.ToString("d")), new OleDbParameter("@idcard", userinfo.Idcard),
                                         new OleDbParameter("@position", userinfo.Position), new OleDbParameter("@zhiyezhuce", userinfo.Zhiyezhuce),
                                         new OleDbParameter("@graduateschool", userinfo.Graduateschool), new OleDbParameter("@education", userinfo.Education), 
                                         new OleDbParameter("@addresso", userinfo.Address), new OleDbParameter("@ssn", userinfo.Ssn),
                                         new OleDbParameter("@zhichengcard", userinfo.Zhichengcard), new OleDbParameter("@tele", userinfo.Tele),
                                         new OleDbParameter("@remark", userinfo.Remark)};

            cmd.Parameters.AddRange(param);
            cmd.ExecuteNonQuery();

            //close con
            closeAll(con, cmd, null);

            return true;
        }
        //public bool add(UserInfo userinfo) {


        //        OleDbConnection con = getCon(null);
        //        string sql = "insert into userinfo(ID, u_name, u_age, u_sex, u_birthday, u_nation," +
        //                        " u_tele, u_address, u_email, u_ndress, u_idcard, u_grede, u_hunying) " +
        //                        "values(@ID, @name, @age, @sex, @birthday, @nation, @tele, @address, " +
        //                        "@email, @ndress, @idcard, @grede, @hunying)";
        //        OleDbCommand cmd = new OleDbCommand(sql, con);
        //        OleDbParameter[] param = { new OleDbParameter("@ID", userinfo.Id), new OleDbParameter("@name", userinfo.Name),
        //                             new OleDbParameter("@age", userinfo.Age), new OleDbParameter("@sex", userinfo.Sex),
        //                             new OleDbParameter("@birthday", userinfo.Birthday.ToString("d")), new OleDbParameter("@nation", userinfo.Nation),
        //                             new OleDbParameter("@tele", userinfo.Tele), new OleDbParameter("@address", userinfo.Address),
        //                             new OleDbParameter("@email", userinfo.Email), new OleDbParameter("@ndress", userinfo.Ndress),
        //                             new OleDbParameter("@idcard", userinfo.Idcard), new OleDbParameter("@grede", userinfo.Grede),
        //                             new OleDbParameter("@hunying", userinfo.Hunying)};

        //        cmd.Parameters.AddRange(param);

        //        cmd.ExecuteNonQuery();

        //        //close con
        //        closeAll(con, cmd, null);

        //        return true;
        //}
        // update the info

        public bool update(UserInfo userinfo, string dbName) {
            OleDbConnection con = getCon("办公室");
            string sql = "update userinfo set dept=@dept, uname=@uname, sex=@sex, nation=@nation, birthplace=@birthplace," +
                                " birthday=@birthday, startworktime=@startworktime, joinmycompanytime=@joinmycompanytime, idcard=@idcard, positiono=@position, zhiyezhuce=@zhiyezhuce," +
                                   " graduateschool=@graduateschool,education=@education,addresso=@addresso,ssn=@ssn,zhichengcard=@zhichengcard,tele=@tele,remark=@remark  where ID=@ID";
                                
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbParameter[] param = {   new OleDbParameter("@dept", userinfo.Dept),
                                         new OleDbParameter("@uname", userinfo.Name), new OleDbParameter("@sex", userinfo.Sex),
                                         new OleDbParameter("@nation", userinfo.Nation), new OleDbParameter("@birthplace", userinfo.Birthplace),
                                         new OleDbParameter("@birthday", userinfo.Birthday.ToString("d")), new OleDbParameter("@startworktime", userinfo.Startworktime.ToString("d")),
                                         new OleDbParameter("@joinmycompanytime", userinfo.Joinmycompanytime.ToString("d")), new OleDbParameter("@idcard", userinfo.Idcard),
                                         new OleDbParameter("@position", userinfo.Position), new OleDbParameter("@zhiyezhuce", userinfo.Zhiyezhuce),
                                         new OleDbParameter("@graduateschool", userinfo.Graduateschool), new OleDbParameter("@education", userinfo.Education), 
                                         new OleDbParameter("@address", userinfo.Address), new OleDbParameter("@ssn", userinfo.Ssn),
                                         new OleDbParameter("@zhichengcard", userinfo.Zhichengcard), new OleDbParameter("@tele", userinfo.Tele),
                                         new OleDbParameter("@remark", userinfo.Remark),new OleDbParameter("@ID", userinfo.Id)};

            cmd.Parameters.AddRange(param);
            cmd.ExecuteNonQuery();

            //close con
            closeAll(con, cmd, null);

            return true;

        }
        //public bool update(UserInfo userinfo)
        //{

        //    OleDbConnection con = getCon(null);
        //    string sql = "update userinfo set u_name=@name, u_age=@age, u_sex=@sex, u_birthday=@birthday, u_nation=@nation, " +
        //                    "u_tele=@tele, u_address=@address, u_email=@email, u_ndress=@ndress, u_idcard=@idcard, u_grede=@grede," +
        //                    "u_hunying=@hunying where ID=@ID";
        //    OleDbCommand cmd = new OleDbCommand(sql, con);
        //    OleDbParameter[] param = {  new OleDbParameter("@name", userinfo.Name),
        //                             new OleDbParameter("@age", userinfo.Age), new OleDbParameter("@sex", userinfo.Sex),
        //                             new OleDbParameter("@birthday", userinfo.Birthday.ToString("d")), new OleDbParameter("@nation", userinfo.Nation),
        //                             new OleDbParameter("@tele", userinfo.Tele), new OleDbParameter("@address", userinfo.Address),
        //                             new OleDbParameter("@email", userinfo.Email), new OleDbParameter("@ndress", userinfo.Ndress),
        //                             new OleDbParameter("@idcard", userinfo.Idcard), new OleDbParameter("@grede", userinfo.Grede),
        //                             new OleDbParameter("@hunying", userinfo.Hunying), new OleDbParameter("@ID", userinfo.Id),};
        //    cmd.Parameters.AddRange(param);
        //    cmd.ExecuteNonQuery();
        //     close con
        //    closeAll(con, cmd, null);

        //    return true;
        //}


        // delete the info
        
        
        
        public bool delete(int id, string dbName)
        {

            OleDbConnection con = getCon(dbName);
            string sql = "delete from userinfo where ID=" + id;
            OleDbCommand cmd = new OleDbCommand(sql, con);

            cmd.ExecuteNonQuery();
            // close con
            closeAll(con, cmd, null);

            return true;
        }


        // search the data
        public UserInfo load(int id, string dbName)
        {

            OleDbConnection con = getCon(dbName);
            string sql = "select * from userinfo where ID=" + id;
            OleDbCommand cmd = new OleDbCommand(sql, con);

            OleDbDataReader reader = cmd.ExecuteReader();
            UserInfo userinfo = null;
            if (reader.Read())
            {
                userinfo = new UserInfo();

                userinfo.Id = reader.GetInt32(0);
                userinfo.Dept = reader.GetString(1);
                userinfo.Name = reader.GetString(2);
                userinfo.Sex = reader.GetString(3);
                userinfo.Nation = reader.GetString(4);
                userinfo.Birthplace = reader.GetString(5);
                userinfo.Birthday = reader.GetDateTime(6);
                userinfo.Startworktime = reader.GetDateTime(7);
                userinfo.Joinmycompanytime = reader.GetDateTime(8);
                userinfo.Idcard = reader.GetString(9);
                userinfo.Position = reader.GetString(10);
                userinfo.Zhiyezhuce = reader.GetString(11);
                userinfo.Graduateschool = reader.GetString(12);
                userinfo.Education = reader.GetString(13);
                userinfo.Address = reader.GetString(14);
                userinfo.Ssn = reader.GetString(15);
                userinfo.Zhichengcard = reader.GetString(16);
                userinfo.Tele = reader.GetString(17);
                userinfo.Remark = reader.GetString(18);


            }
            // close con
            closeAll(con, cmd, reader);

            return userinfo;


        }
        // search by name
        public UserInfo getByName(string name, string dbName)
        {


            OleDbConnection con = getCon(dbName);
            string sql = "select * from userinfo where uname='" + name + "'";
            OleDbCommand cmd = new OleDbCommand(sql, con);

            OleDbDataReader reader = cmd.ExecuteReader();
            UserInfo userinfo = null;
            if (reader.Read())
            {
                userinfo = new UserInfo();

                userinfo.Id = reader.GetInt32(0);
                userinfo.Dept = reader.GetString(1);
                userinfo.Name = reader.GetString(2);
                userinfo.Sex = reader.GetString(3);
                userinfo.Nation = reader.GetString(4);
                userinfo.Birthplace = reader.GetString(5);
                userinfo.Birthday = reader.GetDateTime(6);
                userinfo.Startworktime = reader.GetDateTime(7);
                userinfo.Joinmycompanytime = reader.GetDateTime(8);
                userinfo.Idcard = reader.GetString(9);
                userinfo.Position = reader.GetString(10);
                userinfo.Zhiyezhuce = reader.GetString(11);
                userinfo.Graduateschool = reader.GetString(12);
                userinfo.Education = reader.GetString(13);
                userinfo.Address = reader.GetString(14);
                userinfo.Ssn = reader.GetString(15);
                userinfo.Zhichengcard = reader.GetString(16);
                userinfo.Tele = reader.GetString(17);
                userinfo.Remark = reader.GetString(18);

            }
            // close con
            closeAll(con, cmd, reader);

            return userinfo;

        }

        // get all info
        public DataSet getAllByDataSet(string dbName)
        {
            OleDbConnection con = getCon(dbName);
            string sql = "select * from userinfo";
            OleDbCommand cmd = new OleDbCommand(sql, con);

            DataSet ds = new DataSet();

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(ds);

            adapter.Dispose();
            // close con
            closeAll(con, cmd, null);

            return ds;

        }
        // get all info
        public List<UserInfo> getAllByList(string dbName)
        {
            OleDbConnection con = getCon(dbName);
            string sql = "select * from userinfo";
            OleDbCommand cmd = new OleDbCommand(sql, con);

            OleDbDataReader reader = cmd.ExecuteReader();
            List<UserInfo> list = new List<UserInfo>();
            while (reader.Read())
            {

                UserInfo userinfo = new UserInfo();

                userinfo.Id = reader.GetInt32(0);
                userinfo.Dept = reader.GetString(1);
                userinfo.Name = reader.GetString(2);
                userinfo.Sex = reader.GetString(3);
                userinfo.Nation = reader.GetString(4);
                userinfo.Birthplace = reader.GetString(5);
                userinfo.Birthday = reader.GetDateTime(6);
                userinfo.Startworktime = reader.GetDateTime(7);
                userinfo.Joinmycompanytime = reader.GetDateTime(8);
                userinfo.Idcard = reader.GetString(9);
                userinfo.Position = reader.GetString(10);
                userinfo.Zhiyezhuce = reader.GetString(11);
                userinfo.Graduateschool = reader.GetString(12);
                userinfo.Education = reader.GetString(13);
                userinfo.Address = reader.GetString(14);
                userinfo.Ssn = reader.GetString(15);
                userinfo.Zhichengcard = reader.GetString(16);
                userinfo.Tele = reader.GetString(17);
                userinfo.Remark = reader.GetString(18);

                list.Add(userinfo);
            }
            return list;
        }


    }
}
