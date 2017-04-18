// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairJC.cs
// 项目名称：买车网
// 创建时间：2016/9/2
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using AutoRepair.DAL;
using AutoRepair.Entity;

namespace AutoRepair.BLL
{
    public partial class T_RepairJCBLL : BaseBLL< T_RepairJCBLL>

    {
        T_RepairJCDataAccessLayer t_RepairJCdal;
        public T_RepairJCBLL()
        {
            t_RepairJCdal = new T_RepairJCDataAccessLayer();
        }

        public int Insert(T_RepairJCEntity t_RepairJCEntity)
        {
            return t_RepairJCdal.Insert(t_RepairJCEntity);            
        }

        public void Update(T_RepairJCEntity t_RepairJCEntity)
        {
            t_RepairJCdal.Update(t_RepairJCEntity);
        }

        public T_RepairJCEntity GetAdminSingle(int iD)
        {
           return t_RepairJCdal.Get_T_RepairJCEntity(iD);
        }

        public IList<T_RepairJCEntity> GetT_RepairJCList()
        {
            IList<T_RepairJCEntity> t_RepairJCList = new List<T_RepairJCEntity>();
            t_RepairJCList=t_RepairJCdal.Get_T_RepairJCAll();
            return t_RepairJCList;
        }
        /// <summary>
        /// 维修ID查询详情
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IList<T_RepairJCEntity> Gettb_DocumentID_JC_List(int Id)
        {
            IList<T_RepairJCEntity> t_RepairJCList = new List<T_RepairJCEntity>();
            t_RepairJCList = t_RepairJCdal.Gettb_DocumentID_JC_List(Id);
            return t_RepairJCList;
        }
    }
}
