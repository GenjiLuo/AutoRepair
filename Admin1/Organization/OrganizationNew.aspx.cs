using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
public partial class Organization_OrganizationNew : BasePage //System.Web.UI.Page
{
    public string name = "";
    public int yn = 0;
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
        if (!IsPostBack)
        {
            ddlProvince.DataSource = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetProvinceByCache();
            ddlProvince.DataTextField = "LocationName";
            ddlProvince.DataValueField = "LocationId";
            ddlProvince.DataBind();

            if (id > 0)
            {
                AutoRepair.Entity.tb_DepartmentEntity model = AutoRepair.BLL.tb_DepartmentBLL.GetInstance().GetAdminSingle(id);
                this.txtjgname.Text = model.Name;
                this.txtjgaddress.Text = model.Address;
                this.txtconsignee.Text = model.Contacts;
                this.txtmobile.Text = model.Phone;
                this.txtvuser.Text = model.UserName;
                AutoRepair.Entity.tb_LocationEntity modelt = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetAdminSingle(model.LocationId);
                if (modelt != null)
                {
                    string[] arr = modelt.LocationPath.Split('/');
                    if (arr.Count() > 3)
                        ddlProvince.SelectedValue = arr[2].ToString();//Items.FindByValue(arr[2].ToString()).Selected = true;
                    if (ddlProvince.SelectedValue != "0")
                    {
                        //市
                        List<AutoRepair.Entity.tb_LocationEntity> list2 = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetCityListCache(int.Parse(ddlProvince.SelectedValue));
                        ddlCity.DataSource = list2;
                        ddlCity.DataTextField = "LocationName";
                        ddlCity.DataValueField = "LocationId";
                        ddlCity.DataBind();
                        ddlCity.SelectedValue = arr[3].ToString();
                        //县
                        List<AutoRepair.Entity.tb_LocationEntity> list3 = AutoRepair.BLL.tb_LocationBLL.GetInstance().GetCountyListCache(int.Parse(ddlCity.SelectedValue));
                        ddlCounty.DataSource = list3;
                        ddlCounty.DataTextField = "LocationName";
                        ddlCounty.DataValueField = "LocationId";
                        ddlCounty.DataBind();
                    }
                    ddlCounty.SelectedValue = model.LocationId.ToString();
                    qx.Text = model.LocationId.ToString();
                } 
               // this.txtpermission.Text = model.PermissionNum;
            }
        }
    }
    protected void btn_seave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(qx.Text.Trim()))
        {
            MessageBox.ShowMsg(this, "请选择地区!");
            return;
        }
        if(string.IsNullOrEmpty(txtvuser.Text.Trim()))
        {
            MessageBox.ShowMsg(this,"用户名不能为空");
            return;
        }
        if (txtvuser.Text.Trim() == "administrator")
        {
            MessageBox.ShowMsg(this, "用户名已经存在，请重新填写");
            return;
        }
        if (string.IsNullOrEmpty(txtjgaddress.Text.Trim()) || txtjgaddress.Text.Trim().Length < 2)
        {
            MessageBox.ShowMsg(this, "请填写机构名称并且长度不能少于2！");
            return;
        }
        if (string.IsNullOrEmpty(txtconsignee.Text.Trim()) || txtconsignee.Text.Trim().Length < 2)
        {
            MessageBox.ShowMsg(this, "请填写联系人并且长度不能小于2！");
            return;
        }
        Regex regex = new Regex(@"^(13|15|18)\d{9}$", RegexOptions.IgnoreCase);
        if (!regex.Match(txtmobile.Text.Trim()).Success || txtmobile.Text.Trim().Length != 11) 
        {
            MessageBox.ShowMsg(this, "请填写正确的联系电话");
            return;
        }

        if (string.IsNullOrEmpty(txtpassw.Text.Trim()) || txtpassw.Text.Trim().Length < 6)
        {
            MessageBox.ShowMsg(this, "请填写密码并且长度不能小于6！");
            return;
        }
    
        if (txtpassw.Text.Trim() != txtpasswc.Text.Trim())
        {
             MessageBox.ShowMsg(this, "两次密码输入的不一致，请重新输入！");
            return;
        }
        if (id > 0)
        {
            //修改
            AutoRepair.Entity.tb_DepartmentEntity model = AutoRepair.BLL.tb_DepartmentBLL.GetInstance().GetAdminSingle(id);
            //model.LocationId = int.Parse(ddlCounty.SelectedValue);
           
            model.LocationId = int.Parse(qx.Text.Trim());
            model.Name =this.txtjgname.Text;
            model.Address =this.txtjgaddress.Text;
            model.Contacts = txtconsignee.Text;
            model.Phone = txtmobile.Text;
            model.UserName = txtvuser.Text;
            model.UserPwd = txtpassw.Text;
            model.Updatetime = DateTime.Now;
            model.Status = 1;
            model.PermissionNum = "";// txtpermission.Text;
            AutoRepair.BLL.tb_DepartmentBLL.GetInstance().Update(model);
            MessageBox.ShowAndRedirect(this, "修改成功", "AllOrganization.aspx");
        }
        else
        {
            AutoRepair.Entity.tb_DepartmentEntity temp = AutoRepair.BLL.tb_DepartmentBLL.GetInstance().Gettb_DepartmentByUserName(txtvuser.Text.Trim());
            if (temp != null)
            {
                MessageBox.ShowMsg(this, "用户名已经存在，请重新填写");
                return;
            }
            //增加
            AutoRepair.Entity.tb_DepartmentEntity model = new AutoRepair.Entity.tb_DepartmentEntity();
            //  model.LocationId = int.Parse(ddlCounty.SelectedValue);
            model.LocationId = int.Parse(qx.Text.Trim());
            model.Name = txtjgname.Text.Trim();
            model.Address = txtjgaddress.Text.Trim();
            model.Contacts = txtconsignee.Text.Trim();
            model.Phone = txtmobile.Text.Trim();
            model.UserName = txtvuser.Text.Trim();
            model.UserPwd = txtpassw.Text.Trim();
            model.Addtime = DateTime.Now;
            model.Updatetime = DateTime.Now;
            model.Status = 1;
            model.PermissionNum = "";//txtpermission.Text.Trim();
           int i= AutoRepair.BLL.tb_DepartmentBLL.GetInstance().Insert(model);
           if (i > 0)
           {

               MessageBox.ShowAndRedirect(this, "添加成功", "AllOrganization.aspx");
           }
           else
           {
               Response.Write("<script>alert('添加失败');</script>");
           }
        }
    }
}