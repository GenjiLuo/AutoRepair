using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected static int departmentId;
    protected static string name = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        UserIdentity Identity = this.Page.User.Identity as UserIdentity;
        if (Identity != null)
        {
            departmentId = Identity.DepartmentId;
            name = Identity.UserName == "" ? Identity.Name + "--" + "管理员" : Identity.Name + "--" + Identity.UserName;
        } 
    }
}
