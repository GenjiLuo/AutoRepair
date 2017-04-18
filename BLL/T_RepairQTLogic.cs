// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairQT.cs
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
    public partial class T_RepairQTBLL : BaseBLL< T_RepairQTBLL>

    {
        T_RepairQTDataAccessLayer t_RepairQTdal;
        public T_RepairQTBLL()
        {
            t_RepairQTdal = new T_RepairQTDataAccessLayer();
        }

        public int Insert(T_RepairQTEntity t_RepairQTEntity)
        {
            return t_RepairQTdal.Insert(t_RepairQTEntity);            
        }

        public void Update(T_RepairQTEntity t_RepairQTEntity)
        {
            t_RepairQTdal.Update(t_RepairQTEntity);
        }

        public T_RepairQTEntity GetAdminSingle(int iD)
        {
           return t_RepairQTdal.Get_T_RepairQTEntity(iD);
        }

        public IList<T_RepairQTEntity> GetT_RepairQTList()
        {
            IList<T_RepairQTEntity> t_RepairQTList = new List<T_RepairQTEntity>();
            t_RepairQTList=t_RepairQTdal.Get_T_RepairQTAll();
            return t_RepairQTList;
        }
        /// <summary>
        /// 维修ID查询详情
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IList<T_RepairQTEntity> Gettb_DocumentID_QT_List(int Id)
        {
            IList<T_RepairQTEntity> t_RepairQTList = new List<T_RepairQTEntity>();
            t_RepairQTList = t_RepairQTdal.Gettb_DocumentID_QT_List(Id);
            return t_RepairQTList;
        }
    }
}
