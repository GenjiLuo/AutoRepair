// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_AutoInfo.cs
// 项目名称：买车网
// 创建时间：2016/9/2
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
    /// 数据层实例化接口类 dbo.T_AutoInfo.
    /// </summary>
    public partial class T_AutoInfoDataAccessLayer 
    {
        public T_AutoInfoEntity Get_CarinDetailOne(string PlateNumber)
        {
            T_AutoInfoEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@PlateNumber", SqlDbType.VarChar)
			};
            _param[0].Value = PlateNumber;
            string sqlStr = "select *  from T_AutoInfo where PlateNumber = @PlateNumber";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_T_AutoInfoEntity_FromDr(dr);
                }
            }
            return _obj;
        }
	}
}
