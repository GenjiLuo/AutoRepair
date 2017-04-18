// =================================================================== 
// 项目说明
//====================================================================
// 杨晓光。@Copy Right 2014
// 文件： tb_Evaluate.cs
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
    public partial class tb_EvaluateBLL : BaseBLL< tb_EvaluateBLL>

    {
        tb_EvaluateDataAccessLayer tb_Evaluatedal;
        public tb_EvaluateBLL()
        {
            tb_Evaluatedal = new tb_EvaluateDataAccessLayer();
        }

        public int Insert(tb_EvaluateEntity tb_EvaluateEntity)
        {
            return tb_Evaluatedal.Insert(tb_EvaluateEntity);            
        }

        public void Update(tb_EvaluateEntity tb_EvaluateEntity)
        {
            tb_Evaluatedal.Update(tb_EvaluateEntity);
        }

        public tb_EvaluateEntity GetAdminSingle(int assessId)
        {
           return tb_Evaluatedal.Get_tb_EvaluateEntity(assessId);
        }

        public IList<tb_EvaluateEntity> Gettb_EvaluateList()
        {
            IList<tb_EvaluateEntity> tb_EvaluateList = new List<tb_EvaluateEntity>();
            tb_EvaluateList=tb_Evaluatedal.Get_tb_EvaluateAll();
            return tb_EvaluateList;
        }
        public IList<tb_EvaluateEntity> Gettb_EvaluateIdList(int Id)
        {
            IList<tb_EvaluateEntity> tb_EvaluateList = new List<tb_EvaluateEntity>();
            tb_EvaluateList = tb_Evaluatedal.Gettb_EvaluateIdList(Id);
            return tb_EvaluateList;
        }
        public DataSet GetEvaluationDetail(int RecordsId)
        {
            return tb_Evaluatedal.GetEvaluationDetail(RecordsId);
        }
        public tb_EvaluateEntity Gettb_EvaluateById(int RecordsId)
        {
            return tb_Evaluatedal.Gettb_EvaluateById(RecordsId);
        }


        //查询企业评价    刘晓阳 10.14

        public DataSet GetEvaluationBusiness(string where)
        {
            return tb_Evaluatedal.GetEvaluationBusiness(where);
        }


    }
}
