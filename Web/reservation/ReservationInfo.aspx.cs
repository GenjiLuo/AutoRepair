using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reservation_ReservationInfo : BasePage//System.Web.UI.Page
{
    protected string unitId
    {
        get
        {
            object obj = Request.QueryString["unitid"];
            if (obj == null)
            {
                return "";
            } 
            return obj.ToString(); 
        }
    }
    protected int userId = 0;
    protected string unitName = string.Empty;
    protected string phone = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected override void BasePage_Load(AutoRepair.Entity.tb_UsersEntity user)
    {
        if (user != null)
        {
            AutoRepair.Entity.T_RepairUnitEntity repairunite = AutoRepair.BLL.T_RepairUnitBLL.GetInstance().GetAdminSingle(unitId);
            if (repairunite != null)
            {
                unitName = repairunite.UnitName;
                phone = repairunite.Phone;
            } 
            userId = user.UserId; 
        }
        else
        {
            Response.Redirect("../Registered.aspx");
        }
    }
}