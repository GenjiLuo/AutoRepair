// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_RepairCL.cs
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
    public partial class T_RepairCLBLL : BaseBLL< T_RepairCLBLL>

    {
        T_RepairCLDataAccessLayer t_RepairCLdal;
        public T_RepairCLBLL()
        {
            t_RepairCLdal = new T_RepairCLDataAccessLayer();
        }

        public int Insert(T_RepairCLEntity t_RepairCLEntity)
        {
            return t_RepairCLdal.Insert(t_RepairCLEntity);            
        }

        public void Update(T_RepairCLEntity t_RepairCLEntity)
        {
            t_RepairCLdal.Update(t_RepairCLEntity);
        }

        public T_RepairCLEntity GetAdminSingle(int iD)
        {
           return t_RepairCLdal.Get_T_RepairCLEntity(iD);
        }

        public IList<T_RepairCLEntity> GetT_RepairCLList()
        {
            IList<T_RepairCLEntity> t_RepairCLList = new List<T_RepairCLEntity>();
            t_RepairCLList=t_RepairCLdal.Get_T_RepairCLAll();
            return t_RepairCLList;
        }
        /// <summary>
        /// 维修ID查询详情
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IList<T_RepairCLEntity> Gettb_DocumentID_CL_List(int Id)
        {
            IList<T_RepairCLEntity> t_RepairCLList = new List<T_RepairCLEntity>();
            t_RepairCLList = t_RepairCLdal.Gettb_DocumentID_CL_List(Id);
            return t_RepairCLList;
        }
    }
}
