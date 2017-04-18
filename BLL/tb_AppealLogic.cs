// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Appeal.cs
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
    public partial class tb_AppealBLL : BaseBLL< tb_AppealBLL>

    {
        tb_AppealDataAccessLayer tb_Appealdal;
        public tb_AppealBLL()
        {
            tb_Appealdal = new tb_AppealDataAccessLayer();
        }

        public int Insert(tb_AppealEntity tb_AppealEntity)
        {
            return tb_Appealdal.Insert(tb_AppealEntity);            
        }

        public void Update(tb_AppealEntity tb_AppealEntity)
        {
            tb_Appealdal.Update(tb_AppealEntity);
        }

        public tb_AppealEntity GetAdminSingle(int appealId)
        {
           return tb_Appealdal.Get_tb_AppealEntity(appealId);
        }

        public IList<tb_AppealEntity> Gettb_AppealList()
        {
            IList<tb_AppealEntity> tb_AppealList = new List<tb_AppealEntity>();
            tb_AppealList=tb_Appealdal.Get_tb_AppealAll();
            return tb_AppealList;
        }
    }
}
