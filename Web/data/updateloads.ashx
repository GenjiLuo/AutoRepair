<%@ WebHandler Language="C#" Class="updateloads" %>

using System;
using System.Web;
using System.IO;
using System.Drawing;
public class updateloads : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        string base64Data = context.Request.Form["base64"];
        if (base64Data != null)
        {
            if (base64Data.IndexOf(',') >= 0)
            {
                base64Data = base64Data.Split(',')[1];
                string file = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".txt";
                //保存路径
                string path = context.Request.PhysicalApplicationPath;
                path += "upimg/";
                string originalImagePath = path + file;
                GenerateFile(originalImagePath, base64Data);
                Base64StringToImage(originalImagePath);
                string url = System.Web.Configuration.WebConfigurationManager.AppSettings["url"];
                context.Response.Write(url + @"upimg/" + file.Replace(".txt", ".jpg"));
            }
            else
            {
                context.Response.Write("null");
            }
        }
    }
    /// <summary>
    /// 将Base64格式的文本转换成图片
    /// </summary>
    /// <param name="txtFileName">Base64(绝对路径 E:\TaskNew\UserNew\images\img.txt)</param>
    private void Base64StringToImage(string txtFileName)
    {
        try
        {
            FileStream ifs = new FileStream(txtFileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(ifs);

            String inputStr = sr.ReadToEnd();
            byte[] arr = Convert.FromBase64String(inputStr);
            MemoryStream ms = new MemoryStream(arr);
            Bitmap bmp = new Bitmap(ms);

            bmp.Save(txtFileName.Replace(".txt", ".jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
            //bmp.Save(txtFileName + ".bmp", ImageFormat.Bmp);  
            //bmp.Save(txtFileName + ".gif", ImageFormat.Gif);  
            //bmp.Save(txtFileName + ".png", ImageFormat.Png);  
            ms.Close();
            sr.Close();
            ifs.Close();
            File.Delete(txtFileName);
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("error:usersnew/data/upload.ashx:Base64StringToImage()" + ex.Message + "|" + ex.InnerException);
        }
    }
    /// <summary>
    /// 创建文件
    /// </summary>
    /// <param name="filePath">文件所在的绝对路径</param>
    /// <param name="text">要写入的文件内容</param>

    public static void GenerateFile(string filePath, string text)
    {
        #region 先判断文件夹是否存在不存在创建
        //返回指定字符串路径的目录（绝对路径）
        string directoryPath = Path.GetDirectoryName(filePath);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
        //StreamReader reader = new StreamReader(file_path, System.Text.Encoding.Default);
        StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
        sw.Write(text);
        sw.Flush();
        sw.Close();
        fs.Close();
        #endregion
    }
    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}