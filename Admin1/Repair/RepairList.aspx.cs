using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Repair_RepairList : BasePage//System.Web.UI.Page
{
    public string UnitID
    {
        get
        {
            object obj = Request.QueryString["UnitID"];
            if (obj == null)
                return "";
            return obj.ToString();
        }
    }
    public string FinishDate
    {
        get
        {
            object obj = Request.QueryString["FinishDate"];
            if (obj == null)
                return "";
            return obj.ToString();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }
    private void BindData()
    {
        string where = String.Empty; 
        if (identity != null)
        {
            if (identity.DepartmentId > 0)
            {
                AutoRepair.Entity.tb_LocationEntity model = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetAdminSingle(identity.LocationId);
                if (model != null)
                {
                    where += " and Address like '%" + model.LocationName + "%'";
                }
            }
        }
        if (!string.IsNullOrEmpty(UnitID))
        {
            where += " and UnitID='" + UnitID + "'";
        }
        if (!string.IsNullOrEmpty(FinishDate))
        {
            where += " " + FinishDate + "";
        }
        else if (!string.IsNullOrEmpty(this.txtUnitID.Text.Trim()))
        {
            where += "and UnitID='" + this.txtUnitID.Text.Trim() + "'";
        }

        //汽车健康档案卡号
        if (!string.IsNullOrEmpty(this.txtCardKey.Text.Trim()))
        {
            where += " and CardKey='" + this.txtCardKey.Text.Trim() + "'";
        }
        //送修人
        if (!string.IsNullOrEmpty(this.txtRepairMan.Text.Trim()))
        {
            where += " and RepairMan='" + this.txtRepairMan.Text.Trim() + "'";
        }
        //车牌号码
        if (!string.IsNullOrEmpty(this.txtPlateNumber.Text.Trim()))
        {
            where += " and PlateNumber='" + this.txtPlateNumber.Text.Trim() + "'";
        }
        int allCount;
        int CurrentPage = this.pager1.CurrentPageIndex;
        DataSet ds = AutoRepair.BLL.T_RepairDocumentBLL.GetInstance().GetT_RepairDocumentList(pager1.PageSize, CurrentPage, " 1=1 " + where, out allCount);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            rptRepairList.DataSource = ds;
            rptRepairList.DataBind();
            pager1.RecordCount = allCount;
            pager1.CurrentPageIndex = CurrentPage;
        }
        else
        {
            rptRepairList.DataSource = string.Empty;
            rptRepairList.DataBind();
        }
    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        BindData();

    }
    /// <summary>
    /// 分页控件的翻页事件
    /// </summary>
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        int currentPage = 1;//默认显示第一页
        if (!string.IsNullOrEmpty(Request.QueryString["page"]))
        {
            currentPage = int.Parse(Request.QueryString["page"]);
        }   //通过网页get方式获取当前页码
        BindData();
    }
}