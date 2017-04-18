// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairDocument.cs
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
    /// 数据层实例化接口类 dbo.T_RepairDocument.
    /// </summary>
    public partial class T_RepairDocumentDataAccessLayer 
    {
        /// <summary>
        /// 获取维修记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetRepairDocumentInforList(string openid)
        {
            IList<T_RepairDocumentEntity> Obj = new List<T_RepairDocumentEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@openid",SqlDbType.VarChar)
			};
            _param[0].Value = openid;
            string sqlStr = "SELECT TOP 1000 [FinishDate],[UnitID],[PlateNumber],[UnitName],[TotalMoney],[RepairNumber],[Type],[ID],[UserId] ,[OpenID] FROM [dbo].[v_MaintenanceRecord]  where OpenID=@openid order by FinishDate desc ";
            return SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param);
        } 
        /// <summary>
        /// 根据天数查找相应统计数据
        /// </summary>
        /// <param name="unitId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public DataSet GetRepairDocumentListByDateTime(string unitId, DateTime startTime, DateTime endTime)
        {
            SqlParameter[] _param={
                    new SqlParameter("@UnitID",SqlDbType.VarChar),
                    new SqlParameter("@StartTime",SqlDbType.DateTime),
                    new SqlParameter("@EndTime",SqlDbType.DateTime)
             };
            _param[0].Value=unitId;
            _param[1].Value=startTime;
            _param[2].Value=endTime;
            return SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.StoredProcedure, "[pro_RepairDocumentCount]", _param);
        }
        /// <summary>
        /// 获取维修已评价数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetRepairEvaluationList(string openid)
        {
            IList<T_RepairDocumentEntity> Obj = new List<T_RepairDocumentEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@openid",SqlDbType.VarChar)
			};
            _param[0].Value = openid;
            string sqlStr = "SELECT TOP 1000 [AddTime],[AssessCount],[RepairNumber],[ID],[UnitName],[PlateNumber],[OpenID] FROM [dbo].[v_OrderEvaluate]  where OpenID=@openid order by AddTime desc ";
            return SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        ///  获取【去评价】和【追评】的维修记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetRepairEvaluationByType(string openid)
        {
            IList<T_RepairDocumentEntity> Obj = new List<T_RepairDocumentEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@openid",SqlDbType.VarChar)
			};
            _param[0].Value = openid;
            string sqlStr = "SELECT TOP 1000 [FinishDate],[UnitID],[PlateNumber],[UnitName],[TotalMoney],[RepairNumber],[Type],[ID],[UserId] ,[OpenID] FROM [dbo].[v_MaintenanceRecord]  where OpenID=@openid and Type<>2 order by FinishDate desc ";
            return SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param);
        }
        /// <summary>
        /// 查询所有企业信息 作业情况
        /// </summary>
        /// <returns></returns>
        public DataSet Get_RepairListByArea(string area)
        {
            string sqlStr = "  SELECT * FROM [T_RepairUnit] AS a outer apply (select count(1) num from T_RepairDocument where UnitID=a.[UnitID] and SignDate<GETDATE() )b outer apply (select count(1) numjin from T_RepairDocument where UnitID=a.[UnitID] and SignDate<GETDATE() and FinishDate<null) c outer apply (select count(1) numchu from T_RepairDocument where UnitID=a.[UnitID] and SignDate<GETDATE()) d outer apply (select sum([TotalMoney]) picenum from T_RepairDocument where UnitID=a.[UnitID] and SignDate<GETDATE()) e  where Area = @Area";
            SqlParameter[] _param = {
                        new SqlParameter("@Area",SqlDbType.VarChar)
             };
            _param[0].Value = area;
            DataSet ds = SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr,_param);
            return ds;
        }

        /// <summary>
        /// 根据市查询所有企业信息 作业情况
        /// </summary>
        /// <returns></returns>
        public DataSet Get_RepairListByAreaList(string area)
        {
            string sqlStr = "  SELECT * FROM [T_RepairUnit] AS a outer apply (select count(1) num from T_RepairDocument where UnitID=a.[UnitID] and SignDate<GETDATE() )b outer apply (select count(1) numjin from T_RepairDocument where UnitID=a.[UnitID] and SignDate<GETDATE() and FinishDate<null) c outer apply (select count(1) numchu from T_RepairDocument where UnitID=a.[UnitID] and SignDate<GETDATE()) d outer apply (select sum([TotalMoney]) picenum from T_RepairDocument where UnitID=a.[UnitID] and SignDate<GETDATE()) e  where Area in("+area+")";
            DataSet ds = SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr);
            return ds;
        }

        /// <summary>
        /// 根据地区获取维修企业当日信息数据
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public DataSet GetUnitCountRepairByArea(string area)
        {
            string sqlStr = "SELECT a.*,c.weixuishu FROM [dbo].[T_RepairUnit] as a outer apply(select COUNT(ID) as weixuishu from dbo.T_RepairDocument as b where a.UnitID=b.UnitID and FinishDate=GETDATE()) as c where a.Area=@Area";
            SqlParameter[] _param ={
                    new SqlParameter("@Area",SqlDbType.VarChar)
               };
            _param[0].Value = area;
            DataSet ds = SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr,_param);
            return ds;
        }

        /// <summary>
        /// 根据地区获取维修企业当日信息数据
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public DataSet GetUnitCountRepairByAreaList(string area)
        {
            string sqlStr = "SELECT a.*,c.weixuishu FROM [dbo].[T_RepairUnit] as a outer apply(select COUNT(ID) as weixuishu from dbo.T_RepairDocument as b where a.UnitID=b.UnitID and FinishDate=GETDATE()) as c where a.Area in("+area+")";
            DataSet ds = SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr);
            return ds;
        }
	}
}
