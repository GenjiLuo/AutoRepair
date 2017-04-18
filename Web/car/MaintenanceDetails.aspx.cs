using AutoRepair.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class car_MaintenanceDetails : BasePage//System.Web.UI.Page
{
    public string RepairNumber = String.Empty;//维修工单
    public string PlateNumber = String.Empty;//车牌号码
    public string CarColor = String.Empty;//车身颜色
    public string AutoType = String.Empty;//车辆类型
    public DateTime SignDate = DateTime.Now;//进厂日期

    public DateTime FinishDate = DateTime.Now;//修浚日期
    public string UnitName =String.Empty;//承修企业
    public string UnitPhone = String.Empty;//承修电话
    public string UnitAddress = String.Empty;//承修地址
    public decimal TotalMoney = 0;//合计
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
        
    }
    protected override void BasePage_Load(tb_UsersEntity user)
    {
        if (user != null)
        {
            AutoRepair.Entity.T_RepairDocumentEntity model = AutoRepair.BLL.T_RepairDocumentBLL.GetInstance().GetAdminSingle(id);
            if (model != null)
            {
                UnitName = model.UnitName;
                UnitPhone = model.UnitPhone;
                UnitAddress = model.UnitAddress;
                RepairNumber = model.RepairNumber;
                PlateNumber = model.PlateNumber;
                CarColor = model.CarColor;
                AutoType = model.AutoType;
                SignDate = model.SignDate;
                FinishDate = model.FinishDate;
                TotalMoney = model.TotalMoney;
            }
        }
    }
}