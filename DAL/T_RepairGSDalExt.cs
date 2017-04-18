// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairGS.cs
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
    /// 数据层实例化接口类 dbo.T_RepairGS.
    /// </summary>
    public partial class T_RepairGSDataAccessLayer 
    {
        /// <summary>
        /// 维修ID查询详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<T_RepairGSEntity> Gettb_DocumentID_GS_List(int id)
        {
            IList<T_RepairGSEntity> Obj = new List<T_RepairGSEntity>();
            SqlParameter[] _param ={
			new SqlParameter("@id",SqlDbType.Int)
			};
            _param[0].Value = id;
            string sqlStr = "select * from T_RepairGS with(nolock) where DocumentID=@id ";
            using (SqlDataReader dr = SqlHelper.ExecuteReader(WebConfig.AutoRepairRW, CommandType.Text, sqlStr, _param))
            {
                while (dr.Read())
                {
                    Obj.Add(Populate_T_RepairGSEntity_FromDr(dr));
                }
            }
            return Obj;
        }
	}
}
