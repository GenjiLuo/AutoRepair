// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairJG.cs
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
    public partial class T_RepairJGBLL : BaseBLL< T_RepairJGBLL>

    {
        T_RepairJGDataAccessLayer t_RepairJGdal;
        public T_RepairJGBLL()
        {
            t_RepairJGdal = new T_RepairJGDataAccessLayer();
        }

        public int Insert(T_RepairJGEntity t_RepairJGEntity)
        {
            return t_RepairJGdal.Insert(t_RepairJGEntity);            
        }

        public void Update(T_RepairJGEntity t_RepairJGEntity)
        {
            t_RepairJGdal.Update(t_RepairJGEntity);
        }

        public T_RepairJGEntity GetAdminSingle(int iD)
        {
           return t_RepairJGdal.Get_T_RepairJGEntity(iD);
        }

        public IList<T_RepairJGEntity> GetT_RepairJGList()
        {
            IList<T_RepairJGEntity> t_RepairJGList = new List<T_RepairJGEntity>();
            t_RepairJGList=t_RepairJGdal.Get_T_RepairJGAll();
            return t_RepairJGList;
        }
        /// <summary>
        /// 维修ID查询详情
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IList<T_RepairJGEntity> Gettb_DocumentID_JG_List(int Id)
        {
            IList<T_RepairJGEntity> t_RepairJGList = new List<T_RepairJGEntity>();
            t_RepairJGList = t_RepairJGdal.Gettb_DocumentID_JG_List(Id);
            return t_RepairJGList;
        }
    }
}
