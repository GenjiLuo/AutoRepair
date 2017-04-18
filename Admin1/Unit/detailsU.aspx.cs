using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Unit_detailsU : System.Web.UI.Page
{
    //public string unitID = "";
    public string UnitName = "";
    public string LinkMan = "";
    public string Phone = "";
    public string Address = "";
    public string TaxNumber = "";
    public string ICNumber = "";
    public string AdminPwd = "";
    public string Remark = "";
    public string Area = "";
    public string UnitState = "";
    public string UsbKey = "";
    public string AuthToken = "";
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
            if (unitID != "")
            {
                AutoRepair.Entity.T_RepairUnitEntity ds = AutoRepair.BLL.T_RepairUnitBLL.GetInstance().GetAdminSingle(unitID);
                if (ds != null)
                {
                    //unitID = ds.UnitID.ToString();
                    UnitName = ds.UnitName.ToString();
                    LinkMan = ds.LinkMan.ToString();
                    Phone = ds.Phone.ToString();
                    Address = ds.Address.ToString();
                    TaxNumber = ds.TaxNumber.ToString();
                    ICNumber = ds.ICNumber.ToString();
                    AdminPwd = ds.AdminPwd.ToString();
                    Remark = ds.Remark.ToString();
                    Area = ds.Area.ToString();
                    UnitState = ds.UnitState.ToString();
                    UsbKey = ds.UsbKey.ToString();
                    AuthToken = ds.AuthToken.ToString();
                }
            }
        }
    }
}