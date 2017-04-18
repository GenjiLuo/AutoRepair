using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class car_ListCar : BasePage//System.Web.UI.Page
{
    public int num = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        //IList<AutoRepair.Entity.tb_CarsEntity> list = AutoRepair.BLL.tb_CarsBLL.GetInstance().Gettb_CarsUserIdList(1);
        //if (list != null && list.Count > 0)
        //{
        //    rptlistcar.DataSource = list;
        //    rptlistcar.DataBind();
        //    num = 1;
        //}
        //else
        //{
        //    num = 0;
        //}
    }
    protected override void BasePage_Load(AutoRepair.Entity.tb_UsersEntity user)
    {
        IList<AutoRepair.Entity.tb_CarsEntity> list = AutoRepair.BLL.tb_CarsBLL.GetInstance().Gettb_CarsUserIdList(user.UserId);
        if (list != null && list.Count > 0)
        {
            rptlistcar.DataSource = list;
            rptlistcar.DataBind();
            num = 1;
        }
        else
        {
            num = 0;
        }
    }
}