using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
/// <summary>
/// MailClient 的摘要说明
/// </summary>
public static class MailClient
{
    private static readonly SmtpClient Client;
    static MailClient()
    {
        Client = new SmtpClient
        {
            Host = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("SmtpServer"),
            //Port = Convert.ToInt32(Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("SmtpPort")),
            DeliveryMethod = SmtpDeliveryMethod.Network
        };
        Client.UseDefaultCredentials = false;
        Client.Credentials = new NetworkCredential(Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("SmtpUser"), Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("SmtpPass"));
    }
    private static bool SendMessage(string from, string to, string subject, string body)
    {
        MailMessage mm = null;
        bool isSent = false;
        try
        {
            mm = new MailMessage(from, to, subject, body);
            //mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            mm.BodyEncoding = System.Text.Encoding.Default;
            mm.IsBodyHtml = true;

            Client.Send(mm);
            isSent = true;
        }
        catch (Exception ex)
        {
            var exMsg = ex.Message;
        }
        finally
        {
            mm.Dispose();
        }
        return isSent;
    }
    public static bool SendWelcome(string name, string mail)
    {
        string body = "<p><b>尊敬的用户" + name + "</b></p>";
        body += "<p>祝贺您成功注册快去读。请您妥善保管好账号信息，以免给您带来不必要的损失！</P>";
        return SendMessage(Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("adminEmail"), mail, "欢迎加入快去读", body);
    }
}