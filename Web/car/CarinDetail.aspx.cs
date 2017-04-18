using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutoRepair.Entity;
public partial class car_CarinDetail :BasePage//System.Web.UI.Page
{
    public string PlateColor = String.Empty;//车牌颜色
    public string VIN = String.Empty;//车架号VIN码
    public string AutoBrand = String.Empty;//厂牌型号
    public string AutoType = String.Empty;//车辆类型
    public string UnitName = String.Empty;//车主单位
    public string LinkMan = String.Empty;//车主姓名
    public string Phone = String.Empty;//联系电话
    public string EngineNumber = String.Empty;//发动机号
    public string AutoColor = String.Empty;//车身颜色
    public string ChassisNumber = String.Empty;//底盘号码
    public string CardNumber = String.Empty;//会员卡号
    public string UnitID = String.Empty;//维修企业代码
    public DateTime UploadTime ;//提交时间
    public int n = 0;
    public string PlateNumber
    {
        get
        {
            object obj = Request.QueryString["platenumber"];
            if (obj == null)
            {
                return "";
            }
            return obj.ToString();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        //AutoRepair.Entity.T_AutoInfoEntity model = AutoRepair.BLL.T_AutoInfoBLL.GetInstance().Get_CarinDetailOne(PlateNumber);
        //if (model != null)
        //{
        //    PlateColor = model.PlateColor;
        //    VIN = model.VIN;
        //    AutoBrand = model.AutoBrand;
        //    AutoType = model.AutoType;
        //    UnitName = model.UnitName;
        //    LinkMan = model.LinkMan;
        //    Phone = model.Phone;
        //    EngineNumber = model.EngineNumber;
        //    AutoColor = model.AutoColor;
        //    ChassisNumber = model.ChassisNumber;
        //    CardNumber = model.CardNumber;
        //    UnitID = model.UnitID;
        //    UploadTime = model.EnforceInsuranceDate;
        //    n = 1;
        //}
        //else
        //{
        //    n = 0;
        //}
    }
    protected override void BasePage_Load(tb_UsersEntity user)
    {
        // PlateNumber = PlateNumber.Replace("+", "%20"); 
        //PlateNumber = System.Web.HttpUtility.UrlDecode(PlateNumber, System.Text.Encoding.GetEncoding("GB2312"));
        AutoRepair.Entity.T_AutoInfoEntity model = AutoRepair.BLL.T_AutoInfoBLL.GetInstance().Get_CarinDetailOne(PlateNumber);
        if (model != null)
        {
            PlateColor = model.PlateColor;
            VIN = model.VIN;
            AutoBrand = model.AutoBrand;
            AutoType = model.AutoType;
            UnitName = model.UnitName;
            LinkMan = model.LinkMan;
            Phone = model.Phone;
            EngineNumber = model.EngineNumber;
            AutoColor = model.AutoColor;
            ChassisNumber = model.ChassisNumber;
            CardNumber = model.CardNumber;
            UnitID = model.UnitID;
            UploadTime = model.EnforceInsuranceDate;
            n = 1;
        }
        else
        {
            n = 0;
        }
    }
}