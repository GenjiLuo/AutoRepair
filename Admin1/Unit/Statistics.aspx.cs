using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
public partial class Unit_Statistics :BasePage //System.Web.UI.Page
{
    protected static string data = String.Empty;
    protected static string datalist = String.Empty;
    public string Area = "";
    public string Total = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string where = String.Empty;
            string locationName = String.Empty; 
            if (identity != null)
            {
                if (identity.DepartmentId > 0)
                {
                    AutoRepair.Entity.tb_LocationEntity model = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetAdminSingle(identity.LocationId);
                    if (model != null)
                    {
                        locationName = model.LocationName;
                        where = " where area like '%" + model.LocationName + "%'";
                    }
                }
            }
            DataSet ds = AutoRepair.BLL.T_RepairUnitBLL.GetInstance().GetRepairUnitStatistics(where); 
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                //绑定数据
                rptTaskList.DataSource = ds;
                rptTaskList.DataBind();

                StringBuilder sb = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                sb.Append("[");
                sb2.Append("[");
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    sb.Append("'" + dr["LocationName"] + "',");
                    sb2.AppendFormat("{0}value:{1},name:'{2}'{3},", "{", dr["Total"], dr["LocationName"], "}");
                }
                string str = sb.ToString().TrimEnd(',');
                str += "]";
                string str2 = sb2.ToString().TrimEnd(',');
                str2 += "]";
                data = str;
                datalist = str2;
            }
            else
            {
                data = "['" + locationName + "']";
                datalist = "[{value:0,name:'" + locationName + "'}]";
                rptTaskList.DataSource = string.Empty;
                rptTaskList.DataBind();
            }
        }
    }
}