// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Users.cs
// 项目名称：买车网
// 创建时间：2016/8/29
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using AutoRepair.Entity;
using Jnwf.Utils.Data;


namespace AutoRepair.DAL
{
    /// <summary>
    /// 数据层实例化接口类 dbo.tb_Users.
    /// </summary>
    public partial class tb_UsersDataAccessLayer 
    {
        /// <summary>
        /// 用户名手机号和密码登录 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public tb_UsersEntity GetUsersModelByPhoneAndOpenID(string phone, string openId)
        {
            tb_UsersEntity _obj = null;
            string sqlStr = "select * from tb_Users with(nolock) where Phone=@Phone and OpenID = @OpenID ";
            SqlParameter[] _param = { 
                        new SqlParameter("@Phone",SqlDbType.VarChar),
                        new SqlParameter("@OpenID",SqlDbType.VarChar)
                 };
            _param[0].Value = phone;
            _param[1].Value = openId;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_UsersEntity_FromDr(dr);
                }
            }
            return _obj;
        }
        /// <summary>
        /// 判断师是否存在数据
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        public bool GetUsersModelByPhone(string phone)
        {
            string sqlStr = "select count(UserId) from tb_Users with(nolock) where Phone=@Phone";
            SqlParameter[] _param = {  
                        new SqlParameter("@Phone",SqlDbType.VarChar)
                 };
            _param[0].Value = phone;
            object obj = SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param);
            return Convert.ToInt32(obj) > 0 ? true : false;
        }

        public tb_UsersEntity GetModelByOpenId(string openid)
        {
            tb_UsersEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@OpenId", SqlDbType.VarChar)
			};
            _param[0].Value = openid;
            string sqlStr = "select * from tb_Users with(nolock) where OpenID = @OpenID";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_UsersEntity_FromDr(dr);
                }
            }
            return _obj;
        }
      /// <summary>
        /// 根据用户的openid获取多有信息
      /// </summary>
      /// <param name="openid"></param>
      /// <returns></returns>
        public DataSet Get_useropenid(string openid)
        {
            SqlParameter[] _param ={
			new SqlParameter("@OpenId", SqlDbType.VarChar)
			};
            _param[0].Value = openid;
            string sqlStr = "select * from[weipingtai].[dbo].[tb_OpenID_User] with(nolock) where OpenID = @OpenID";
            return SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param);

        }
      
	}
}
