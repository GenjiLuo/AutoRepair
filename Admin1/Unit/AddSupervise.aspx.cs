using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Unit_AddSupervise : System.Web.UI.Page
{
    public string json = "";
    public string unitID
    {
        get
        {
            object obj = Request.QueryString["UnitID"];
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
            if (!IsPostBack)
            {
                if (unitID != "")
                {
                    json = "{";
                    AutoRepair.Entity.T_RepairUnitEntity mode = AutoRepair.BLL.T_RepairUnitBLL.GetInstance().GetAdminSingle(unitID);
                    if (mode != null)
                    {
                        json += "\"xukezhenghao\":\"" + mode.UnitID + "\",";
                        json += "\"qiyename\":\"" + mode.UnitName + "\",";
                        json += "\"fuzeren\":\"" + mode.LinkMan + "\",";
                        json += "\"dianhua\":\"" + mode.Phone + "\",";
                        json += "\"quyu\":\"" + mode.Area + "\",";
                        json += "\"dizhi\":\"" + mode.Address + "\",";
                        json += "\"shuihao\":\"" + mode.TaxNumber + "\",";
                        json += "\"zhizhao\":\"" + mode.ICNumber + "\",";
                        json += "\"miyao\":\"" + mode.AuthToken + "\",";
                        json += "\"xinyu\":\"" + mode.Crerating + "\",";
                        json += "\"leibie\":\"" + mode.Categories + "\",";
                        json += "\"fanwei\":\"" + mode.Range + "\",";
                        json += "\"beizhu\":\"" + mode.Remark + "\",";
                    }
                    json = json.Trim(',');
                    json += "}";
                }
            }
        }
    }
}