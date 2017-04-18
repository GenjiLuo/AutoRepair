using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class user_Person : BasePage//System.Web.UI.Page
{
    public string img = String.Empty;
    public string name = String.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected override void BasePage_Load(AutoRepair.Entity.tb_UsersEntity user)
    {
        DataSet ds = AutoRepair.BLL.tb_UsersBLL.GetInstance().Get_useropenid(user.OpenID);
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null && ds.Tables[0].Rows.Count > 0)
        {
            img = ds.Tables[0].Rows[0]["HeadImgurl"].ToString();
            name = ds.Tables[0].Rows[0]["NickName"].ToString();
        }
    }
}