using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Repair_Evaluate : System.Web.UI.Page
{
    public string AssessCount = "";//评价
    public DateTime AddTime;//评价时间
    public string AssessCount2 = "";//追加评价
    public DateTime AddTime2;//追加评价时间
    public int n = 0;
    public int id
    {
        get
        {
            object obj = Request.QueryString["id"];
            if (obj == null)
            {
                return 0;
            }
            int i;
            int.TryParse(obj.ToString(), out i);
            return i;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        AutoRepair.Entity.tb_EvaluateEntity ee = AutoRepair.BLL.tb_EvaluateBLL.GetInstance().Gettb_EvaluateById(id);

        if (ee != null)
        {

            AssessCount = ee.AssessCount.ToString();//评价
            AddTime = DateTime.Parse(ee.AddTime.ToString());//评价时间
            AssessCount2 = ee.AssessCount2.ToString();//追加评价
            AddTime2 = DateTime.Parse(ee.AddTime2.ToString());//追加评价时间
            n = 1;
        }
        else
        {
            n = 0;
        }
    }
}