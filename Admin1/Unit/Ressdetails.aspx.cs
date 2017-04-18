using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Unit_Ressdetails : System.Web.UI.Page
{
    public string area
    {
        get
        {
            object obj = Request.QueryString["Area"];
            if (obj == null)
                return "";
            //int i;
            return obj.ToString();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            IList<AutoRepair.Entity.T_RepairUnitEntity> list = AutoRepair.BLL.T_RepairUnitBLL.GetInstance().GetRepairUnitListByCityName(area);
            if (list != null)
            {
                rptTaskList.DataSource = list;
                rptTaskList.DataBind();
            }
            else
            {
                rptTaskList.DataSource = string.Empty;
                rptTaskList.DataBind();
            }
        }
    }
}