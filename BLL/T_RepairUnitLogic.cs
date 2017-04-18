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
using System.Collections.Generic;
using System.Text;
using AutoRepair.DAL;
using AutoRepair.Entity;
using System.Data;

namespace AutoRepair.BLL
{
    public partial class T_RepairUnitBLL : BaseBLL< T_RepairUnitBLL>

    {
        T_RepairUnitDataAccessLayer t_RepairUnitdal;
        public T_RepairUnitBLL()
        {
            t_RepairUnitdal = new T_RepairUnitDataAccessLayer();
        }

        public int Insert(T_RepairUnitEntity t_RepairUnitEntity)
        {
            return t_RepairUnitdal.Insert(t_RepairUnitEntity);            
        }

        public void Update(T_RepairUnitEntity t_RepairUnitEntity)
        {
            t_RepairUnitdal.Update(t_RepairUnitEntity);
        }

        public T_RepairUnitEntity GetAdminSingle(string unitID)
        {
           return t_RepairUnitdal.Get_T_RepairUnitEntity(unitID);
        }

        public IList<T_RepairUnitEntity> GetT_RepairUnitList()
        {
            IList<T_RepairUnitEntity> t_RepairUnitList = new List<T_RepairUnitEntity>();
            t_RepairUnitList=t_RepairUnitdal.Get_T_RepairUnitAll();
            return t_RepairUnitList;
        }
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="pagesize">页数</param>
        /// <param name="currentindex">当前页</param>
        /// <param name="condition">条件</param>
        /// <param name="allcount">返回总条数</param>
        /// <returns></returns>
        public DataSet GetT_RepairUnitData(int pagesize, int currentindex, string condition, out int allcount)
        {
            return PageData.GetDataByPage("v_RepairUnit", "UnitID", "UnitID desc", currentindex, pagesize, "*", condition, out allcount);
        }
         /// <summary>
        /// 获取地区统计维修厂
        /// </summary>
        /// <returns></returns>
        public DataSet GetRepairUnitStatistics(string where)
        {
            return t_RepairUnitdal.GetRepairUnitStatistics(where);
        }
        /// <summary>
        /// 根据企业评分进行排序
        /// </summary>
        /// <returns></returns>
        public DataSet GetRepairUnitScoreDsec()
        {
            return t_RepairUnitdal.GetRepairUnitScoreDsec();
        }
        /// <summary>
        /// 根据城市名称获取维修企业信息
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public IList<T_RepairUnitEntity> GetRepairUnitListByCityName(string area)
        {
            return t_RepairUnitdal.GetRepairUnitListByCityName(area);
        }
         /// <summary>
        /// 根据条件查询地区
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IList<T_RepairUnitEntity> GetRepairUnitListByWhere(string where)
        {
            return t_RepairUnitdal.GetRepairUnitListByWhere(where);
        }
        
             /// <summary>
        /// 查询T_RepairUnitEntity、T_RepairDocument表中的企业名称，金额，维系数量
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public DataSet GetRepairUnitListBy(string where)
        {
            return t_RepairUnitdal.GetRepairUnitListBy(where);
        }
    }
}
