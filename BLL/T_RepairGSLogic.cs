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
using System.Collections.Generic;
using System.Text;
using AutoRepair.DAL;
using AutoRepair.Entity;

namespace AutoRepair.BLL
{
    public partial class T_RepairGSBLL : BaseBLL< T_RepairGSBLL>

    {
        T_RepairGSDataAccessLayer t_RepairGSdal;
        public T_RepairGSBLL()
        {
            t_RepairGSdal = new T_RepairGSDataAccessLayer();
        }

        public int Insert(T_RepairGSEntity t_RepairGSEntity)
        {
            return t_RepairGSdal.Insert(t_RepairGSEntity);            
        }

        public void Update(T_RepairGSEntity t_RepairGSEntity)
        {
            t_RepairGSdal.Update(t_RepairGSEntity);
        }

        public T_RepairGSEntity GetAdminSingle(int iD)
        {
           return t_RepairGSdal.Get_T_RepairGSEntity(iD);
        }

        public IList<T_RepairGSEntity> GetT_RepairGSList()
        {
            IList<T_RepairGSEntity> t_RepairGSList = new List<T_RepairGSEntity>();
            t_RepairGSList=t_RepairGSdal.Get_T_RepairGSAll();
            return t_RepairGSList;
        }
        /// <summary>
        /// 维修ID查询详情
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IList<T_RepairGSEntity> Gettb_DocumentID_GS_List(int Id)
        {
            IList<T_RepairGSEntity> t_RepairGSList = new List<T_RepairGSEntity>();
            t_RepairGSList = t_RepairGSdal.Gettb_DocumentID_GS_List(Id);
            return t_RepairGSList;
        }
    }
}
