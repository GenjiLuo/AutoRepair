// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Evaluate.cs
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
    /// 数据层实例化接口类 dbo.tb_Evaluate.
    /// </summary>
    public partial class tb_EvaluateDataAccessLayer 
    {
        /// <summary>
        /// 根据维修工单ID，返回tb_EvaluateEntity
        /// </summary>
        /// <param name="RecordsId"></param>
        /// <returns></returns>
        public IList<tb_EvaluateEntity> Gettb_EvaluateIdList(int RecordsId)
        {
            IList<tb_EvaluateEntity> Obj = new List<tb_EvaluateEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@RecordsId",SqlDbType.Int)
			};
            _param[0].Value = RecordsId;
            string sqlStr = "select * from tb_Evaluate with(nolock) where RecordsId=@RecordsId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_tb_EvaluateEntity_FromDr(dr));
                }
            }
            return Obj;
        }
        /// <summary>
        /// 获取评价详情
        /// </summary>
        /// <returns></returns>
        public DataSet GetEvaluationDetail(int RecordsId)
        {
            IList<tb_EvaluateEntity> Obj = new List<tb_EvaluateEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@RecordsId",SqlDbType.VarChar)
			};
            _param[0].Value = RecordsId;
            string sqlStr = "SELECT TOP 1000 [RecordsId],[AssessCount],[AddTime],[AssessCount2],[AddTime2],[AutoUnit],[RepairNumber],[zonghe] FROM [dbo].[v_EvaluateDetails]  where RecordsId=@RecordsId ";
            return SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param);
        } 
         /// <summary>
        /// 根据维修工单ID，返回tb_EvaluateEntity
        /// </summary>
        /// <param name="RecordsId"></param>
        /// <returns></returns>
        public tb_EvaluateEntity Gettb_EvaluateById(int RecordsId)
        {
            tb_EvaluateEntity _obj = null;
            SqlParameter[] _param ={
			new SqlParameter("@RecordsId",SqlDbType.Int)
			};
            _param[0].Value = RecordsId;
            string sqlStr = "select * from tb_Evaluate with(nolock) where RecordsId=@RecordsId";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    _obj = Populate_tb_EvaluateEntity_FromDr(dr);
                }
            }
            return _obj;
        }




      /// <summary>
        /// 表联合查询企业评价    刘晓阳 10.14
      /// </summary>
      /// <param name="where"></param>
      /// <returns></returns>
        public DataSet GetEvaluationBusiness(string where)
        {
            string sqlStr = "select  r.[RepairMan] ,p.UnitID, p.[UnitName] , e.[AddTime],e.[AssessCount],e.[Addtime2] ,e.[AssessCount2] ,(10*(e.Speed+e.Attitude+e.Quality))/3 as zonghe from [tb_Evaluate] as e INNER JOIN   [T_RepairUnit] as p on e.[UnitID] =p.[UnitID] INNER JOIN [T_RepairDocument] as r on e.[RecordsId] =r.[ID] {0}";
            sqlStr = string.Format(sqlStr, where);
            return SqlHelper.ExecuteDataset(WebConfig.AutoRepairRW, CommandType.Text, sqlStr);
        }
	}
}
