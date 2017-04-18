// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairUnit.cs
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
    /// 数据层实例化接口类 dbo.T_RepairUnit.
    /// </summary>
    public partial class T_RepairUnitDataAccessLayer 
    {
        /// <summary>
        /// 获取地区统计维修厂
        /// </summary>
        /// <returns></returns>
        public DataSet GetRepairUnitStatistics(string where)
        {
            string sqlStr = "SELECT  COUNT(Area) as Total,b.LocationName,a.Area FROM [dbo].[T_RepairUnit] as a inner join [dbo].[tb_Location] as b on a.Area=b.LocationId {0} group by a.Area,b.LocationName  ";
            sqlStr = string.Format(sqlStr, where);
            return SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr);
        }
        /// <summary>
        /// 根据企业评分，获取企业推荐排名
        /// </summary>
        /// <returns></returns>
        public DataSet GetRepairUnitScoreDsec()
        {
            string sqlStr = " select * from [dbo].[v_Recommend]  order by zonghe  desc";
            return SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr);
        }
        /// <summary>
        /// 根据城市名称获取维修企业信息
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public IList<T_RepairUnitEntity> GetRepairUnitListByCityName(string area)
        {
            IList<T_RepairUnitEntity> Obj = new List<T_RepairUnitEntity>();
            string sqlStr = "select * from T_RepairUnit where Area=@Area";
            SqlParameter[] _param = {
                  new SqlParameter("@Area",SqlDbType.VarChar)
              };
            _param[0].Value = area;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr,_param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_T_RepairUnitEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 根据条件查询地区
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IList<T_RepairUnitEntity> GetRepairUnitListByWhere(string where)
        {
            IList<T_RepairUnitEntity> Obj = new List<T_RepairUnitEntity>();
            string sqlStr = "select * from [dbo].[T_RepairUnit] {0}";
            sqlStr = string.Format(sqlStr, where);
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_T_RepairUnitEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 查询T_RepairUnitEntity、T_RepairDocument表中的企业名称，金额，维系数量
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public DataSet GetRepairUnitListBy(string where)
        {
            string sqlStr = "select count(b.UnitID) as zongshu,SUM(a.TotalMoney) as zongjine,b.UnitName,b.UnitID from T_RepairDocument as a inner join T_RepairUnit as b on a.UnitID=b.UnitID where b.UnitState='正常' {0} group by b.UnitID ,b.UnitName,a.TotalMoney";
            sqlStr = string.Format(sqlStr, where);
            return SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr);
        }
	}
}
