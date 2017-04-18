using AutoRepair.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class car_EvaluationCar : BasePage//System.Web.UI.Page
{
    public int AssessId = 0;//评价ID
    public int unitid
    {
        get
        {
            object obj = Request.QueryString["Unitid"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    public int id
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    public int type
    {
        get
        {
            object obj = Request.QueryString["type"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    protected override void BasePage_Load(tb_UsersEntity user)
    {
        if (user != null)
        {
            BindData();
        }
    }
    public void BindData()
    {
        //获取维修工单评价
        IList<AutoRepair.Entity.tb_EvaluateEntity> model = AutoRepair.BLL.tb_EvaluateBLL.GetInstance().Gettb_EvaluateIdList(id);
        if (model != null)
        {
            rptEvaluate.DataSource = model;
            rptEvaluate.DataBind();
            foreach (tb_EvaluateEntity eval in model)
            {
                AssessId = eval.AssessId;//获取评价ID
            }
        }
    }
}