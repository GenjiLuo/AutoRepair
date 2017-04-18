using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Repair_RepairDetails : System.Web.UI.Page
{
    public string UnitName = "";//承修方名字
    public string RepairMan = "";//送修人
    public string PlateNumber = "";//车牌号码
    public string AutoBrand = "";//厂牌型号
    public string RepairSort = "";//维修类别
    public DateTime SignDate;//进厂日期
    public string ContractNumber = "";//合同编号
    public string RepairNumber = "";//工单号码
    public string Mileage = "";//出厂里程
    public string HGZH = "";//合格证号
    public string Phone = "";//托修方电话

    public decimal ZDF;//维修诊断费
    public decimal JCF;//检测费
    public decimal CLF;//材料费
    public decimal GSF;//工时费
    public decimal JGF;//加工费
    public decimal QTF;//其它费用
    public decimal TotalMoney;//合计金额
    public string Remark = "";//备注

    public string ItemName = "";//材料名称
    public string ItemUnit = "";//计量单位
    public decimal Amount;//数量
    public decimal Price;//单价
    public decimal Money;//金额

    public decimal WorkTime;//工时
    public string AutoType = "";//车辆类型
    public string EngineNumber = "";//发动机号
    public string ChassisNumber = "";//底盘号
    public string CheckMan = "";//质检人
    public DateTime FinishDate;//修竣日期
    public DateTime UploadTime;//提交时间
    public decimal wxzdnum;//维修诊断费总价
    public decimal JCnum;//检测费总价
    public decimal CLnum;//材料费总价
    public decimal GSnum;//工时费总价
    public decimal JGnum;//加工费总价
    public decimal QTnum;//其它费用总价

    
    public int id
    {
        get
        {
            object obj = Request.QueryString["ID"];
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
        if (!IsPostBack)
        {
            WXZD();
            JC();
            CL();
            GS();
            JG();
            QT();
            //QT2();
            AutoRepair.Entity.T_RepairDocumentEntity rd = AutoRepair.BLL.T_RepairDocumentBLL.GetInstance().GetAdminSingle(id);

            if (rd != null)
            {
                UnitName = rd.UnitName.ToString();//承修方名字
                RepairMan = rd.RepairMan.ToString();//送修人
                PlateNumber = rd.PlateNumber.ToString();//车牌号码
                AutoBrand = rd.AutoBrand.ToString();//厂牌型号
                RepairSort = rd.RepairSort.ToString();//维修类别
                SignDate = DateTime.Parse(rd.SignDate.ToString());//进厂日期
                ContractNumber = rd.ContractNumber.ToString();//合同编号
                RepairNumber = rd.RepairNumber.ToString();//工单号码
                Mileage = rd.Mileage.ToString();//出厂里程
                HGZH = rd.HGZH.ToString();//合格证号
                Phone = rd.Phone.ToString();//托修方电话
                Remark = rd.Remark.ToString(); //备注

                ZDF = decimal.Parse(rd.ZDF.ToString());//维修诊断费
                JCF = decimal.Parse(rd.JCF.ToString());//检测费
                CLF = decimal.Parse(rd.CLF.ToString());//材料费
                GSF = decimal.Parse(rd.GSF.ToString());//工时费
                JGF = decimal.Parse(rd.JGF.ToString());//加工费
                QTF = decimal.Parse(rd.QTF.ToString());//其它费用
                TotalMoney = decimal.Parse(rd.TotalMoney.ToString());//合计金额
                AutoType = rd.AutoType.ToString();//车辆类型     
                EngineNumber = rd.EngineNumber.ToString();//发动机号
                ChassisNumber = rd.ChassisNumber.ToString();//底盘号
                CheckMan = rd.CheckMan.ToString();//质检人
                FinishDate = DateTime.Parse(rd.FinishDate.ToString());//修竣日期
                UploadTime = DateTime.Parse(rd.UploadTime.ToString());//提交时间
               
               
            }
            //AutoRepair.Entity.T_RepairCLEntity re = AutoRepair.BLL.T_RepairCLBLL.GetInstance().GetAdminSingle(id);
            //if(re!=null){
            //    ItemName = re.ItemName.ToString();//材料名称
            //    ItemUnit = re.ItemUnit.ToString();//计量单位
            //    Amount = decimal.Parse(re.Amount.ToString());//数量
            //    Price = decimal.Parse(re.Price.ToString());//单价
            //    Money = decimal.Parse(re.Money.ToString());//金额
            //}

            //AutoRepair.Entity.T_RepairGSEntity ge = AutoRepair.BLL.T_RepairGSBLL.GetInstance().GetAdminSingle(id);
            //if(ge!=null){
            //    WorkTime = decimal.Parse(ge.WorkTime.ToString());//工时
            //}
        }

    }
    private void WXZD() {
        List<AutoRepair.Entity.T_RepairZDEntity> rz = AutoRepair.BLL.T_RepairZDBLL.GetInstance().Gettb_DocumentID_WXZD_List(id) as List<AutoRepair.Entity.T_RepairZDEntity>;
        if (rz != null && rz.Count > 0)
        {
            rptweixiu.DataSource = rz;
            rptweixiu.DataBind();
            foreach (AutoRepair.Entity.T_RepairZDEntity model in rz)
            {
                wxzdnum += model.Money;
            }
        }
    }
    private void JC()
    {
        IList<AutoRepair.Entity.T_RepairJCEntity> rj = AutoRepair.BLL.T_RepairJCBLL.GetInstance().Gettb_DocumentID_JC_List(id);
        if (rj != null && rj.Count > 0)
        {
            rptjiance.DataSource = rj;
            rptjiance.DataBind();
        }
        foreach (AutoRepair.Entity.T_RepairJCEntity model in rj)
        {
            JCnum += model.Money;
        }
    }
    private void CL() {
        IList<AutoRepair.Entity.T_RepairCLEntity> rc = AutoRepair.BLL.T_RepairCLBLL.GetInstance().Gettb_DocumentID_CL_List(id);
        if (rc != null && rc.Count > 0)
        {
            rptcailiao.DataSource = rc;
            rptcailiao.DataBind();
        }
        foreach (AutoRepair.Entity.T_RepairCLEntity model in rc)
        {
            CLnum += model.Money;
        }
    }
    private void GS()
    {
        IList<AutoRepair.Entity.T_RepairGSEntity> rg = AutoRepair.BLL.T_RepairGSBLL.GetInstance().Gettb_DocumentID_GS_List(id);
        if (rg != null && rg.Count > 0)
        {
            rptgongshi.DataSource = rg;
            rptgongshi.DataBind();
        }
        foreach (AutoRepair.Entity.T_RepairGSEntity model in rg)
        {
            GSnum += model.Money;
        }
    }
    private void JG()
    {
        IList<AutoRepair.Entity.T_RepairJGEntity> rj = AutoRepair.BLL.T_RepairJGBLL.GetInstance().Gettb_DocumentID_JG_List(id);
        if (rj != null && rj.Count > 0)
        {
            rptjiagong.DataSource = rj;
            rptjiagong.DataBind();
        }
        foreach (AutoRepair.Entity.T_RepairJGEntity model in rj)
        {
            JGnum += model.Money;
        }
    }
    private void QT()
    {
        IList<AutoRepair.Entity.T_RepairQTEntity> rq = AutoRepair.BLL.T_RepairQTBLL.GetInstance().Gettb_DocumentID_QT_List(id);
        if (rq != null && rq.Count > 0)
        {
            rptqita.DataSource = rq;
            rptqita.DataBind();
        }
        foreach (AutoRepair.Entity.T_RepairQTEntity model in rq)
        {
            QTnum += model.Money;
        }
    }
  
}
