// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Department.cs
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
    public partial class tb_DepartmentBLL : BaseBLL< tb_DepartmentBLL>

    {
        tb_DepartmentDataAccessLayer tb_Departmentdal;
        public tb_DepartmentBLL()
        {
            tb_Departmentdal = new tb_DepartmentDataAccessLayer();
        }

        public int Insert(tb_DepartmentEntity tb_DepartmentEntity)
        {
            return tb_Departmentdal.Insert(tb_DepartmentEntity);            
        }

        public void Update(tb_DepartmentEntity tb_DepartmentEntity)
        {
            tb_Departmentdal.Update(tb_DepartmentEntity);
        }

        public tb_DepartmentEntity GetAdminSingle(int departmentId)
        {
           return tb_Departmentdal.Get_tb_DepartmentEntity(departmentId);
        }

        public IList<tb_DepartmentEntity> Gettb_DepartmentList()
        {
            IList<tb_DepartmentEntity> tb_DepartmentList = new List<tb_DepartmentEntity>();
            tb_DepartmentList=tb_Departmentdal.Get_tb_DepartmentAll();
            return tb_DepartmentList;
        }
        public tb_DepartmentEntity Gettb_DepartmentByUserName(string UserName)
        {
            return tb_Departmentdal.Get_tb_DepartmentByUserName(UserName);
        }

        public tb_DepartmentEntity Gettb_DepartmentByNameAndPwd(string UserName,string UserPwd)
        {
            return tb_Departmentdal.Get_tb_DepartmentByNameAndPwd(UserName,UserPwd);
        }
        public IList<tb_DepartmentEntity> Gettb_DepartmentByAddress(string Address)
        {
            IList<tb_DepartmentEntity> tb_DepartmentList = new List<tb_DepartmentEntity>();
            tb_DepartmentList = tb_Departmentdal.Get_tb_DepartmentByAddress(Address);
            return tb_DepartmentList;
        }
        /// <summary>
        /// 根据县选择
        /// </summary>
        /// <param name="locationid"></param>
        /// <returns></returns>
        public IList<tb_DepartmentEntity> Gettb_DepartmentBylocationid(int locationid)
        {
            IList<tb_DepartmentEntity> tb_DepartmentList = new List<tb_DepartmentEntity>();
            tb_DepartmentList = tb_Departmentdal.Gettb_DepartmentBylocationid(locationid);
            return tb_DepartmentList;
        }
        /// <summary>
        /// 根据市选择  全部的县
        /// </summary>
        /// <param name="LocationParentId"></param>
        /// <returns></returns>
        public IList<tb_DepartmentEntity> Gettb_DepartmentByLocationParentId(int LocationParentId)
        {
            IList<tb_DepartmentEntity> tb_DepartmentList = new List<tb_DepartmentEntity>();
            tb_DepartmentList = tb_Departmentdal.Gettb_DepartmentByLocationParentId(LocationParentId);
            return tb_DepartmentList;
        }
    }
}
