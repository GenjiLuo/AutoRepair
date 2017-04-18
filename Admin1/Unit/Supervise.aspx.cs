using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Unit_Supervise : BasePage//System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    public void BindData()
    {
        string s = String.Empty;
        if (identity != null)
        {
            if (identity.DepartmentId > 0)
            {
                AutoRepair.Entity.tb_LocationEntity model = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetAdminSingle(identity.LocationId);
                if (model != null)
                {
                    s += "and Address like '%" + model.LocationName + "%'";
                }
            }
        }

        if (!string.IsNullOrEmpty(this.txtProductName.Text))
        {
            s += " and UnitName like '%" + this.txtProductName.Text.Trim() + "%'";
        }
        if (!string.IsNullOrEmpty(this.txtBuyer.Text.Trim()))
        {
            s += " and LinkMan = '" + this.txtBuyer.Text.Trim() + "'";
        }

        int allCount;
        int CurrentPage = 0;
        CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = AutoRepair.BLL.T_RepairUnitBLL.GetInstance().GetT_RepairUnitData(pager1.PageSize, CurrentPage, " 1=1 " + s, out allCount);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            rptTaskList.DataSource = ds;
            rptTaskList.DataBind();
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            rptTaskList.DataSource = string.Empty;
            rptTaskList.DataBind();
        }

    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        int currentPage = 1;   //默认显示第一页
        if (!string.IsNullOrEmpty(Request.QueryString["page"]))
        {
            currentPage = int.Parse(Request.QueryString["page"]);
        }   //通过网页get方式获取当前页码
        BindData();
    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        BindData();
    }
}