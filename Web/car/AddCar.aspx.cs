using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class car_AddCar :BasePage//System.Web.UI.Page
{
    public int userid = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected override void BasePage_Load(AutoRepair.Entity.tb_UsersEntity user)
    {
        userid = user.UserId;
    }
}