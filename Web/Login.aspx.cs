using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : BasePage//System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Unnamed_Click(object sender, EventArgs e)
    {
        //if (Session["code"] == null)
        //{
        //    MessageBox.ShowMsg(this, "请重新刷新页面！");
        //    return;
        //}
        //string code = Session["code"].ToString();
   
        //Session["code"] = null;
        string redirectUrl = string.Empty;

        if (UserIdentity.AuthenticateUser(SqlInject(this.txtphone.Text.Trim()), SqlInject(this.txtpwd.Text.Trim())))
        {
            redirectUrl = "car/addcar.aspx";
            Response.Redirect(redirectUrl);


        }
        else
        {
            MessageBox.ShowMsg(this, "您输入的用户名或密码不正确");
        }
    }
}