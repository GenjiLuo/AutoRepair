using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Runtime.Serialization;
using System.IO;
//using Exam.BLL;
//using Exam.Entity;


/// <summary>
///UserIdentity 的摘要说明
/// </summary>
public class UserIdentity : IIdentity
{
	public UserIdentity(string ticketData)
	{
		//
		//TODO: 在此处添加构造函数逻辑
        //  
        string[] ticketArr = ticketData.Split('|');
        this._name = ticketArr[0];
        this._locationId = int.Parse(ticketArr[1]);
        this._address = ticketArr[2];
        this._contacts = ticketArr[3];
        this._phone = ticketArr[4];
        this._userName = ticketArr[5];
        this._departmentId = int.Parse(ticketArr[6]);
	}

    public UserIdentity(string username, string password)
    {
        string name = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("adminname");
        string pwd = Jnwf.Utils.Config.ConfigurationUtil.GetAppSettingValue("adminpwd");
        //超级管理员登录
        if (username.Equals(name))
        {
            if (username == name && password == pwd)
            {
                this._name = name;
            }
        }
        //部门人员登录
        else
        {
            AutoRepair.Entity.tb_DepartmentEntity user = AutoRepair.BLL.tb_DepartmentBLL.GetInstance().Gettb_DepartmentByNameAndPwd(username, password);
            if (user != null)
            {
                this._departmentId = user.DepartmentId;
                this._name= user.Name;
                this._address = user.Address;
                this._locationId = user.LocationId;
                this._contacts = user.Contacts;
                this._phone = user.Phone;
                this._userName = user.UserName;
            } 
        } 
    }

    #region IIdentity 成员

    public string AuthenticationType
    {
        get { return "Form"; }
    }

    public bool IsAuthenticated
    {
        get { return !string.IsNullOrEmpty(this.Name); }
    }
    private string _name;
    public string Name
    {
        get { return this._name; }
    }

    #endregion 
    #region 字段
    private int _departmentId; 
    public int DepartmentId
    {
        get { return this._departmentId; }
        set { _departmentId = value; }
    }
    private string _address;
    public string Address
    {
        get {return _address;}
        set { _address = value; }
    }
    public int _locationId;
    public int LocationId
    {
        get { return _locationId; }
        set { _locationId = value; }
    }
    private string _contacts;
    public string Contacts
    {
        get { return _contacts; }
        set { _contacts = value; }
    }
    private string _phone;
    public string Phone
    {
        get { return _phone; }
        set { _phone = value; }
    }
    private string _userName;
    public string UserName
    {
        get { return _userName; }
        set { _userName = value; }
    }
    #endregion
    /// <summary>
    /// 获取用户权限表集数据
    /// </summary>
    /// <returns></returns>
    public DataTable GetPermissionTable()
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("Permission");
        dt.Columns.Add("Key");
        dt.Columns.Add("Name");
        dt.Columns.Add("Action");
        dt.Columns.Add("Value");

        #region 权限
        /*
        if (HttpContext.Current.Cache["PermissionTable" + this._userID] != null)
        {
            return (DataTable)HttpContext.Current.Cache["PermissionTable" + this._userID];
        }

        try
        {
            RolesEntity role = RolesBLL.GetInstance().GetAdminSingle(this._roleID);

            if (role.Name == "*")
            {
                ds.ReadXml(HttpContext.Current.Server.MapPath("~/PermisionItem.xml"), XmlReadMode.Auto);
            }
            else
            {
                StringReader reader = new StringReader(role.Name);
                ds.ReadXml(reader, XmlReadMode.Auto);
                reader.Close();
            }

            if (ds.Tables.Count == 1)
                return ds.Tables[0];

            DataTable permissions = ds.Tables[0];
            DataTable actions = ds.Tables[1];
            DataTable items = ds.Tables[2];



            var query = from item in items.AsEnumerable()
                        join action in actions.AsEnumerable()
                        on item.Field<int>("Action_Id") equals
                            action.Field<int>("Action_Id")
                        select new
                        {
                            Name =
                                item.Field<String>("Name"),
                            Text =
                                item.Field<String>("Text"),
                            Value =
                                item.Field<String>("Value"),
                            Permission_Id =
                                action.Field<int>("Permission_Id")
                        };

            var result = from q in query
                         join permission in permissions.AsEnumerable()
                         on q.Permission_Id equals
                             permission.Field<int>("Permission_Id")
                         select new
                         {
                             Name =
                                 q.Name,
                             Text =
                                 q.Text,
                             Value =
                                 q.Value,
                             Key =
                                 permission.Field<String>("Key")
                         };

            foreach (var item in result)
            {
                dt.Rows.Add(item.Key, item.Text, item.Name, item.Value);
            }
            dt.AcceptChanges();
            HttpContext.Current.Cache.Insert("PermissionTable" + this._userID, dt, null, DateTime.Now.AddMinutes(5), TimeSpan.Zero);
        }
        catch
        { }
        */
        #endregion
        
        return dt;
    }

    public override string ToString()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", this._name, this._locationId,this._address,this._contacts, this._phone,this._userName,this._departmentId);
    }

    /// <summary>
    /// 用户身份验证
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <param name="role"></param>
    /// <param name="persistLogin"></param>
    /// <returns></returns>
    public static bool AuthenticateUser(string username, string password, string role, bool persistLogin)
    {
        try
        {
            UserIdentity user = new UserIdentity(username, password);

            if (user.IsAuthenticated)
            {
                //if (user.ExpireTime < DateTime.Now) throw new AccessForbiddenException("This account '" + user.UserId + "' was expired, please contact with the administrator!!!");

                int timeout = 20;
                if (persistLogin)
                    timeout = 9999;

                // 建立身份验证票对象
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, user.Name, DateTime.Now, DateTime.Now.AddMinutes(timeout), persistLogin, user.ToString(), "/");
                // 加密序列化验证票为字符串
                string hashTicketString = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hashTicketString);
                cookie.Path = FormsAuthentication.FormsCookiePath;
                cookie.Secure = FormsAuthentication.RequireSSL;
                if (ticket.IsPersistent) cookie.Expires = ticket.Expiration;
                // 将验证票信息保存到 Cookie 中
                HttpContext.Current.Response.Cookies.Add(cookie);
                // 清除当前身份用户的所有 Session 状态值
                HttpContext.Current.Session.Clear();
                HttpContext.Current.Cache.Remove("BusniessArea" + user.DepartmentId);
                HttpContext.Current.Cache.Remove("PermissionTable" + user.DepartmentId);
                // Create the authentication ticket
                HttpContext.Current.User = new UserPrincipal(user);

                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    /// <summary>
    /// 系统内部的身份验证，自动识别用户角色
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public static bool AuthenticateUser(string username, string password)
    {
        return AuthenticateUser(username, password, null, false);
    }
    public static bool AuthenticateUser(string username, string password, bool persistLogin)
    {
        return AuthenticateUser(username, password, null, persistLogin);
    }
    /// <summary>
    /// 退出登陆
    /// </summary>
    public static void Logout()
    {
        Logout(null);
    }
    /// <summary>
    /// 退出登陆
    /// </summary>
    public static void Logout(string redirectURL)
    {
        if (HttpContext.Current.User != null && HttpContext.Current.User.Identity.IsAuthenticated)
        {
            try
            {
                FormsAuthentication.SignOut();

                HttpContext.Current.Session.Clear();
                if (!string.IsNullOrEmpty(redirectURL))
                    HttpContext.Current.Response.Redirect(redirectURL);
            }
            catch { }
        }
        else
        {
            HttpContext.Current.Response.Redirect(redirectURL);
        }
    }
}