using AutoRepair.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class car_EvaluationDetails :BasePage// System.Web.UI.Page
{
    public string Isbool = String.Empty;
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
    protected void Page_Load(object sender, EventArgs e)
    {
  
    }
    protected override void BasePage_Load(tb_UsersEntity user)
    {
        if (user != null)
        {
            DataSet ds = AutoRepair.BLL.tb_EvaluateBLL.GetInstance().GetEvaluationDetail(id);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                Isbool = ds.Tables[0].Rows[0]["AssessCount2"].ToString();

                rptEvaluation.DataSource = ds;
                rptEvaluation.DataBind();
            }  
        }
    }
    /// <summary>
    /// 根据评分，判断星级
    /// </summary>
    /// <param name="star"></param>
    /// <returns></returns>
    public string star(float star)
    {
        if (star.ToString() == "")
        {
            return "<div class=\"star\" style=\" background-position:-0px -75px;\"></div>";
        }
        if (star >= 0 && star <= 10)
        {
            return "<div class=\"star\" style=\" background-position:-0px -95px;\"></div>";
        }
        if (star >= 10 && star <= 20)
        {
            return "<div class=\"star\" style=\"background-position:-0px -115px;\"></div>";
        }
        if (star >= 20 && star <= 30)
        {
            return "<div class=\"star\" style=\"background-position:-0px -135px;\"></div>";
        }
        if (star >= 30 && star <= 40)
        {
            return "<div class=\"star\" style=\"background-position:-0px -155px;\"></div>";
        }
        if (star >= 40 && star <= 50)
        {
            return "<div class=\"star\" style=\" background-position:-0px -175px;\"></div>";
        }
        if (star >= 50 && star <= 60)
        {
            return "<div class=\"star\" style=\" background-position:-0px -195px;\"></div>";
        }
        if (star >= 60 && star <= 70)
        {
            return "<div class=\"star\" style=\" background-position:-0px -215px;\"></div>";
        }
        if (star >= 70 && star <= 80)
        {
            return "<div class=\"star\" style=\"background-position:-0px -235px;\"></div>";
        }
        if (star >= 80 && star <= 90)
        {
            return "<div class=\"star\" style=\"background-position:-0px -255px;\"></div>";
        }
        if (star >= 90 && star <= 100)
        {
            return "<div class=\"star\" style=\"background-position:-0px -275px;\"></div>";
        }
        return "<div class=\"star\" style=\"background-position: -0px -75px;\"></div>";
    }
}