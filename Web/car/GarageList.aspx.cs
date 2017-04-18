using AutoRepair.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class car_GarageList :BasePage// System.Web.UI.Page
{
    public string pingjia = String.Empty;//评价
    public string record = String.Empty;//维修记录
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected override void BasePage_Load(tb_UsersEntity user)
    {
        if (user != null)
        {
            DataSet ds = AutoRepair.BLL.T_RepairDocumentBLL.GetInstance().GetRepairDocumentInforList(user.OpenID);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
            {
                rptRepairList.DataSource = ds;
                rptRepairList.DataBind();
            }
            else
            {
                record = "<div style=\"font-size:15px;color:#d5d2d2;position:fixed;top:35%;left:30%;\">还没有维修记录……</div>";
            }
        } 
    }
    //判断评价状态
    public string PingList(int type,int Id,string unitid)
    {
        if (type == 1)
        {
            return "<div class=\"content_foot_pingjia\"><a href=\"EvaluationCar.aspx?id=" + Id + "&type=" + type + "\">追评</a></div>";
        }
        if (type == 2)
        {
            return "<div style=\"background-color:#787373\" class=\"content_foot_pingjia\"><a href=\"EvaluationDetails.aspx?id=" + Id + "\">已评价</a></div>";
        }

        return "<div class=\"content_foot_pingjia\"><a href=\"EvaluationCar.aspx?id=" + Id + " &Unitid=" + unitid + "\">去评价</a></div>";
    }
}

