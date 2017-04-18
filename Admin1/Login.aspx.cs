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

    protected void btnSave_Click(object sender, EventArgs e)
    {
        //if (Session["code"] == null)
        //{
        //    MessageBox.ShowMsg(this, "请重新刷新页面！");
        //    return;
        //}
        //string code = Session["code"].ToString();
        //Session["code"] = null;
        string userName = this.txtName.Text.Trim();
        string userPwd = this.txtPwd.Text.Trim();
        string redirectUrl = Request.QueryString["ReturnUrl"];
        if (UserIdentity.AuthenticateUser(SqlInject(userName), SqlInject(userPwd)))
        {
            if (string.IsNullOrEmpty(redirectUrl) || redirectUrl == "/")
            {
                redirectUrl = "Repair/RepairList.aspx";
                Response.Redirect(redirectUrl);
                Jnwf.Utils.Log.Logger.Log4Net.Error("login,name:111" + userName + userPwd);
            }
            else 
            {
                 Jnwf.Utils.Log.Logger.Log4Net.Error("login,name:222"+userName+userPwd);
                Response.Redirect(redirectUrl);
            }
        }
        else
        {
            this.lbError.Text = "您输入的用户名或密码不正确";
        }
    }
}