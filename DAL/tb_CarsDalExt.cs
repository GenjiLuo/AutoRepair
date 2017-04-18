// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Cars.cs
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
    /// 数据层实例化接口类 dbo.tb_Cars.
    /// </summary>
    public partial class tb_CarsDataAccessLayer 
    {
      
        public IList<tb_CarsEntity> Gettb_CarsUserIdList(int userid)
        {
            IList<tb_CarsEntity> Obj = new List<tb_CarsEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@userid",SqlDbType.Int)
			};
            _param[0].Value = userid;
            string sqlStr = "select * from tb_Cars with(nolock) where userid=@userid and status=1 order by [CarId] desc";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_CarsEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 根据车排行判断数据是否存在
        /// </summary>
        /// <param name="carNum">车牌号</param>
        /// <returns></returns>
        public bool GetCarsModelByCarNum(string carNum)
        {
            SqlParameter[] _param ={
			new SqlParameter("@CarNum",SqlDbType.VarChar)
			};
            _param[0].Value = carNum;
            string sqlStr = "select Count(CarId) from tb_Cars with(nolock) where CarNum=@CarNum";
            object obj = SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param);
            return Convert.ToInt32(obj)>0?true:false;
        }
        /// <summary>
        /// 根据手机号查询是否有绑定车辆
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool IsCarsByUserId(int userId)
        {
            SqlParameter[] _param ={
			new SqlParameter("@UserId",SqlDbType.Int)
			};
            _param[0].Value = userId;
            string sqlStr = "select Count(CarId) from [dbo].[tb_Cars] with(nolock) where UserId=@UserId and Status=1";
            object obj = SqlHelper.ExecuteScalar(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param);
            return Convert.ToInt32(obj) > 0 ? true : false;
        }
	}
}
