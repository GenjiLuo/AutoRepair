using AutoRepair.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// BasePage 的摘要说明
/// </summary>
public class BasePage : System.Web.UI.Page
{

    public delegate void WxUsersEntity(tb_UsersEntity user);
    public event WxUsersEntity OnBasePageLoad;
    public BasePage()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
        this.OnBasePageLoad += new WxUsersEntity(BasePage_Load);
    }
    public int shopid = 0;
    public string appid = "";
    public string secret = "";
    public string weixincode = "";
    public string sitepath = "";
    public string jinru = "";
    public string Code
    {
        get
        {
            object obj = Request.QueryString["code"];
            if (obj == null)
            {
                return "";
            }
            return obj.ToString();
        }
    }
    protected virtual void BasePage_Load(tb_UsersEntity user)
    {

    }
    protected override void OnInit(EventArgs e)
    {
        shopid = int.Parse(Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shopid"));
        appid = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("appid");
        secret = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("secret");
        weixincode = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("weixincode");
        sitepath = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("sitepath");
        tb_UsersEntity user = null;
        Jnwf.Model.tb_App_UserEntity app_user = null;
        //检查cookie
        string ticket = "";
        string disney = CookieHelper.GetCookieValue("disney");

        if (!string.IsNullOrEmpty(disney))
        {
            jinru = "cookie";
            Jnwf.Utils.Log.Logger.Log4Net.Error("BasePage,jinru:" + jinru);
            ticket = Jnwf.Utils.Helper.DESEncrypt.Decrypt(disney);
            //Jnwf.Utils.Log.Logger.Log4Net.Error("basepage,cookie:" + ticket);
            user = AutoRepair.BLL.tb_UsersBLL.GetInstance().GetModelByOpenId(ticket);
            app_user = Jnwf.BLL.tb_App_UserBLL.GetInstance().GetModelByOpenId(ticket);
            if (app_user == null)
            {
                try
                {
                    Response.Redirect("http://mp.weixin.qq.com/s?__biz=MzI4MzE0ODM1Nw==&mid=402172802&idx=1&sn=c66fe86ffd6b8c8cb73bd3033c1d2903#rd");
                }
                catch (System.Threading.ThreadAbortException ex)
                { }
            }
            else if (user == null )
            {
                try
                {
                    Response.Redirect(sitepath + "Registered.aspx");
                }
                catch (System.Threading.ThreadAbortException ex)
                { }
            }
            else
            {
                this.OnBasePageLoad(user);
            }
        }
        else if (!string.IsNullOrEmpty(Code))
        {
            jinru = "code";
            Jnwf.Utils.Log.Logger.Log4Net.Error("BasePage,jinru:" + jinru);
            string url = "https://api.weixin.qq.com/sns/oauth2/access_token?appid=" + appid + "&secret=" + secret + "&code=" + Code + "&grant_type=authorization_code";
            string json = Jnwf.Utils.Helper.HttpHelper.LoadPageContent(url);

            if (json.IndexOf("errcode") >= 0)
            {
                Jnwf.Utils.Log.Logger.Log4Net.Error("Results.aspx:" + json);
            }
            else
            {

                wx_OpenInfoEntity info = Jnwf.Utils.Json.JsonHelper.DeserializeJson<wx_OpenInfoEntity>(json);

                string str = info.openid;
                //Jnwf.Utils.Log.Logger.Log4Net.Error("basepage,code:" + str);
                CookieHelper.SetCookie("disney", Jnwf.Utils.Helper.DESEncrypt.Encrypt(str));

                user = AutoRepair.BLL.tb_UsersBLL.GetInstance().GetModelByOpenId(info.openid);
                app_user = Jnwf.BLL.tb_App_UserBLL.GetInstance().GetModelByOpenId(info.openid);
                if (app_user == null)
                {
                    try
                    {
                        Response.Redirect("http://mp.weixin.qq.com/s?__biz=MzI4MzE0ODM1Nw==&mid=402172802&idx=1&sn=c66fe86ffd6b8c8cb73bd3033c1d2903#rd");
                    }
                    catch (System.Threading.ThreadAbortException ex)
                    { }
                }
                else if (user == null )
                {
                    try
                    {
                        Response.Redirect(sitepath + "Registered.aspx");
                    }
                    catch (System.Threading.ThreadAbortException ex)
                    { }
                }
                else
                {
                    this.OnBasePageLoad(user);
                }

            }
        }
        else
        {
            jinru = "url";
            Jnwf.Utils.Log.Logger.Log4Net.Error("BasePage,jinru:" + jinru);
            //string host = this.Request.Url.Host;
            //string path = this.Request.Path;

            //string redirect_uri = HttpUtility.UrlEncode("http://" + host + path);
            string redirect_uri = HttpUtility.UrlEncode(this.Request.Url.ToString());
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("appid", appid);
            data.Add("redirect_uri", redirect_uri);
            data.Add("response_type", "code");
            data.Add("scope", "snsapi_base");

            string temp_url = "https://open.weixin.qq.com/connect/oauth2/authorize?";

            foreach (var dic in data)
            {
                temp_url += dic.Key + "=" + dic.Value + "&";
            }
            //Jnwf.Utils.Log.Logger.Log4Net.Error("detail:" + temp_url);
            try
            {
                //触发微信返回code码         
                this.Response.Redirect(temp_url.TrimEnd('&'));//Redirect函数会抛出ThreadAbortException异常，不用处理这个异常
            }
            catch (System.Threading.ThreadAbortException ex)
            {
            }
        }
        base.OnInit(e);
    }
    /// <summary>
    /// SQL防注入方法，对每个查询字符串做检查
    /// </summary>
    /// <param name="strTextIn"></param>
    /// <returns></returns>
    public static string SqlInject(string strTextIn)
    {
        if ((strTextIn != null) && (strTextIn != ""))
        {
            string str = strTextIn.ToLower().Replace(" ", "%20");

            if (str.IndexOf("alert") != -1)
            {
                str = str.Replace("alert", " ");
            }
            if (str.IndexOf("%20and%20") != -1)
            {
                str = str.Replace("%20and%20", " ");
            }
            if (str.IndexOf("having") != -1)
            {
                str = str.Replace("having", " ");
            }
            if (str.IndexOf("%20db_name") != -1)
            {
                str = str.Replace("%20db_name", " ");
            }
            if (str.IndexOf("%20or%20") != -1)
            {
                str = str.Replace("%20or%20", " ");
            }
            if (str.IndexOf("net%20user") != -1)
            {
                str = str.Replace("net%20user", " ");
            }
            if (str.IndexOf("'") != -1)
            {
                str = str.Replace("'", " ");
            }
            if (str.IndexOf("/add") != -1)
            {
                str = str.Replace("/add", " ");
            }
            if (str.IndexOf("select%20") != -1)
            {
                str = str.Replace("select%20", " ");
            }
            if (str.IndexOf("insert%20") != -1)
            {
                str = str.Replace("insert%20", " ");
            }
            if (str.IndexOf("delete%20from") != -1)
            {
                str = str.Replace("delete%20from", " ");
            }
            if (str.IndexOf("drop%20") != -1)
            {
                str = str.Replace("drop%20", " ");
            }
            if (str.IndexOf("update%20") != -1)
            {
                str = str.Replace("update%20", " ");
            }
            if (str.IndexOf("truncate%20") != -1)
            {
                str = str.Replace("truncate%20", " ");
            }
            if (str.IndexOf("asc(") != -1)
            {
                str = str.Replace("asc(", " ");
            }
            if (str.IndexOf("mid(") != -1)
            {
                str = str.Replace("mid(", " ");
            }
            if (str.IndexOf("char(") != -1)
            {
                str = str.Replace("char(", " ");
            }
            if (str.IndexOf("count(") != -1)
            {
                str = str.Replace("count(", " ");
            }
            if (str.IndexOf("xp_cmdshell") != -1)
            {
                str = str.Replace("xp_cmdshell", " ");
            }
            if (str.IndexOf("exec%20master") != -1)
            {
                str = str.Replace("exec%20master", " ");
            }
            if (str.IndexOf("net%20localgroup%20administrators") != -1)
            {
                str = str.Replace("net%20localgroup%20administrators", " ");
            }
            return str;
        }
        else
        {
            return string.Empty;
        }

    }
}
