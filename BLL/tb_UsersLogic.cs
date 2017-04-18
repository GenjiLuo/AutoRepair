// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Users.cs
// 项目名称：买车网
// 创建时间：2016/8/29
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
    public partial class tb_UsersBLL : BaseBLL< tb_UsersBLL>

    {
        tb_UsersDataAccessLayer tb_Usersdal;
        public tb_UsersBLL()
        {
            tb_Usersdal = new tb_UsersDataAccessLayer();
        }

        public int Insert(tb_UsersEntity tb_UsersEntity)
        {
            return tb_Usersdal.Insert(tb_UsersEntity);            
        }

        public void Update(tb_UsersEntity tb_UsersEntity)
        {
            tb_Usersdal.Update(tb_UsersEntity);
        }

        public tb_UsersEntity GetAdminSingle(int userId)
        {
           return tb_Usersdal.Get_tb_UsersEntity(userId);
        }

        public IList<tb_UsersEntity> Gettb_UsersList()
        {
            IList<tb_UsersEntity> tb_UsersList = new List<tb_UsersEntity>();
            tb_UsersList=tb_Usersdal.Get_tb_UsersAll();
            return tb_UsersList;
        }
        /// <summary>
        /// 手机号和密码匹配
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public tb_UsersEntity GetUsersModelByPhoneAndOpenID(string phone, string openId)
        {
            return tb_Usersdal.GetUsersModelByPhoneAndOpenID(phone, openId);
        }
        /// <summary>
        /// 判断师是否存在数据
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        public bool GetUsersModelByPhone(string phone)
        {
            return tb_Usersdal.GetUsersModelByPhone(phone);
        }

        public tb_UsersEntity GetModelByOpenId(string openid)
        {
            return tb_Usersdal.GetModelByOpenId(openid);
        }
        /// <summary>
        ///  根据用户的openid获取多有信息
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        public DataSet Get_useropenid(string openid)
        {
            return tb_Usersdal.Get_useropenid(openid);
        }
    }
}
