using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class data_data : HtmlHelper//System.Web.UI.Page
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
                case "addcar"://添加车辆信息
                    addcar(int.Parse(Request.Form["userid"].ToString()), int.Parse(Request.Form["typecar"].ToString()), Request.Form["carnum"].ToString(), Request.Form["CarFrame"].ToString());
                    break;
                case "getsms"://获取验证码
                    getsms(Request.Form["phone"]);
                    break;
                case "Regisetered"://注册
                    Regisetered(Request.Form["Phone"], Request.Form["openid"], Request.Form["yzm"]);
                    break;
                case "PerfectInfor"://完善信息
                    PerfectInfor(Request.Form["realname"], Request.Form["mail"], Request.Form["idcode"], Convert.ToInt32(Request.Form["identitytype"]), Convert.ToInt32(Request.Form["userid"]), Convert.ToInt32(Request.Form["locationid"]));
                    break;
                case "AddAppeal"://申诉
                    AddAppeal(int.Parse(Request.Form["userid"].ToString()), Request.Form["imgUrl1"], Request.Form["imgUrl2"], Request.Form["imgUrl3"], Request.Form["imgUrl4"], Request.Form["imgUrl5"], Request.Form["count"]);
                    break;
                case "addevaluation":// 添加评价
                    addevaluation(int.Parse(Request.Form["RecordsId"].ToString()), Request.Form["Unitid"].ToString(), Request.Form["content"].ToString(), int.Parse(Request.Form["attitude"].ToString()), int.Parse(Request.Form["speed"].ToString()), int.Parse(Request.Form["quality"].ToString()));
                    break;
                case "AppendEvaluation"://追加评价
                    AppendEvaluation(int.Parse(Request.Form["AssessId"].ToString()), Request.Form["content"].ToString());
                    break;
                case "Order"://预约维修  Request.Form["phone"],
                    Order(Convert.ToInt32(Request.Form["userid"]), Request.Form["unitid"],Convert.ToDateTime(Request.Form["ordertime"]), Request.Form["ordercontent"]);
                    break;
            }
        }
    } 

    public void AddAppeal(int userid, string imgUrl1, string imgUrl2, string imgUrl3, string imgUrl4, string imgUrl5, string count) 
    {
        AutoRepair.Entity.tb_AppealEntity model = new AutoRepair.Entity.tb_AppealEntity();
        try
        {
            model.UserId = userid;
            model.AppealCount = count;
            model.Img1 = imgUrl1;
            model.Img2 = imgUrl2;
            model.Img3 = imgUrl3;
            model.Img4 = imgUrl4;
            model.Img5 = imgUrl5;
            model.Status = 1;
            model.AddTime = DateTime.Now;
            model.UpdateTime = DateTime.Now;
            AutoRepair.BLL.tb_AppealBLL.GetInstance().Insert(model);
            Response.Write(1);
        }
         catch (Exception ex)
         {
             Jnwf.Utils.Log.Logger.Log4Net.Error("PerfectInfor:" + ex.Data + "|" + ex.Message);
             Response.Write(-1);
         }
    }
    /// <summary>
    /// 添加车辆
    /// </summary>
    /// <param name="typecar"></param>
    /// <param name="carnum"></param>
    /// <param name="CarFrame"></param>
    public void addcar(int userid,int typecar, string carnum, string CarFrame) 
    {
        bool b = AutoRepair.BLL.tb_CarsBLL.GetInstance().GetCarsModelByCarNum(carnum);
        if (!b)
        {
            AutoRepair.Entity.tb_CarsEntity model = new AutoRepair.Entity.tb_CarsEntity();
            try
            {
                model.UserId = userid;
                model.CarType = typecar;
                model.CarNum = carnum;
                model.CarFrameNum = CarFrame;
                model.Addtime = DateTime.Now;
                model.Status = 1;
                AutoRepair.BLL.tb_CarsBLL.GetInstance().Insert(model);
                Response.Write(1);
            }
            catch (Exception ex)
            {
                Jnwf.Utils.Log.Logger.Log4Net.Error("PerfectInfor:" + ex.Data + "|" + ex.Message);
                Response.Write(-1);
            }
        }
        else {
            Response.Write(2);
        }
        
    }
    /// <summary>
    /// 获取验证码
    /// </summary>
    /// <param name="phone">手机号</param>
    public void getsms(string phone)
    { 
        //MessageBox.ShowMsg(this,"生成随机验证码")
        Random rnd = new Random();
        string str = rnd.Next(100000, 999999).ToString();

        AutoRepair.Entity.tb_VerificationCodeEntity model = new AutoRepair.Entity.tb_VerificationCodeEntity(); 
        try
        { 
            model.Phone = phone;
            model.Code = str; 
            model.Addtime = DateTime.Now;
            model.Outtime = DateTime.Now.AddMinutes(5); 
            //MessageBox.ShowMsg(this,"插入数据")
            int i = AutoRepair.BLL.tb_VerificationCodeBLL.GetInstance().Insert(model); 
            if (i > 0)
            { 
                SmsHelper.VerifyCodeSms(phone, str);
            }
            Response.Write(1);
        }
        catch (Exception ex)
        {
            Response.Write(-1);
            Jnwf.Utils.Log.Logger.Log4Net.Error("getsms:" + ex.Data + "|" + ex.Message);
        }
    }
    /// <summary>
    /// 注册信息/登入信息
    /// </summary>
    /// <param name="phone">手机号</param>
    /// <param name="pwd">密码</param>
    /// <param name="yzm">验证码</param>
    public void Regisetered(string phone, string openid, string yzm)
    {
        //查看是否当前的验证码有效存在
        AutoRepair.Entity.tb_VerificationCodeEntity verificationCode = AutoRepair.BLL.tb_VerificationCodeBLL.GetInstance().GetVerificationCodeModelByPhone(phone);
        if (verificationCode != null)
        {
            if (verificationCode.Code.Equals(yzm))
            {
                //该用户是否存在
                bool flag = AutoRepair.BLL.tb_UsersBLL.GetInstance().GetUsersModelByPhone(phone);
                if (!flag)
                {
                    AutoRepair.Entity.tb_UsersEntity model = new AutoRepair.Entity.tb_UsersEntity();
                    try
                    {
                        model.Phone = phone.Trim();
                        model.OpenID = openid.Trim();
                        model.Addtime = DateTime.Now;
                        int i = AutoRepair.BLL.tb_UsersBLL.GetInstance().Insert(model);
                        if (i > 0)
                        {  
                            //MessageBox.ShowMsg(this,"注册成功！")
                            Response.Write(1);
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.ShowMsg(this,"注册失败");
                        Response.Write(-1);
                        Jnwf.Utils.Log.Logger.Log4Net.Error("regisetered:" + ex.Data + "|" + ex.Message);
                    }
                }
                else
                {  
                    Response.Write(1); 
                }
            }
            else
            {
                //MessageBox.ShowMsg(this, "验证码错误或已失效");
                Response.Write(-2);
            }
        }
        else
        {
            //MessageBox.ShowMsg(this, "验证码错误或已失效！");
            Response.Write(-2);
        }
    }
    /// <summary>
    /// 完善资料
    /// </summary>
    /// <param name="realName">真实姓名</param>
    /// <param name="mail">邮箱</param>
    /// <param name="idCard">身份证号</param>
    /// <param name="identityType">证件类型</param>
    /// <param name="userId">用户id</param>
    public void PerfectInfor(string realName, string mail, string idCard, int identityType, int userId, int locationId)
    { 
        try
        { 
            AutoRepair.Entity.tb_UsersEntity model = AutoRepair.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(userId);
            if (model != null)
            {
                model.IdCard = idCard;
                model.IdentityType = identityType; 
                model.LocationId = locationId;
                model.RealName = SqlInject(realName);
                model.Mail = SqlInject(mail);
                AutoRepair.BLL.tb_UsersBLL.GetInstance().Update(model);
                //MessageBox.ShowMsg(this, "添加成功！");
                Response.Write(1);
            }
            else
            {
                //MessageBox.ShowMsg(this, "数据不存在！");
                Response.Write(-2);
            }
        }
        catch (Exception ex)
        {
            Response.Write(-1);
            Jnwf.Utils.Log.Logger.Log4Net.Error("PerfectInfor:" + ex.Data + "|" + ex.Message);
        }   
    }
    /// <summary>
    /// 添加评价
    /// </summary>
    /// <param name="recordsId">recordsId</param>
    /// <param name="content">content</param>
    /// <param name="attitude">attitude</param>
    /// <param name="speed">speed</param>
    /// <param name="quality">quality</param>
    public void addevaluation(int recordsId,string unitid, string content, int attitude, int speed, int quality)
    {
        AutoRepair.Entity.tb_EvaluateEntity model = new AutoRepair.Entity.tb_EvaluateEntity();
        try
        {
            model.RecordsId = recordsId;
            model.UnitID = unitid;
            model.AssessCount = content;
            model.Speed = speed;
            model.Attitude = attitude;
            model.Quality = quality;
            model.Type = 1;
            model.Status = 1;
            model.AddTime = DateTime.Now;
            model.AssessCount2 = "";
            model.AddTime2 = DateTime.Now;
            AutoRepair.BLL.tb_EvaluateBLL.GetInstance().Insert(model);
            Response.Write(1);
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("PerfectInfor:" + ex.Data + "|" + ex.Message);
            Response.Write(-1);
        }
    }
    //追加评价
    public void AppendEvaluation(int AssessId, string content)
    {
        AutoRepair.Entity.tb_EvaluateEntity model = AutoRepair.BLL.tb_EvaluateBLL.GetInstance().GetAdminSingle(AssessId);
        try
        {
            if (model != null)
            {
                model.AssessCount2 = content;
                model.AddTime2 = DateTime.Now;
                model.Type = 2;
                AutoRepair.BLL.tb_EvaluateBLL.GetInstance().Update(model);
                Response.Write(1);
            }
            else
            {
                Response.Write(-1);
            }
        }
        catch (Exception ex)
        {
            Jnwf.Utils.Log.Logger.Log4Net.Error("PerfectInfor:" + ex.Data + "|" + ex.Message);
            Response.Write(-1);
        }
    }
    /// <summary>
    /// 预约维修
    /// </summary>
    /// <param name="userId">用户id</param>
    /// <param name="phone">手机号</param>string phone,
    /// <param name="ordertime">预约时间</param>
    /// <param name="ordercontent">车辆故障描述</param>
    public void Order(int userId,string unitId,  DateTime ordertime, string ordercontent)
    {
        try
        {
            bool flag = AutoRepair.BLL.tb_CarsBLL.GetInstance().IsCarsByUserId(userId);
            if (flag)
            {
                //最近是否预约过
                bool tmp = AutoRepair.BLL.tb_SubscribeBLL.GetInstance().IsSubscribeTrue(userId, unitId);
                if (!tmp)
                {
                    AutoRepair.Entity.tb_SubscribeEntity model = new AutoRepair.Entity.tb_SubscribeEntity();
                    model.UserId = userId;
                    model.UnitId = unitId;
                    //model.Phone = phone;
                    model.OrderTime = ordertime;
                    model.OrderContent = SqlInject(ordercontent);
                    model.Addtime = DateTime.Now;
                    model.Status = 1;
                    int i = AutoRepair.BLL.tb_SubscribeBLL.GetInstance().Insert(model);
                    if (i > 0)
                    {
                        Response.Write(1);
                        AutoRepair.Entity.tb_UsersEntity userEntity = AutoRepair.BLL.tb_UsersBLL.GetInstance().GetAdminSingle(userId);
                        if (userEntity != null)
                        {
                            //发送短信
                            SmsHelper.YuyueSms(userEntity.Phone,"");
                        } 
                    }
                    else
                    {
                        Response.Write(-1);
                    }
                }
                else
                {
                    //最近已经预约过
                    Response.Write(-2);
                }
            }
            else
            {
                //没有添加车辆数据
                Response.Write(-3);
            }
        }
        catch (Exception ex)
        {
            Response.Write(-1);
            Jnwf.Utils.Log.Logger.Log4Net.Error("预约维修Order:" + ex.Data + "|" + ex.Message);
        }
    }
}