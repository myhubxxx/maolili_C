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
                string sql = "insert into userinfo(ID, dept, uname, sex, nation, birthplace," +
                                " birthday, startworktime, joinmycompanytime, idcard, positiono, zhiyezhuce, graduateschool,education,addresso,ssn,zhichengcard,tele,remark) " +
                                "values(@ID,@dept, @uname, @sex, @nation, @birthplace, @birthday, @startworktime, " +
                                "@joinmycompanytime, @idcard, @position, @zhiyezhuce, @graduateschool,@education,@addresso,@ssn,@zhichengcard,@tele,@remark)";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbParameter[] param = { new OleDbParameter("@ID", userinfo.Id),
                                             new OleDbParameter("@dept", userinfo.Dept),
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
        // update the info
        public bool update(UserInfo userinfo) {
            
                OleDbConnection con = getCon(null);
                string sql ="update userinfo set dept=@dept, uname=@uname, sex=@sex, nation=@nation, birthplace=@birthplace," +
                                " birthday=@birthday, startworktime=@startworktime, joinmycompanytime=@joinmycompanytime, idcard=@idcard, positiono=@position, zhiyezhuce=@zhiyezhuce," +
                                   " graduateschool=@graduateschool,education=@education,addresso=@addresso,ssn=@ssn,zhichengcard=@zhichengcard,tele=@tele,remark=@remark  where ID=@ID";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbParameter[] param = { new OleDbParameter("@dept", userinfo.Dept),
                                  
                                         new OleDbParameter("@uname", userinfo.Name), new OleDbParameter("@sex", userinfo.Sex),
                                         new OleDbParameter("@nation", userinfo.Nation), new OleDbParameter("@birthplace", userinfo.Birthplace),
                                         new OleDbParameter("@birthday", userinfo.Birthday.ToString("d")), new OleDbParameter("@startworktime", userinfo.Startworktime.ToString("d")),
                                         new OleDbParameter("@joinmycompanytime", userinfo.Joinmycompanytime.ToString("d")), new OleDbParameter("@idcard", userinfo.Idcard),
                                         new OleDbParameter("@position", userinfo.Position), new OleDbParameter("@zhiyezhuce", userinfo.Zhiyezhuce),
                                         new OleDbParameter("@graduateschool", userinfo.Graduateschool), new OleDbParameter("@education", userinfo.Education), 
                                         new OleDbParameter("@addresso", userinfo.Address), new OleDbParameter("@ssn", userinfo.Ssn),
                                         new OleDbParameter("@zhichengcard", userinfo.Zhichengcard), new OleDbParameter("@tele", userinfo.Tele),
                                         new OleDbParameter("@remark", userinfo.Remark),new OleDbParameter("@ID", userinfo.Id)};
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
        public UserInfo getByName(string name) {
            
            
                OleDbConnection con = getCon(null);
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


        //get ds
        public DataSet getallinfo_ds()
        {
            OleDbConnection con = getCon(null);
            string sql = "select * from userinfo";
            OleDbDataAdapter sda = new OleDbDataAdapter(sql, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(sda);
            sda.InsertCommand = builder.GetInsertCommand();
            sda.DeleteCommand = builder.GetDeleteCommand();
            sda.UpdateCommand = builder.GetUpdateCommand();
            DataSet ds = new DataSet();
            sda.Fill(ds,"userinfo");
            return ds;


        }
        //get da
        public OleDbDataAdapter getallinfo_da()
        {
            OleDbConnection con = getCon(null);
            string sql = "select * from userinfo";
            OleDbDataAdapter sda = new OleDbDataAdapter(sql, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(sda);
            sda.InsertCommand = builder.GetInsertCommand();
            sda.DeleteCommand = builder.GetDeleteCommand();
            sda.UpdateCommand = builder.GetUpdateCommand();
            DataSet ds = new DataSet();
            sda.Fill(ds, "userinfo");
            return sda;


        }



        // get all info
        public List<UserInfo> getAllByList() {
            OleDbConnection con = getCon(null);
            string sql = "select * from UserInfo";
            OleDbCommand cmd = new OleDbCommand(sql, con);

            OleDbDataReader reader = cmd.ExecuteReader();
            List<UserInfo> list = new List<UserInfo>();
            while( reader.Read() ){

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
