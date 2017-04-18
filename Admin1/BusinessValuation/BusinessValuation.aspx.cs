using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class BusinessValuation_BusinessValuation : BasePage //System.Web.UI.Page
{
    public int departmentId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }


    public void BindData()
    {
        string where = String.Empty;
        if (identity != null)
        {

            if (!string.IsNullOrEmpty(this.txtUnitName.Text.Trim()))
            {
                where += "and p.UnitName like'%" + this.txtUnitName.Text.Trim() + "%'";
            }
            DataSet ds = AutoRepair.BLL.tb_EvaluateBLL.GetInstance().GetEvaluationBusiness(where);
          
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                //绑定数据
                rptl.DataSource = ds;
                rptl.DataBind();
            }
            else
            {
                rptl.DataSource = string.Empty;
                rptl.DataBind();
            }
        }
    }

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        BindData();
    }

}