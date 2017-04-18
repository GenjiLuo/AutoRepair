using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// SmsHelper 的摘要说明
/// </summary>
public class SmsHelper
{
	public SmsHelper()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    /// <summary>
    /// 审核通过短信，主要是发给试客
    /// </summary>
    /// <param name="toPhone"></param>
    /// <param name="templatedId"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    public static string AuditSuccessSms(string toPhone,  string param)
    {
        string serverIp = "api.ucpaas.com";
        string serverPort = "443";
        string account = "336275f607950ff788f6d2901f947923";    //用户sid
        string token = "7d6cec6f6248730f60cde02613595610";      //用户sid对应的token
        string appId = "afe8a94453804482bde3c26a2b0f42c4";      //对应的应用id，非测试应用需上线使用

        //string toPhone = "15668399009";                                    //发送短信手机号码，群发逗号区分
        string templatedId = "22577";                               //短信模板id，需通过审核
        //string param = "杨晓光,宝宝口水方巾";                                     //短信参数

        UCSRestRequest api = new UCSRestRequest();

        api.init(serverIp, serverPort);
        api.setAccount(account, token);
        //api.enabeLog(true);
        api.setAppId(appId);
        //api.enabeLog(true);


        //短信
        api.SendSMS(toPhone, templatedId, param);
        return "";
    }
    /// <summary>
    /// 需要审核短信，主要是发给商家
    /// </summary>
    /// <param name="toPhone"></param>
    /// <param name="templatedId"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    public static string AuditSms(string toPhone, string param)
    {
        string serverIp = "api.ucpaas.com";
        string serverPort = "443";
        string account = "336275f607950ff788f6d2901f947923";    //用户sid
        string token = "7d6cec6f6248730f60cde02613595610";      //用户sid对应的token
        string appId = "afe8a94453804482bde3c26a2b0f42c4";      //对应的应用id，非测试应用需上线使用

        //string toPhone = "15668399009";                                    //发送短信手机号码，群发逗号区分
        string templatedId = "22699";                               //短信模板id，需通过审核
        //string param = "杨晓光,宝宝口水方巾";                                     //短信参数

        UCSRestRequest api = new UCSRestRequest();

        api.init(serverIp, serverPort);
        api.setAccount(account, token);
        //api.enabeLog(true);
        api.setAppId(appId);
        //api.enabeLog(true);


        //短信
        api.SendSMS(toPhone, templatedId, param);
        return "";
    }
    /// <summary>
    /// 短信验证码
    /// </summary>
    /// <param name="toPhone"></param>
    /// <param name="templatedId"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    public static string VerifyCodeSms(string toPhone, string param)
    {
        string serverIp = "api.ucpaas.com";
        string serverPort = "443";
        string account = "336275f607950ff788f6d2901f947923";    //用户sid
        string token = "7d6cec6f6248730f60cde02613595610";      //用户sid对应的token
        string appId = "afe8a94453804482bde3c26a2b0f42c4";      //对应的应用id，非测试应用需上线使用

        //string toPhone = "15668399009";                                    //发送短信手机号码，群发逗号区分
        string templatedId = "28983";                               //短信模板id，需通过审核
        //string param = "杨晓光,宝宝口水方巾";                                     //短信参数

        UCSRestRequest api = new UCSRestRequest();

        api.init(serverIp, serverPort);
        api.setAccount(account, token);
        //api.enabeLog(true);
        api.setAppId(appId);
        //api.enabeLog(true);


        //短信
        string json = api.SendSMS(toPhone, templatedId, param);
        //Jnwf.Utils.Log.Logger.Log4Net.Error("sms:" + json + "");
        return "";
    }
    /// <summary>
    /// 预约发短信
    /// </summary>
    /// <param name="toPhone"></param>
    /// <param name="param"></param>
    /// <returns></returns>
    public static string YuyueSms(string toPhone, string param)
    {
        string serverIp = "api.ucpaas.com";
        string serverPort = "443";
        string account = "336275f607950ff788f6d2901f947923";    //用户sid
        string token = "7d6cec6f6248730f60cde02613595610";      //用户sid对应的token
        string appId = "afe8a94453804482bde3c26a2b0f42c4";      //对应的应用id，非测试应用需上线使用

        //string toPhone = "15668399009";                                    //发送短信手机号码，群发逗号区分
        string templatedId = "29537";                               //短信模板id，需通过审核
        //string param = "杨晓光,宝宝口水方巾";                                     //短信参数

        UCSRestRequest api = new UCSRestRequest();

        api.init(serverIp, serverPort);
        api.setAccount(account, token);
        //api.enabeLog(true);
        api.setAppId(appId);
        //api.enabeLog(true);


        //短信
        string json = api.SendSMS(toPhone, templatedId, param);
        //Jnwf.Utils.Log.Logger.Log4Net.Error("sms:" + json + "");
        return "";
    }
}