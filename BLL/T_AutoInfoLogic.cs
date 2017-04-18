// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： T_AutoInfo.cs
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
    public partial class T_AutoInfoBLL : BaseBLL< T_AutoInfoBLL>

    {
        T_AutoInfoDataAccessLayer t_AutoInfodal;
        public T_AutoInfoBLL()
        {
            t_AutoInfodal = new T_AutoInfoDataAccessLayer();
        }

        public int Insert(T_AutoInfoEntity t_AutoInfoEntity)
        {
            return t_AutoInfodal.Insert(t_AutoInfoEntity);            
        }

        public void Update(T_AutoInfoEntity t_AutoInfoEntity)
        {
            t_AutoInfodal.Update(t_AutoInfoEntity);
        }

        public T_AutoInfoEntity GetAdminSingle(int iD)
        {
           return t_AutoInfodal.Get_T_AutoInfoEntity(iD);
        }

        public IList<T_AutoInfoEntity> GetT_AutoInfoList()
        {
            IList<T_AutoInfoEntity> t_AutoInfoList = new List<T_AutoInfoEntity>();
            t_AutoInfoList=t_AutoInfodal.Get_T_AutoInfoAll();
            return t_AutoInfoList;
        }
        public T_AutoInfoEntity Get_CarinDetailOne(string PlateNumber)
        {
            return t_AutoInfodal.Get_CarinDetailOne(PlateNumber);
        }
    }
}
