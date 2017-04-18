<%@ WebHandler Language="C#" Class="locationss" %>

using System;
using System.Web;
using System.Collections.Generic;

public class locationss : IHttpHandler {
    public int Id
    {
        get
        {
            object obj = HttpContext.Current.Request.Params["locationid"];
            if (obj == null)
                return 0;
            int i = 0;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    public string Type
    {
        get
        { 
            object obj = HttpContext.Current.Request.Params["type"];
            if (obj == null)
                return "";
            return obj.ToString();
        }
    }
    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        List<AutoRepair.Entity.tb_LocationEntity> list = new List<AutoRepair.Entity.tb_LocationEntity>();
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        if (Id != 0 && !string.IsNullOrEmpty(Type))
        {
            sb.Append("[{\"Message\":\"OK\"},{\"data\":");
            if (Type == "city")
            {
                sb.Append("\"");
                list = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetCityListCache(Id);
            }
            else
            {
                sb.Append("\"<option value='-1'>--全选--</option>");
                list = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetCountyListCache(Id);
            }
            if (list != null && list.Count > 0)
            {
                foreach (AutoRepair.Entity.tb_LocationEntity model in list)
                {
                    //model.LocationName + "," + model.LocationId + "$"
                    sb.Append("<option value='" + model.LocationId + "'>" + model.LocationName + "</option>"); 
                }
                string json = sb.ToString().TrimEnd(',');
                json += "\"}]";
                context.Response.Write(Jnwf.Utils.Json.JsonHelper.SerializeJson(json));
            }
            else
            {
                context.Response.Write(Jnwf.Utils.Json.JsonHelper.SerializeJson("[{\"Message\":\"error\"}]"));
            }
        }
        else
        {
            context.Response.Write(Jnwf.Utils.Json.JsonHelper.SerializeJson("[{\"Message\":\"error\"}]"));
        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}