using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Unit_detailsUnit : System.Web.UI.Page
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
    public string Crerating = "";
    public string Categories = "";
    public string Range = "";
    public string LocationName = "";
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
    public int locid
    {
        get
        {
            object obj = Request.QueryString["LocationId"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
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
                    AutoRepair.Entity.tb_LocationEntity model = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetAdminSingle(int.Parse((ds.Area=="") ? "0" : ds.Area));
                    //unitID = ds.UnitID.ToString();
                    UnitName = ds.UnitName.ToString();
                    LinkMan = ds.LinkMan.ToString();
                    Phone = ds.Phone.ToString();
                    Address = ds.Address.ToString();
                    TaxNumber = ds.TaxNumber.ToString();
                    ICNumber = ds.ICNumber.ToString();
                    AdminPwd = ds.AdminPwd.ToString();
                    Remark = ds.Remark.ToString();
                    Area = model.LocationName.ToString();
                    UnitState = ds.UnitState.ToString();
                    UsbKey = ds.UsbKey.ToString();
                    AuthToken = ds.AuthToken.ToString();
                    Crerating = ds.Crerating.ToString();
                    Categories = ds.Categories.ToString();
                    Range = ds.Range.ToString();
                }
            }
        }
    }
}