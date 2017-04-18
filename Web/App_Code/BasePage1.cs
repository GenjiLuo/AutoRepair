using AutoRepair.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// BasePage1 的摘要说明
/// </summary>
public class BasePage1 : System.Web.UI.Page
{
    public delegate void WxOpenInfoEntity(string openid);

    public event WxOpenInfoEntity OnBasePage1OpenInfoLoad;
    public BasePage1()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
        this.OnBasePage1OpenInfoLoad += new WxOpenInfoEntity(BasePage1_OpenInfoLoad);
    }
    public int shopid = 0;
    public string appid = "";
    public string secret = "";
    public string weixincode = "";

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

    protected virtual void BasePage1_OpenInfoLoad(string openid)
    {

    }
    protected override void OnInit(EventArgs e)
    {
        shopid = int.Parse(Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("shopid"));
        appid = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("appid");
        secret = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("secret");
        weixincode = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("weixincode");

        //检查cookie
        string ticket = "";
        string disney = CookieHelper.GetCookieValue("disney");

        if (!string.IsNullOrEmpty(disney))
        {
            jinru = "cookie";
            ticket = Jnwf.Utils.Helper.DESEncrypt.Decrypt(disney);

            this.OnBasePage1OpenInfoLoad(ticket);
        }
        else if (!string.IsNullOrEmpty(Code))
        {

            jinru = "code";
            string url = "https://api.weixin.qq.com/sns/oauth2/access_token?appid=" + appid + "&secret=" + secret + "&code=" + Code + "&grant_type=authorization_code";
            string json = Jnwf.Utils.Helper.HttpHelper.LoadPageContent(url);

            if (json.IndexOf("errcode") >= 0)
            {
                Jnwf.Utils.Log.Logger.Log4Net.Error("Results.aspx:" + json);
            }
            else
            {

                wx_OpenInfoEntity info = Jnwf.Utils.Json.JsonHelper.DeserializeJson<wx_OpenInfoEntity>(json);
                CookieHelper.SetCookie("disney", Jnwf.Utils.Helper.DESEncrypt.Encrypt(info.openid));
                this.OnBasePage1OpenInfoLoad(info.openid);

            }
        }
        else
        {

            jinru = "url";
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
}