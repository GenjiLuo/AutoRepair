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
using System.Collections.Generic;
using System.Text;
using AutoRepair.DAL;
using AutoRepair.Entity;
using System.Data;

namespace AutoRepair.BLL
{
    public partial class T_RepairDocumentBLL : BaseBLL< T_RepairDocumentBLL>

    {
        T_RepairDocumentDataAccessLayer t_RepairDocumentdal;
        public T_RepairDocumentBLL()
        {
            t_RepairDocumentdal = new T_RepairDocumentDataAccessLayer();
        }

        public int Insert(T_RepairDocumentEntity t_RepairDocumentEntity)
        {
            return t_RepairDocumentdal.Insert(t_RepairDocumentEntity);            
        }

        public void Update(T_RepairDocumentEntity t_RepairDocumentEntity)
        {
            t_RepairDocumentdal.Update(t_RepairDocumentEntity);
        }

        public T_RepairDocumentEntity GetAdminSingle(int iD)
        {
           return t_RepairDocumentdal.Get_T_RepairDocumentEntity(iD);
        }

        public IList<T_RepairDocumentEntity> GetT_RepairDocumentList()
        {
            IList<T_RepairDocumentEntity> t_RepairDocumentList = new List<T_RepairDocumentEntity>();
            t_RepairDocumentList=t_RepairDocumentdal.Get_T_RepairDocumentAll();
            return t_RepairDocumentList;
        }
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="pagesize">页数</param>
        /// <param name="currentindex">当前页</param>
        /// <param name="condition">条件</param>
        /// <param name="allcount">返回总条数</param>
        /// <returns></returns>
        public DataSet GetT_RepairDocumentList(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_T_RepairDocument", "ID", "ID desc", currentindex, pagesize, "*", condition, out allcount);
        }
         /// <summary>
        /// 获取维修记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetRepairDocumentInforList(string openid)
        {
            return t_RepairDocumentdal.GetRepairDocumentInforList(openid);
        }
         /// <summary>
        /// 根据天数查找相应统计数据
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        public DataSet GetRepairDocumentListByDateTime(string unitId, DateTime startTime, DateTime endTime)
        {
            return t_RepairDocumentdal.GetRepairDocumentListByDateTime(unitId,startTime,endTime);
        }
        /// <summary>
        /// 获取维修已评价数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetRepairEvaluationList(string openid)
        {
            return t_RepairDocumentdal.GetRepairEvaluationList(openid);
        }

        public DataSet GetRepairEvaluationByType(string openid)
        {
            return t_RepairDocumentdal.GetRepairEvaluationByType(openid);
        }
        /// <summary>
        /// 查询所有企业信息 作业情况
        /// </summary>
        /// <returns></returns>
        public DataSet Get_RepairListByArea(string area)
        {
            return t_RepairDocumentdal.Get_RepairListByArea(area);
        }
         /// <summary>
        /// 根据市查询所有企业信息 作业情况
        /// </summary>
        /// <returns></returns>
        public DataSet Get_RepairListByAreaList(string area)
        {
            return t_RepairDocumentdal.Get_RepairListByAreaList(area);
        }
         /// <summary>
        /// 根据地区获取维修企业当日信息数据
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public DataSet GetUnitCountRepairByArea(string area)
        {
            return t_RepairDocumentdal.GetUnitCountRepairByArea(area);
        }
        /// <summary>
        /// 根据地区获取维修企业当日信息数据
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public DataSet GetUnitCountRepairByAreaList(string area)
        {
            return t_RepairDocumentdal.GetUnitCountRepairByAreaList(area);
        }
    }
}
