using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
public partial class Repair_Information : BasePage//System.Web.UI.Page
{
    public string str = "1";
    protected static string data = String.Empty;
    protected static string datalist = String.Empty;
    public string UnitName = "";
    public decimal num;
    public decimal numjin;
    public decimal numchu;
    public decimal picenum;
    public string area;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //省
            List<AutoRepair.Entity.tb_LocationEntity> list = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetProvinceByCache() as List<AutoRepair.Entity.tb_LocationEntity>;
            list.RemoveAt(0);
            ddlProvince.DataSource = list;
            ddlProvince.DataTextField = "LocationName";
            ddlProvince.DataValueField = "LocationId";
            ddlProvince.DataBind();
            //市
            List<AutoRepair.Entity.tb_LocationEntity> list2 = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetCityListCache(list[0].LocationId);
            ddlCity.DataSource = list2;
            ddlCity.DataTextField = "LocationName";
            ddlCity.DataValueField = "LocationId";
            ddlCity.DataBind();
            txt_hid.Text = ddlCity.SelectedValue;
            //县
            List<AutoRepair.Entity.tb_LocationEntity> list3 = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetCountyListCache(list2[0].LocationId);
            AutoRepair.Entity.tb_LocationEntity model = new AutoRepair.Entity.tb_LocationEntity();
            model.LocationName = "--全选--";
            model.LocationId = -1;
            list3.Insert(0, model);
            ddlCounty.DataSource = list3;
            ddlCounty.DataTextField = "LocationName";
            ddlCounty.DataValueField = "LocationId";
            ddlCounty.DataBind();
            qx.Text = "-1";

            BindData();
        }
    }
    private void BindData() 
    {
        if (qx.Text == "-1")
        {
            List<AutoRepair.Entity.tb_LocationEntity> list = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetCountyListCache(int.Parse(txt_hid.Text));
            StringBuilder sbs = new StringBuilder();
            string area = String.Empty;
            foreach (AutoRepair.Entity.tb_LocationEntity model in list)
            {
                sbs.AppendFormat("{0},",model.LocationId);
            }
            area = sbs.ToString().TrimEnd(',');
            DataSet ds = AutoRepair.BLL.T_RepairDocumentBLL.GetInstance().Get_RepairListByAreaList(area);
            if (ds != null)
            {
                //绑定数据
                rptTaskList.DataSource = ds;
                rptTaskList.DataBind();
            }
            DataSet dss = AutoRepair.BLL.T_RepairDocumentBLL.GetInstance().GetUnitCountRepairByAreaList(area);
            if (dss != null && dss.Tables.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                sb.Append("[");
                sb2.Append("[");
                foreach (DataRow dr in dss.Tables[0].Rows)
                {
                    sb.Append("'" + dr["UnitName"] + "',");
                    sb2.AppendFormat("{0}value:{1},name:'{2}'{3},", "{", dr["weixuishu"], dr["UnitName"], "}");
                }
                string str = sb.ToString().TrimEnd(',');
                str += "]";
                string str2 = sb2.ToString().TrimEnd(',');
                str2 += "]";
                data = str;
                datalist = str2;
            } 
        }
        else
        {
            DataSet ds = AutoRepair.BLL.T_RepairDocumentBLL.GetInstance().Get_RepairListByArea(qx.Text);
            if (ds != null)
            {
                //绑定数据
                rptTaskList.DataSource = ds;
                rptTaskList.DataBind();
            }
            DataSet dss = AutoRepair.BLL.T_RepairDocumentBLL.GetInstance().GetUnitCountRepairByArea(qx.Text);
            if (dss != null && dss.Tables.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                sb.Append("[");
                sb2.Append("[");
                foreach (DataRow dr in dss.Tables[0].Rows)
                {
                    sb.Append("'" + dr["UnitName"] + "',");
                    sb2.AppendFormat("{0}value:{1},name:'{2}'{3},", "{", dr["weixuishu"], dr["UnitName"], "}");
                }
                string str = sb.ToString().TrimEnd(',');
                str += "]";
                string str2 = sb2.ToString().TrimEnd(',');
                str2 += "]";
                data = str;
                datalist = str2;
            }
        }
        //市
        List<AutoRepair.Entity.tb_LocationEntity> list2 = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetCityListCache(int.Parse(ddlProvince.SelectedValue));
        ddlCity.DataSource = list2;
        ddlCity.DataTextField = "LocationName";
        ddlCity.DataValueField = "LocationId";
        ddlCity.DataBind();
        ddlCity.SelectedValue = txt_hid.Text;
        //县
        List<AutoRepair.Entity.tb_LocationEntity> list3 = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetCountyListCache(int.Parse(txt_hid.Text));
        AutoRepair.Entity.tb_LocationEntity models = new AutoRepair.Entity.tb_LocationEntity();
        models.LocationName = "--全选--";
        models.LocationId = -1;
        list3.Insert(0, models);
        ddlCounty.DataSource = list3;
        ddlCounty.DataTextField = "LocationName";
        ddlCounty.DataValueField = "LocationId";
        ddlCounty.DataBind();
        ddlCounty.SelectedValue = qx.Text;
    } 
    protected void savess_Click1(object sender, EventArgs e)
    {
        BindData(); 
    }
}