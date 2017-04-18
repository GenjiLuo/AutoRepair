// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Subscribe.cs
// 项目名称：买车网
// 创建时间：2016/9/9
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
    /// 数据层实例化接口类 dbo.tb_Subscribe.
    /// </summary>
    public partial class tb_SubscribeDataAccessLayer 
    {
        /// <summary>
        /// 获取预约记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetReservationRecordList(int userid)
        {
            IList<tb_SubscribeEntity> Obj = new List<tb_SubscribeEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@userid",SqlDbType.Int)
			};
            _param[0].Value = userid;
            string sqlStr = " SELECT TOP 1000 * FROM [dbo].[v_ReservationRecord]  where UserId=@userid and Status>0 order by Addtime desc ";
            return SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 近期是否有过预约
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="unitId">维修公司ID</param>
        /// <param name="orderTime">预订时间</param>
        /// <returns></returns>
        public bool IsSubscribeTrue(int userId, string unitId)
        {
            string sqlStr = "SELECT COUNT(id) FROM [dbo].[tb_Subscribe] where UserId=@UserId and UnitId=@UnitId and DATEDIFF(day,GETDATE(),OrderTime)>=0";
            SqlParameter[] _param ={
			    new SqlParameter("@UserId",SqlDbType.Int),
                new SqlParameter("@UnitId",SqlDbType.VarChar) 
			};
            _param[0].Value = userId;
            _param[1].Value = unitId;
            object obj = SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param);
            return Convert.ToInt32(obj) > 0 ? true : false;
        }
	}
}
