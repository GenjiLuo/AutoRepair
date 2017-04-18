using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Unit_AddSupervis : System.Web.UI.Page
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
                //省
                List<AutoRepair.Entity.tb_LocationEntity> list = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetProvinceByCache() as List<AutoRepair.Entity.tb_LocationEntity>;
                ddlProvince.DataSource = list;
                ddlProvince.DataTextField = "LocationName";
                ddlProvince.DataValueField = "LocationId";
                ddlProvince.DataBind(); 
                if (unitID != "")
                {
                    json = "{";
                    AutoRepair.Entity.T_RepairUnitEntity mode = AutoRepair.BLL.T_RepairUnitBLL.GetInstance().GetAdminSingle(unitID);
                    if (mode != null)
                    { 
                        AutoRepair.Entity.tb_LocationEntity modelt = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetAdminSingle(int.Parse((mode.Area=="") ? "0" : mode.Area));
                        if (modelt != null)
                        { 
                            string[] arr = modelt.LocationPath.Split('/');
                            if (arr.Count() > 3)
                                ddlProvince.SelectedValue = arr[2].ToString();//Items.FindByValue(arr[2].ToString()).Selected = true;
                            if (ddlProvince.SelectedValue != "0")
                            {
                                //市
                                List<AutoRepair.Entity.tb_LocationEntity> list2 = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetCityListCache(int.Parse(ddlProvince.SelectedValue));
                                ddlCity.DataSource = list2;
                                ddlCity.DataTextField = "LocationName";
                                ddlCity.DataValueField = "LocationId";
                                ddlCity.DataBind();
                                ddlCity.SelectedValue = arr[3].ToString();
                                //县
                                List<AutoRepair.Entity.tb_LocationEntity> list3 = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetCountyListCache(int.Parse(ddlCity.SelectedValue));
                                ddlCounty.DataSource = list3;
                                ddlCounty.DataTextField = "LocationName";
                                ddlCounty.DataValueField = "LocationId";
                                ddlCounty.DataBind();
                            }
                            ddlCounty.SelectedValue = mode.Area;
                            qx.Text = mode.Area;
                        } 
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