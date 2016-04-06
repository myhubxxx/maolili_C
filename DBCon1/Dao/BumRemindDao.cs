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
    /*
     *操作 BumRemin 的类，实现对数据库的    增删改查 
     *build time : 2016.04.06 13.03
     */
    class BumRemindDao : AbstractDao
    {
        /*
         * 添加提示实例到数据库
         */
        public void addBumRemind(BumRemind form) {
            String sql = "insert into BumRemind(userId, title, content, endTime, beforeDay) " +
                                    "values(@userId, @title, @content, @endTime, @beforeDay)";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            
            OleDbParameter [] param = { new OleDbParameter("@userId",form.UserId),  new OleDbParameter("@title", form.Title),
                                        new OleDbParameter("@content", form.Content), new OleDbParameter("@endTime", form.EndTime.ToString("d")),
                                        new OleDbParameter("beforeDay", form.BeforeDay) };
            cmd.Parameters.AddRange(param);

            cmd.ExecuteNonQuery();

            // 关闭资源连接
            closeAll(con, cmd, null);
        
        }

        /*
         *通过 id  删除具体的 BumRemind 
         */
        public void deleteById(int id) {
            String sql = "delete from BumRemind where id=" + id;

            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);

            cmd.ExecuteNonQuery();

            // 关闭资源连接
            closeAll(con, cmd, null);

        }

        /*
         *通过 id  修改 BumRemind 
         */
        public void updateById(BumRemind form) {
            String sql = "update BumRemind set userId=@userId, title=@title, "+
                                    "content=@content, endTime=@endTime, beforeDay=@beforeDay where id=@id";
            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);

            OleDbParameter[] param = { new OleDbParameter("@userId",form.UserId),  new OleDbParameter("@title", form.Title),
                                        new OleDbParameter("@content", form.Content), new OleDbParameter("@endTime", form.EndTime.ToString("d")),
                                        new OleDbParameter("beforeDay", form.BeforeDay), new OleDbParameter("@id", form.Id) };
            cmd.Parameters.AddRange(param);

            cmd.ExecuteNonQuery();
            
            // 关闭资源连接
            closeAll(con, cmd, null);

        }
        /*
         * 通过 id 获取 BumRemin 
         * 
         */ 
        public BumRemind getById(int id) {
            String sql = "select * from BumRemind where id=" + id;

            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);

            BumRemind bRemind = null;
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) {
                bRemind = new BumRemind();

                bRemind.Id = reader.GetInt32(0);
                bRemind.UserId = reader.GetInt32(1);
                bRemind.Title = reader.GetString(2);
                bRemind.Content = reader.GetString(3);
                bRemind.EndTime = reader.GetDateTime(4);
                bRemind.BeforeDay = reader.GetInt32(5);

                    
            }

            // 关闭资源连接
            closeAll(con, cmd, reader);

            return bRemind;
        }

        /*
         * 通过 userId 获取该 用户 所有的 BumRemind
         * return List
         */
        public List<BumRemind> getByUserIdList(int userId) {
            List<BumRemind> list = new List<BumRemind>();
            String sql = "select * from BumRemind where userId=" + userId;

            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                BumRemind bRemind = new BumRemind();

                bRemind.Id = reader.GetInt32(0);
                bRemind.UserId = reader.GetInt32(1);
                bRemind.Title = reader.GetString(2);
                bRemind.Content = reader.GetString(3);
                bRemind.EndTime = reader.GetDateTime(4);
                bRemind.BeforeDay = reader.GetInt32(5);

                list.Add(bRemind);
            }

            // 关闭资源连接
            closeAll(con, cmd, reader);

            return list;
        }
        /*
        * 通过 userId 获取该 用户 所有的 BumRemind
        * return DateSet
        */
        public DataSet getByUserIdDataSet(int userId){

            String sql = "select * from BumRemind where userId=" + userId;

            OleDbConnection con = getCon(null);
            OleDbCommand cmd = new OleDbCommand(sql, con);

            DataSet  ds = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(ds);
            //释放资源 adapter
            adapter.Dispose();

            closeAll(con, cmd, null);

            return ds;
        }



        
    }
}
