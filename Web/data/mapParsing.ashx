<%@ WebHandler Language="C#" Class="mapParsing" %>

using System;
using System.Web;
using System.Collections.Generic;

public class mapParsing : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string str = context.Request.Params["json"];
        if (str != null)
        {
            string[] coordinates = str.Split(',');
           //进行经纬度计算排序 
           List<AutoRepair.Entity.T_RepairUnitEntity> list = AutoRepair.BLL.T_RepairUnitBLL.GetInstance().GetT_RepairUnitList() as List<AutoRepair.Entity.T_RepairUnitEntity>;
           string json = "[Message:{Result:Ok}]";
           if (list != null && list.Count > 0)
           {
               int t;
               for (int i = 0; i < list.Count; i++)
               {
                   AutoRepair.Entity.T_RepairUnitEntity model = new AutoRepair.Entity.T_RepairUnitEntity();
                   t = i;
                   for (int k = i + 1; k < list.Count; k++)
                   {
                       if (Math.Abs((Convert.ToDecimal(coordinates[0]) + Convert.ToDecimal(coordinates[1])) - (list[i].Lag + list[i].Lat)) > Math.Abs((Convert.ToDecimal(coordinates[0]) + Convert.ToDecimal(coordinates[1])) - (list[k].Lag + list[k].Lat)))
                       {
                           t = k;
                       }
                   }
                   model = list[t];
                   list[t] = list[i];
                   list[i] = model;
               }
               //取前5条 
               int tmp = 0;
               System.Text.StringBuilder sb = new System.Text.StringBuilder();
               sb.Append("{\"Message\":[{\"Result\":\"Ok\"}],\"content\":[");
               foreach (AutoRepair.Entity.T_RepairUnitEntity entity in list)
               {
                   tmp++;
                   if (tmp > 3)
                   {
                       break;
                   }
                   sb.AppendFormat("{5}\"lag\":\"{0}\",\"lat\":\"{1}\",\"location\":\"{2}\",\"phone\":\"{3}\",\"unitid\":\"{4}\"{6}", entity.Lag, entity.Lat, entity.UnitName, entity.Phone, entity.UnitID, "{", "},");
               }
               json = sb.ToString().TrimEnd(',') + "]}";
           }
           context.Response.Write(Jnwf.Utils.Json.JsonHelper.SerializeJson(json));
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}