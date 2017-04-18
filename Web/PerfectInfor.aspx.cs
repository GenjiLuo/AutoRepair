using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PerfectInfor : BasePage //System.Web.UI.Page//
{
    protected static int userId;
    protected int mark=0;//表识
    protected string idCard = string.Empty;
    protected string realName = string.Empty;
    protected string mail = string.Empty;
    protected int locationId;
    protected int locationId2;
    protected int locationId3;
    protected void Page_Load(object sender, EventArgs e)
    {
         
    }
    protected override void BasePage_Load(AutoRepair.Entity.tb_UsersEntity user)
    {
        if (user != null)
        {
            userId = user.UserId;
            AutoRepair.Entity.tb_LocationEntity locationModel = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetAdminSingle(user.LocationId);
            if (locationModel != null)
            {
                string path = locationModel.LocationPath;
                string[] arr = path.Split('/');
                if (arr.Count() == 6)
                {
                    mark = 1;
                    idCard = user.IdCard;
                    realName = user.RealName;
                    mail = user.Mail;
                    locationId = Convert.ToInt32(arr[2]);
                    locationId2 = Convert.ToInt32(arr[3]);
                    locationId3 = Convert.ToInt32(arr[4]);
                }
            }
            //绑定数据
            ddlProvince.DataSource = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetProvinceByCache();
            ddlProvince.DataTextField = "LocationName";
            ddlProvince.DataValueField = "LocationId";
            ddlProvince.DataBind();
        }
        else
        {
            Response.Redirect("Registered.aspx");
        }
    }
}