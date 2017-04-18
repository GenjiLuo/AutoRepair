using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class data_data : BasePage //System.Web.UI.Page
{
    public string type
    {
        get
        {
            object obj = Request.Form["type"];
            if (obj == null)
            {
                return "";
            }
            return obj.ToString();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            switch (type)
            {
                case "butadd":
                    butadd(Request.Form["name"].ToString(),
                        Request.Form["address"].ToString(),
                        Request.Form["loaction"].ToString(),
                        Request.Form["contacts"].ToString(),
                        Request.Form["phone"].ToString(),
                        Request.Form["username"].ToString(),
                        Request.Form["userpwd"].ToString());
                    break;
                case "butupdate":
                    butupdate(Request.Form["name"].ToString(),
                        Request.Form["address"].ToString(),
                        Request.Form["loaction"].ToString(),
                        Request.Form["contacts"].ToString(),
                        Request.Form["phone"].ToString(),
                        Request.Form["username"].ToString(),
                        Request.Form["userpwd"].ToString());
                    break;
                case "Deleteunit":
                    Deleteunit(Request.Form["UnitID"].ToString());
                    break;
                case "addSpuervise":
                    addSpuervise(Request.Form["xukezhenghao"].ToString(),
                        Request.Form["qiyename"].ToString(),
                        Request.Form["fuzeren"].ToString(),
                        Request.Form["dianhua"].ToString(),
                        Request.Form["quyu"].ToString(),
                        Request.Form["dizhi"].ToString(),
                        Request.Form["shuihao"].ToString(),
                        Request.Form["zhizhao"].ToString(),
                        Request.Form["miyao"].ToString(),
                        Request.Form["xinyu"].ToString(),
                        Request.Form["leibie"].ToString(),
                        Request.Form["fanwei"].ToString(),
                        Request.Form["beizhu"].ToString(),
                        Request.Form["jingdu"].ToString(),
                        Request.Form["weidu"].ToString(),
                        Request.Form["guanlipwd"].ToString(),
                        Request.Form["bangdingma"].ToString());
                    break;
                case "UpdSpuervise":
                    UpdSpuervise(Request.Form["xukezhenghao"].ToString(),
                        Request.Form["qiyename"].ToString(),
                        Request.Form["fuzeren"].ToString(),
                        Request.Form["dianhua"].ToString(),
                        Request.Form["quyu"].ToString(),
                        Request.Form["dizhi"].ToString(),
                        Request.Form["shuihao"].ToString(),
                        Request.Form["zhizhao"].ToString(),
                        Request.Form["miyao"].ToString(),
                        Request.Form["xinyu"].ToString(),
                        Request.Form["leibie"].ToString(),
                        Request.Form["fanwei"].ToString(),
                        Request.Form["beizhu"].ToString(),
                        Request.Form["jingdu"].ToString(),
                        Request.Form["weidu"].ToString(),
                        Request.Form["guanlipwd"].ToString(),
                        Request.Form["bangdingma"].ToString());
                    break;
            }


        }
    }


    public void test(string name)
    {
        Response.Write(name);
    }
    public void butadd(string name, string address, string locationId, string contacts, string phone, string username, string userpwd)
    {
        AutoRepair.Entity.tb_DepartmentEntity model = new AutoRepair.Entity.tb_DepartmentEntity();
        model.Name = SqlInject(name);
        model.Address = SqlInject(address);
        model.LocationId = int.Parse(SqlInject(locationId));
        model.Contacts = SqlInject(contacts);
        model.Phone = SqlInject(phone.ToString());
        model.UserName = SqlInject(username);
        model.UserPwd = SqlInject(userpwd);
        model.Addtime = DateTime.Now;
        model.Updatetime = DateTime.Now;
        AutoRepair.BLL.tb_DepartmentBLL.GetInstance().Insert(model);
        Response.Write(1);
    }

    public void butupdate(string name, string address, string locationId, string contacts, string phone, string username, string userpwd)
    {
        AutoRepair.Entity.tb_DepartmentEntity model = new AutoRepair.Entity.tb_DepartmentEntity();
        if (model != null)
        {

            model.Name = SqlInject(name);
            model.Address = SqlInject(address);
            model.LocationId = int.Parse(SqlInject(locationId));
            model.Contacts = SqlInject(contacts);
            model.Phone = SqlInject(phone.ToString());
            model.UserName = SqlInject(username);
            model.UserPwd = SqlInject(userpwd);
            AutoRepair.BLL.tb_DepartmentBLL.GetInstance().Update(model);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }
    }

    public void butdelete(int id)
    {
        AutoRepair.Entity.tb_DepartmentEntity model = new AutoRepair.Entity.tb_DepartmentEntity();
        if (model != null)
        {
            model.DepartmentId = id;
            AutoRepair.BLL.tb_DepartmentBLL.GetInstance();
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }
    }
    public void Deleteunit(string unitid)
    {
        AutoRepair.Entity.T_RepairUnitEntity model = AutoRepair.BLL.T_RepairUnitBLL.GetInstance().GetAdminSingle(unitid);
        if (model != null)
        {
            if (model.UnitState == "正常")
            {
                model.UnitState = "失效";
                AutoRepair.BLL.T_RepairUnitBLL.GetInstance().Update(model);
                Response.Write("1," + model.UnitName);
            }
            else
            {
                model.UnitState = "正常";
                AutoRepair.BLL.T_RepairUnitBLL.GetInstance().Update(model);
                Response.Write("2," + model.UnitName);
            }
        }
        else
        {
            Response.Write(-1);
        }
    }
    public void addSpuervise(string xukezhenghao, string qiyename, string fuzeren, string dianhua, string quyu, string dizhi, string shuihao, string zhizhao, string miyao, string xinyu, string leibie, string fanwei, string beizhu, string jingdu, string weidu, string guanlipwd, string bangdingma)
    {
        AutoRepair.Entity.T_RepairUnitEntity model = new AutoRepair.Entity.T_RepairUnitEntity();
        if (model != null)
        {
            model.UnitID = SqlInject(xukezhenghao);
            model.UnitName = SqlInject(qiyename);
            model.LinkMan = SqlInject(fuzeren);
            model.Phone = SqlInject(dianhua);
            model.Area = SqlInject(quyu);
            model.Address = SqlInject(dizhi);
            if (shuihao != "" && zhizhao != "" && miyao != "")
            {
                model.TaxNumber = SqlInject(shuihao);
                model.ICNumber = SqlInject(zhizhao);
                model.AuthToken = SqlInject(miyao);
            }
            model.Crerating = SqlInject(xinyu);
            model.Categories = SqlInject(leibie);
            model.Range = SqlInject(fanwei);
            model.UnitState = "正常";
            if (beizhu != "" && jingdu != "" && weidu != "" && guanlipwd != "" && bangdingma != "")
            {
                model.Remark = SqlInject(beizhu);
                model.Lag = decimal.Parse(SqlInject(jingdu));
                model.Lat = decimal.Parse(SqlInject(weidu));
                model.AdminPwd = SqlInject(guanlipwd);
                model.UsbKey = SqlInject(bangdingma);
            }
            AutoRepair.BLL.T_RepairUnitBLL.GetInstance().Insert(model);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }
    }
    public void UpdSpuervise(string xukezhenghao, string qiyename, string fuzeren, string dianhua, string quyu, string dizhi, string shuihao, string zhizhao, string miyao, string xinyu, string leibie, string fanwei, string beizhu, string jingdu, string weidu, string guanlipwd, string bangdingma)
    {
        AutoRepair.Entity.T_RepairUnitEntity model = new AutoRepair.Entity.T_RepairUnitEntity();
        if (model != null)
        {
            model.UnitID = SqlInject(xukezhenghao);
            model.UnitName = SqlInject(qiyename);
            model.LinkMan = SqlInject(fuzeren);
            model.Phone = SqlInject(dianhua);
            model.Area = SqlInject(quyu);
            model.Address = SqlInject(dizhi);
            if (shuihao != "" && zhizhao != "" && miyao != "")
            {
                model.TaxNumber = SqlInject(shuihao);
                model.ICNumber = SqlInject(zhizhao);
                model.AuthToken = SqlInject(miyao);
            }
            model.Crerating = SqlInject(xinyu);
            model.Categories = SqlInject(leibie);
            model.Range = SqlInject(fanwei);
            model.Remark = SqlInject(beizhu);
            model.UnitState = "正常";
            if (beizhu != "" && jingdu != "" && weidu != "" && guanlipwd != "" && bangdingma != "")
            {
                model.Remark = SqlInject(beizhu);
                model.Lag = decimal.Parse(SqlInject(jingdu));
                model.Lat = decimal.Parse(SqlInject(weidu));
                model.AdminPwd = SqlInject(guanlipwd);
                model.UsbKey = SqlInject(bangdingma);
            }
            AutoRepair.BLL.T_RepairUnitBLL.GetInstance().Update(model);
            Response.Write(1);
        }
        else
        {
            Response.Write(2);
        }
    }
}
