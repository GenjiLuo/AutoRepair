using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class Repair_Statement : BasePage//System.Web.UI.Page
{
    protected string UnitName = "";//企业名称  
    protected string data = string.Empty;//日期
    protected static string value = string.Empty;//数据
    protected void Page_Load(object sender, EventArgs e)
    { 
        if (!IsPostBack)
        { 
            if (identity != null)
            {
                #region 绑定企业信息 
                string where = String.Empty;
                if (identity.DepartmentId > 0)
                {
                    AutoRepair.Entity.tb_LocationEntity model = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetAdminSingle(identity.LocationId);
                    if (model != null)
                    {
                        where = " where area='" + model.LocationName + "'";
                    }
                }
                //绑定企业信息
                IList<AutoRepair.Entity.T_RepairUnitEntity> list = AutoRepair.BLL.T_RepairUnitBLL.GetInstance().GetRepairUnitListByWhere(where);
                if (list != null && list.Count > 0)
                {
                    ddl_Uid.DataSource = list;
                    ddl_Uid.DataTextField = "UnitName";
                    ddl_Uid.DataValueField = "UnitID";
                    ddl_Uid.DataBind();
                }
                #endregion
                BindInfor(ddl_Uid.SelectedValue);
            } 
        }
    }
    public void BindInfor(string unitId)
    {
        DateTime startTime = DateTime.Now.AddDays(-7);
        DateTime endTime = DateTime.Now;
        if (!string.IsNullOrEmpty(txt_startTime.Value.Trim()))
        {
            startTime = Convert.ToDateTime(txt_startTime.Value.Trim());
        }
        if (!string.IsNullOrEmpty(txt_endTime.Value.Trim()))
        {
            endTime = Convert.ToDateTime(txt_endTime.Value.Trim());
        }
        TimeSpan ts = endTime - startTime;
        StringBuilder sbs = new StringBuilder();
        sbs.Append("[");
        for (int i = 0; i < ts.Days; i++)
        {
            sbs.AppendFormat("\"{0}\",", startTime.AddDays(i).ToString("M"));
        }
        data = sbs.ToString().TrimEnd(',')+"]";
        AutoRepair.Entity.T_RepairUnitEntity model = AutoRepair.BLL.T_RepairUnitBLL.GetInstance().GetAdminSingle(unitId);
        if (model != null)
        {
            UnitName = model.UnitName;//企业名称

        }
        DataSet ds = AutoRepair.BLL.T_RepairDocumentBLL.GetInstance().GetRepairDocumentListByDateTime(ddl_Uid.SelectedValue, startTime, endTime);
        if (ds != null && ds.Tables.Count > 0 )
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                sb.AppendFormat("{0},", dr["num"]);
            }
            value = sb.ToString().TrimEnd(',');
            value += "]"; 
            rptStatementt.DataSource = ds.Tables[0];
            rptStatementt.DataBind();
        }
    }
    protected void ddl_Uid_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindInfor(ddl_Uid.SelectedValue);
    }
    protected void btn_seach_Click(object sender, EventArgs e)
    {
        BindInfor(ddl_Uid.SelectedValue);
    }
}