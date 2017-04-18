using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class Unit_Maintenance : BasePage//System.Web.UI.Page
{
    
    protected string where = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindInfor();
        }
    }
    public void BindInfor() 
    {
        
        if (!string.IsNullOrEmpty(this.txt_endTime.Text))
        {
            where += "and  FinishDate between '"+ this.txt_startTime.Text.Trim()+ "'and '"+ this.txt_endTime.Text.Trim() + "'";
        }
        DataSet ds=AutoRepair.BLL.T_RepairUnitBLL.GetInstance().GetRepairUnitListBy(where);
        if (ds != null)
        {
            rptStatementt.DataSource = ds;
            rptStatementt.DataBind();
        }
    }
    protected void btn_seach_Click(object sender, EventArgs e)
    {
        BindInfor();
    }
}