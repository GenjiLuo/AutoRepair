using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AutoRepair.Entity;

public partial class Organization_AllOrganization : BasePage
//System.Web.UI.Page
{
    public string LocationName = "";
   
    public int id
    {
        get
        {
            object obj = Request.QueryString["DepartmentId"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
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
            ddlProvince.DataSource = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetProvinceByCache();
            ddlProvince.DataTextField = "LocationName";
            ddlProvince.DataValueField = "LocationId";
            ddlProvince.DataBind();

            
            BindData();
        }

    }
    private void BindData()
    {
        if (identity != null)
        {
            if (identity.DepartmentId > 0)
            {
                AutoRepair.Entity.tb_LocationEntity model = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetAdminSingle(identity.LocationId);
                if(model!=null)
                {
                    IList<tb_DepartmentEntity> ds = AutoRepair.BLL.tb_DepartmentBLL.GetInstance().Gettb_DepartmentByAddress(model.LocationName);
                    if (ds != null && ds.Count > 0)
                    {
                        rptl.DataSource = ds;
                        rptl.DataBind();
                    }
                    else
                    {
                        rptl.DataSource = string.Empty;
                        rptl.DataBind();
                    }
                }
            }
            else
            {
                IList<tb_DepartmentEntity> ds = AutoRepair.BLL.tb_DepartmentBLL.GetInstance().Gettb_DepartmentList();
                if (ds != null && ds.Count > 0)
                {

                    rptl.DataSource = ds;
                    rptl.DataBind();
                }
                else
                {
                    rptl.DataSource = string.Empty;
                    rptl.DataBind();
                }
            }
        }
    }
    protected void rptl_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName.Equals("delete"))
        {
            int id = Convert.ToInt32(e.CommandArgument);
            AutoRepair.Entity.tb_DepartmentEntity model = AutoRepair.BLL.tb_DepartmentBLL.GetInstance().GetAdminSingle(id);
            model.Status = 0;
            AutoRepair.BLL.tb_DepartmentBLL.GetInstance().Update(model);
           // Response.Redirect("allorganization.aspx");
            MessageBox.ShowAndRedirect(this, "删除成功！", "AllOrganization.aspx");
        }
    }
    protected void savess_Click(object sender, EventArgs e)
    {
        int h = int.Parse(this.hid.Text);
       // Response.Write(h);
        if (h > 0)
        {

            IList<AutoRepair.Entity.tb_DepartmentEntity> list = AutoRepair.BLL.tb_DepartmentBLL.GetInstance().Gettb_DepartmentBylocationid(h);
            if (list != null && list.Count > 0)
            {

                rptl.DataSource = list;
                rptl.DataBind();
            }
            else
            {
                rptl.DataSource = string.Empty;
                rptl.DataBind();
            }
            Location();
        }
        else if (h == -1)
        { 
            IList<AutoRepair.Entity.tb_DepartmentEntity> list = AutoRepair.BLL.tb_DepartmentBLL.GetInstance().Gettb_DepartmentByLocationParentId(int.Parse(qx.Text));
            if (list != null && list.Count > 0)
            {

                rptl.DataSource = list;
                rptl.DataBind();
            }
            else
            {
                rptl.DataSource = string.Empty;
                rptl.DataBind();
            }
            Location();
        }
        else 
        {
            IList<tb_DepartmentEntity> ds = AutoRepair.BLL.tb_DepartmentBLL.GetInstance().Gettb_DepartmentList();
            if (ds != null && ds.Count > 0)
            {

                rptl.DataSource = ds;
                rptl.DataBind();
            }
            else
            {
                rptl.DataSource = string.Empty;
                rptl.DataBind();
            }
            Location();
        }

    }
    public void Location()
    {
        if (ddlProvince.SelectedValue != "0")
        {
            AutoRepair.Entity.tb_LocationEntity modelt = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetAdminSingle(int.Parse(ddlProvince.SelectedValue));
            if (modelt != null)
            {
                if (ddlProvince.SelectedValue != "0")
                {
                    //市
                    List<AutoRepair.Entity.tb_LocationEntity> list2 = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetCityListCache(int.Parse(ddlProvince.SelectedValue));
                    ddlCity.DataSource = list2;
                    ddlCity.DataTextField = "LocationName";
                    ddlCity.DataValueField = "LocationId";
                    ddlCity.DataBind();
                    ddlCity.SelectedValue = qx.Text;
                    //县
                    List<AutoRepair.Entity.tb_LocationEntity> list3 = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetCountyListCache(int.Parse(ddlCity.SelectedValue));
                    AutoRepair.Entity.tb_LocationEntity model = new AutoRepair.Entity.tb_LocationEntity() { LocationName = "--全部--", LocationId = -1 };
                    if (list3[0].LocationName != "--全部--")
                    {
                        list3.Insert(0, model);
                    }

                    ddlCounty.DataSource = list3;
                    ddlCounty.DataTextField = "LocationName";
                    ddlCounty.DataValueField = "LocationId";
                    ddlCounty.DataBind();
                    ddlCounty.SelectedValue = hid.Text;
                } 
            }
        }
        else
        {
            List<AutoRepair.Entity.tb_LocationEntity> list2=new List<tb_LocationEntity>();
            list2.Add(new AutoRepair.Entity.tb_LocationEntity() { LocationName = "选择市", LocationId = 0 });
            List<AutoRepair.Entity.tb_LocationEntity> list3 = new List<tb_LocationEntity>();
            list3.Add(new AutoRepair.Entity.tb_LocationEntity() { LocationName = "选择县/区", LocationId = 0 });
            ddlCity.DataSource = list2;
            ddlCity.DataTextField = "LocationName";
            ddlCity.DataValueField = "LocationId";
            ddlCity.DataBind();
            ddlCounty.DataSource = list3;
            ddlCounty.DataTextField = "LocationName";
            ddlCounty.DataValueField = "LocationId";
            ddlCounty.DataBind();
        }
    }
}