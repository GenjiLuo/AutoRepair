// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_VerificationCode.cs
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
    /// 数据层实例化接口类 dbo.tb_VerificationCode.
    /// </summary>
    public partial class tb_VerificationCodeDataAccessLayer 
    {
        /// <summary>
        /// 根据手机号获取实体
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        public tb_VerificationCodeEntity GetVerificationCodeModelByPhone(string phone)
        {
            string sqlStr = "select top 1 * from [tb_VerificationCode] where Phone=@Phone and Outtime>=GETDATE() order by VerificationId desc";
            tb_VerificationCodeEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@Phone",SqlDbType.VarChar)
			};
            _param[0].Value = phone; 
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_VerificationCodeEntity_FromDr(dr);
                }
            }
            return _obj;
        }
	}
}
