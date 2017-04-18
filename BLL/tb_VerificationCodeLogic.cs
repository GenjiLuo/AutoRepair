// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_VerificationCode.cs
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
    public partial class tb_VerificationCodeBLL : BaseBLL< tb_VerificationCodeBLL>

    {
        tb_VerificationCodeDataAccessLayer tb_VerificationCodedal;
        public tb_VerificationCodeBLL()
        {
            tb_VerificationCodedal = new tb_VerificationCodeDataAccessLayer();
        }

        public int Insert(tb_VerificationCodeEntity tb_VerificationCodeEntity)
        {
            return tb_VerificationCodedal.Insert(tb_VerificationCodeEntity);            
        }

        public void Update(tb_VerificationCodeEntity tb_VerificationCodeEntity)
        {
            tb_VerificationCodedal.Update(tb_VerificationCodeEntity);
        }

        public tb_VerificationCodeEntity GetAdminSingle(int verificationId)
        {
           return tb_VerificationCodedal.Get_tb_VerificationCodeEntity(verificationId);
        }

        public IList<tb_VerificationCodeEntity> Gettb_VerificationCodeList()
        {
            IList<tb_VerificationCodeEntity> tb_VerificationCodeList = new List<tb_VerificationCodeEntity>();
            tb_VerificationCodeList=tb_VerificationCodedal.Get_tb_VerificationCodeAll();
            return tb_VerificationCodeList;
        }
        
        /// <summary>
        /// 根据手机号获取实体
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        public tb_VerificationCodeEntity GetVerificationCodeModelByPhone(string phone)
        {
            return tb_VerificationCodedal.GetVerificationCodeModelByPhone(phone);
        }
    }
}
