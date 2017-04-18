// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Cars.cs
// 项目名称：买车网
// 创建时间：2016/8/29
// 负责人：杨晓光
// ===================================================================
using System;
using System.Collections.Generic;
using System.Text;
using AutoRepair.DAL;
using AutoRepair.Entity;

namespace AutoRepair.BLL
{
    public partial class tb_CarsBLL : BaseBLL< tb_CarsBLL>

    {
        tb_CarsDataAccessLayer tb_Carsdal;
        public tb_CarsBLL()
        {
            tb_Carsdal = new tb_CarsDataAccessLayer();
        }

        public int Insert(tb_CarsEntity tb_CarsEntity)
        {
            return tb_Carsdal.Insert(tb_CarsEntity);            
        }

        public void Update(tb_CarsEntity tb_CarsEntity)
        {
            tb_Carsdal.Update(tb_CarsEntity);
        }

        public tb_CarsEntity GetAdminSingle(int carId)
        {
           return tb_Carsdal.Get_tb_CarsEntity(carId);
        }

        public IList<tb_CarsEntity> Gettb_CarsList()
        {
            IList<tb_CarsEntity> tb_CarsList = new List<tb_CarsEntity>();
            tb_CarsList=tb_Carsdal.Get_tb_CarsAll();
            return tb_CarsList;
        }
        /// <summary>
        /// 获取自己的车辆信息
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public IList<tb_CarsEntity> Gettb_CarsUserIdList(int userid)
        {
            IList<tb_CarsEntity> tb_CarsList = new List<tb_CarsEntity>();
            tb_CarsList = tb_Carsdal.Gettb_CarsUserIdList(userid);
            return tb_CarsList;
        }
        /// <summary>
        /// 根据车排行判断数据是否存在
        /// </summary>
        /// <param name="carNum">车牌号</param>
        /// <returns></returns>
        public bool GetCarsModelByCarNum(string carNum)
        {
            return tb_Carsdal.GetCarsModelByCarNum(carNum);
        }
        /// <summary>
        /// 根据手机号查询是否有绑定车辆
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool IsCarsByUserId(int userId)
        {
            return tb_Carsdal.IsCarsByUserId(userId);
        }
    }
}
