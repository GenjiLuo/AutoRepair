using AutoRepair.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registered : BasePage1//System.Web.UI.Page
{
    protected string openId = "";//"o1fSzjg_9W1yaEKrM4Kgt5MGSqD4";//String.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected override void BasePage1_OpenInfoLoad(string openid)
    {
        //Jnwf.Utils.Log.Logger.Log4Net.Error("openid:"+ openid);
        AutoRepair.Entity.tb_UsersEntity model = AutoRepair.BLL.tb_UsersBLL.GetInstance().GetModelByOpenId(openid);
        if (model != null)
        {
            Response.Redirect("user/Person.aspx");
        }
        openId = openid;
    }
}