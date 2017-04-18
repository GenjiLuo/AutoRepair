// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Subscribe.cs
// 项目名称：买车网
// 创建时间：2016/9/9
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
    public partial class tb_SubscribeBLL : BaseBLL< tb_SubscribeBLL>

    {
        tb_SubscribeDataAccessLayer tb_Subscribedal;
        public tb_SubscribeBLL()
        {
            tb_Subscribedal = new tb_SubscribeDataAccessLayer();
        }

        public int Insert(tb_SubscribeEntity tb_SubscribeEntity)
        {
            return tb_Subscribedal.Insert(tb_SubscribeEntity);            
        }

        public void Update(tb_SubscribeEntity tb_SubscribeEntity)
        {
            tb_Subscribedal.Update(tb_SubscribeEntity);
        }

        public tb_SubscribeEntity GetAdminSingle(int id)
        {
           return tb_Subscribedal.Get_tb_SubscribeEntity(id);
        }

        public IList<tb_SubscribeEntity> Gettb_SubscribeList()
        {
            IList<tb_SubscribeEntity> tb_SubscribeList = new List<tb_SubscribeEntity>();
            tb_SubscribeList=tb_Subscribedal.Get_tb_SubscribeAll();
            return tb_SubscribeList;
        }
        public DataSet Gettb_ReservationRecordList(int userid)
        {
            return tb_Subscribedal.GetReservationRecordList(userid);
        }
        /// <summary>
        /// 近期是否有过预约
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="unitId">维修公司ID</param>
        /// <param name="orderTime">预订时间</param>
        /// <returns></returns>
        public bool IsSubscribeTrue(int userId, string unitId)
        {
            return tb_Subscribedal.IsSubscribeTrue(userId,unitId);
        }
    }
}
