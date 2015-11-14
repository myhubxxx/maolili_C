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
        // add the info to database
        public bool add(UserInfo userinfo) {
            
            
                OleDbConnection con = getCon(null);
                string sql = "insert into userinfo(ID, u_name, u_age, u_sex, u_birthday, u_nation," +
                                " u_tele, u_address, u_email, u_ndress, u_idcard, u_grede, u_hunying) " +
                                "values(@ID, @name, @age, @sex, @birthday, @nation, @tele, @address, " +
                                "@email, @ndress, @idcard, @grede, @hunying)";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbParameter[] param = { new OleDbParameter("@ID", userinfo.Id), new OleDbParameter("@name", userinfo.Name),
                                     new OleDbParameter("@age", userinfo.Age), new OleDbParameter("@sex", userinfo.Sex),
                                     new OleDbParameter("@birthday", userinfo.Birthday.ToString("d")), new OleDbParameter("@nation", userinfo.Nation),
                                     new OleDbParameter("@tele", userinfo.Tele), new OleDbParameter("@address", userinfo.Address),
                                     new OleDbParameter("@email", userinfo.Email), new OleDbParameter("@ndress", userinfo.Ndress),
                                     new OleDbParameter("@idcard", userinfo.Idcard), new OleDbParameter("@grede", userinfo.Grede),
                                     new OleDbParameter("@hunying", userinfo.Hunying)};

                cmd.Parameters.AddRange(param);

                cmd.ExecuteNonQuery();

                //close con
                closeAll(con, cmd, null);

                return true;


        }
        // update the info
        public bool update(UserInfo userinfo) {
            
                OleDbConnection con = getCon(null);
                string sql = "update userinfo set u_name=@name, u_age=@age, u_sex=@sex, u_birthday=@birthday, u_nation=@nation, " +
                                "u_tele=@tele, u_address=@address, u_email=@email, u_ndress=@ndress, u_idcard=@idcard, u_grede=@grede," +
                                "u_hunying=@hunying where ID=@ID";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbParameter[] param = {  new OleDbParameter("@name", userinfo.Name),
                                     new OleDbParameter("@age", userinfo.Age), new OleDbParameter("@sex", userinfo.Sex),
                                     new OleDbParameter("@birthday", userinfo.Birthday.ToString("d")), new OleDbParameter("@nation", userinfo.Nation),
                                     new OleDbParameter("@tele", userinfo.Tele), new OleDbParameter("@address", userinfo.Address),
                                     new OleDbParameter("@email", userinfo.Email), new OleDbParameter("@ndress", userinfo.Ndress),
                                     new OleDbParameter("@idcard", userinfo.Idcard), new OleDbParameter("@grede", userinfo.Grede),
                                     new OleDbParameter("@hunying", userinfo.Hunying), new OleDbParameter("@ID", userinfo.Id),};
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                // close con
                closeAll(con, cmd, null);

                return true;
            
            
        }
        // delete the info
        public bool delete(int id) {
            
                OleDbConnection con = getCon(null);
                string sql = "delete from userinfo where ID=" + id;
                OleDbCommand cmd = new OleDbCommand(sql, con);

                cmd.ExecuteNonQuery();
                // close con
                closeAll(con, cmd, null);

                return true;
            }
           
        
        // search the data
        public UserInfo load(int id) {
            
                OleDbConnection con = getCon(null);
                string sql = "select * from userinfo where ID=" + id ;
                OleDbCommand cmd = new OleDbCommand(sql, con);

                OleDbDataReader reader = cmd.ExecuteReader();
                UserInfo userinfo = null;
                if(reader.Read()){
                    userinfo = new UserInfo();

                    userinfo.Id = reader.GetInt32(0);
                    userinfo.Name = reader.GetString(1);
                    userinfo.Age = reader.GetInt32(2);
                    userinfo.Sex = reader.GetString(3);
                    userinfo.Birthday = reader.GetDateTime(4);
                    userinfo.Nation= reader.GetString(5);
                    userinfo.Tele = reader.GetString(6);
                    userinfo.Address = reader.GetString(7);
                    userinfo.Email = reader.GetString(8);
                    userinfo.Ndress = reader.GetString(9);
                    userinfo.Idcard= reader.GetString(10);
                    userinfo.Grede = reader.GetString(11);
                    userinfo.Hunying = reader.GetString(12);

                }
                // close con
                closeAll(con, cmd, reader);

                return userinfo;


        }
        // search by name
        public UserInfo getByName(string name) {
            
            
                OleDbConnection con = getCon(null);
                string sql = "select * from userinfo where u_name='" + name + "'";
                OleDbCommand cmd = new OleDbCommand(sql, con);

                OleDbDataReader reader = cmd.ExecuteReader();
                UserInfo userinfo = null;
                if (reader.Read())
                {
                    userinfo = new UserInfo();

                    userinfo.Id = reader.GetInt32(0);
                    userinfo.Name = reader.GetString(1);
                    userinfo.Age = reader.GetInt32(2);
                    userinfo.Sex = reader.GetString(3);
                    userinfo.Birthday = reader.GetDateTime(4);
                    userinfo.Nation = reader.GetString(5);
                    userinfo.Tele = reader.GetString(6);
                    userinfo.Address = reader.GetString(7);
                    userinfo.Email = reader.GetString(8);
                    userinfo.Ndress = reader.GetString(9);
                    userinfo.Idcard = reader.GetString(10);
                    userinfo.Grede = reader.GetString(11);
                    userinfo.Hunying = reader.GetString(12);

                }
                // close con
                closeAll(con, cmd, reader);

                return userinfo;

            }
            
        // get all info
        public DataSet getAllByDataSet() {
            OleDbConnection con = getCon(null);
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
        public List<UserInfo> getAllByList() {
            OleDbConnection con = getCon(null);
            string sql = "select * from userinfo";
            OleDbCommand cmd = new OleDbCommand(sql, con);

            OleDbDataReader reader = cmd.ExecuteReader();
            List<UserInfo> list = new List<UserInfo>();
            while( reader.Read() ){

               UserInfo userinfo = new UserInfo();

                userinfo.Id = reader.GetInt32(0);
                userinfo.Name = reader.GetString(1);
                userinfo.Age = reader.GetInt32(2);
                userinfo.Sex = reader.GetString(3);
                userinfo.Birthday = reader.GetDateTime(4);
                userinfo.Nation = reader.GetString(5);
                userinfo.Tele = reader.GetString(6);
                userinfo.Address = reader.GetString(7);
                userinfo.Email = reader.GetString(8);
                userinfo.Ndress = reader.GetString(9);
                userinfo.Idcard = reader.GetString(10);
                userinfo.Grede = reader.GetString(11);
                userinfo.Hunying = reader.GetString(12);

                list.Add(userinfo);
            }
            return list;
        }


    }
}
