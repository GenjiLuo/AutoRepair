<%@ Page EnableEventValidation="false" Language="C#" AutoEventWireup="true" CodeFile="OrganizationNew.aspx.cs" Inherits="Organization_OrganizationNew" MasterPageFile="~/MasterPage.master" %>


<asp:Content runat="server" ContentPlaceHolderID="header">
    <link href="../css/Organization.css" rel="stylesheet" />
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">

    <div class="page_title" style="margin: auto 16px; margin-bottom: 30px;">
        <h2><strong style="font-size: 20px;">新增机构</strong></h2>
    </div>


    <div class="cb_box" style="margin-right: 182px; margin-left: 15px;">
        <div class="cbs_box fo" style="padding-left: 86px;">
            <div class="xtb_class">
                <b class="xtb_name">省：</b>
                <span class="xtb_text_box width124">
                    <asp:DropDownList ID="ddlProvince" runat="server" CssClass="xtb_choose"></asp:DropDownList>
                </span>
            </div>
            <div class="xtb_class" style="padding-left: 15px;">
                <b class="xtb_name">市：</b>
                <span class="xtb_text_box width124">
                    <asp:DropDownList ID="ddlCity" runat="server" CssClass="xtb_choose">
                        <asp:ListItem Value="0">选择市</asp:ListItem>
                    </asp:DropDownList>
                </span>
            </div>
            <div class="xtb_class" style="padding-left: 15px;">
                <b class="xtb_name">区（县）：</b>
                <span class="xtb_text_box width124">
                    <asp:DropDownList ID="ddlCounty" runat="server" CssClass="xtb_choose">
                        <asp:ListItem Value="0">选择县/区</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="qx" runat="server" Style="display: none;"></asp:TextBox>
                </span>
            </div>
        </div>
        <div class="cbs_box fo">
           <%--<div class="xtb_class" style="width: 100%; padding-left: 20px;">
                <b class="xtb_name">许可证编码：</b>
                <span class="xtb_text_box width563">
                    <asp:TextBox ID="txtpermission" class="xtb_text" Style="width: 563px" runat="server"></asp:TextBox>
                </span>
            </div>--%>
              <div class="xtb_class" style="width: 100%; padding-left: 48px;">
                <b class="xtb_name">用户名：</b>
                <span class="xtb_text_box width199">
                    <%--  <input id="vuser" value="" name="vuser" class="xtb_text" />--%>
                    <asp:TextBox ID="txtvuser" class="xtb_text" runat="server"></asp:TextBox>
                </span>
            </div>
            
            <div class="xtb_class" style="width: 100%; padding-left: 34px;">
                <b class="xtb_name">机构地址：</b>
                <span class="xtb_text_box width199">
                    <%--<input value="" id="jgaddress" name="jgaddress" class="xtb_text" style="width: 563px" />--%>
                    <asp:TextBox ID="txtjgaddress" class="xtb_text"  runat="server"></asp:TextBox>
                </span>
            </div>

            <div class="xtb_class" style="width: 100%; padding-left: 48px;">
                <b class="xtb_name">联系人：</b>
                <span class="xtb_text_box width199">
                    <%--<input id="consignee" value="" name="consignee" class="xtb_text" />--%>
                    <asp:TextBox ID="txtconsignee" class="xtb_text" runat="server"></asp:TextBox>
                </span>
            </div>
            <div class="xtb_class" style="width: 100%; padding-left: 34px;">
                <b class="xtb_name">联系电话：</b>
                <span class="xtb_text_box width199">
                    <%-- <input id="mobile" value="" name="mobile" class="xtb_text" />--%>
                    <asp:TextBox ID="txtmobile" class="xtb_text" runat="server"  MaxLength="11" onkeyup='value=value.replace(/[^\d]/g,"") '
                                 onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))"></asp:TextBox>
                </span>
            </div>
          <div class="xtb_class" style="width: 100%; padding-left: 34px;">
                <b class="xtb_name">机构名称：</b>
                <span class="xtb_text_box width199">
                    <%--<input value="" id="jgname" name="jgname" class="xtb_text" style="width: 563px" />--%>
                    <asp:TextBox ID="txtjgname" class="xtb_text"  runat="server"></asp:TextBox>
                </span>
            </div>
            <div class="xtb_class" style="width: 100%; padding-left: 62px;">
                <b class="xtb_name">密码：</b>
                <span class="xtb_text_box width199">
                    <%-- <input id="passw" name="passw" class="xtb_text" type="password" />--%>
                    <asp:TextBox ID="txtpassw" class="xtb_text" TextMode="Password" runat="server"></asp:TextBox>
                </span>
            </div>
            <div class="xtb_class" style="width: 100%; padding-left: 34px;">
                <b class="xtb_name">确认密码：</b>
                <span class="xtb_text_box width199">
                    <%--<input class="xtb_text" id="passwc" name="passwc" type="password" />--%>
                    <asp:TextBox ID="txtpasswc" class="xtb_text" TextMode="Password" runat="server"></asp:TextBox>
                </span>
            </div>
            <div style="width: 100%; float: right; padding: 0 5px; margin: 5px;">
                <div class="xtb_class" style="padding-left: 118px;">
                    <span class="xtb_button_box">
                       <%-- <asp:Button ID="btn_seave" class="xtb_button bg_blue" runat="server" Text="保存" OnClick="btn_seave_Click" OnClientClick="check()" />--%>
                         <asp:Button ID="btn_seave" class="xtb_button bg_blue" runat="server" Text="保存" OnClick="btn_seave_Click" />
                        <%--<input class="xtb_button bg_blue" id="baocun" value="保存" onclick="check()" />--%>
                    </span>
                </div>
                <div class="xtb_class">
                    <span class="xtb_button_box">
                        <input class="xtb_button bg_blue" value="重置" type="reset" />
                    </span>
                </div>
            </div>
        </div>
    </div>
    <input name="act" value="" type="hidden" />
    <input name="id" value="" type="hidden" />




    <script type="text/javascript">



        function check() {
    
            if ($("#<%=qx.ClientID %>").val() == "") {
                alert("请选择地区！");
                window.event.returnValue = false;
                return;
            }
            var username = $.trim($("#<%=txtvuser.ClientID%>").val());
            if (username.length < 2) {
                alert("用户名不能小于2！");
                window.event.returnValue = false;
                return;
            }
            var name = $.trim($("#<%=txtjgname.ClientID%>").val());
            if (name == "" || name.length < 2) {
                alert("请填写机构名称并且长度不能少于2！");
                window.event.returnValue = false;
                return;
            }
            var Address = $.trim($("#<%=txtjgaddress.ClientID%>").val());
            if (Address == "") {
                alert("请填写机构地址！");
                window.event.returnValue = false;
                return;
            }
            var contacts = $.trim($("#<%=txtconsignee.ClientID%>").val());
            if (contacts == "" || contacts.length < 2) {
                alert("请填写联系人并且长度不能小于2！");
                window.event.returnValue = false;
                return;
            }
            var phone = $.trim($("#<%=txtmobile.ClientID%>").val());
            //alert(phone.length);
            var result = /^(13[0-9]|14[5|7]|15[0-9]|18[0-9]|17[0-9])\d{8}$/;
            if (!result.test(phone)) {
                alert("您填号码的包含非法字符！");
                window.event.returnValue = false;
                return;
            }
            if (phone == "" || phone.length != 11) {
                alert("请填写正确的联系电话！");
                window.event.returnValue = false;
                return;
            }
            
            var userpwd = $.trim($("#<%=txtpassw.ClientID%>").val());
            if (userpwd == "" || userpwd.length < 6) {
                alert("请填写密码并且长度不能小于6！");
                window.event.returnValue = false;
                return;
            }

            var passwc = $.trim($("#<%=txtpasswc.ClientID%>").val());
            if (userpwd != "") {
                if (userpwd == passwc) {

                } else {
                    alert("两次密码输入的不一致，请重新输入！");
                    window.event.returnValue = false;
                    return;
                }
            }
           

        }
        




        //级联方法
        $("#<%=ddlProvince.ClientID %>").change(function () {
            $.getJSON("../data/locationss.ashx", { "locationid": $("#<%=ddlProvince.ClientID %>").val(), "type": "city" }, function (json) {
              $("#mainContent_ddlCity option").remove();
              json = JSON.parse(json);

              if (json[0].Message === "OK") {
                  $("#<%=ddlCity.ClientID %>").html(json[1].data);
                        //市改变方法填充区
                        $.getJSON("../data/locationss.ashx", { "locationid": $("#<%=ddlCity.ClientID %>").val(), "type": "county" }, function (json) {
                            $("#mainContent_ddlCounty option").remove();
                            json = JSON.parse(json);
                            if (json[0].Message === "OK") {
                                $("#<%=ddlCounty.ClientID %>").html(json[1].data);
                                $("#mainContent_hid").val($("#mainContent_ddlCounty").val());
                            }
                            else {
                                $("#mainContent_hid").val(-1);
                                $("#mainContent_ddlCounty option").remove();
                                $("#<%=ddlCounty.ClientID %>").html("<option value='0'>选择县/区</option>");
                            }
                        })
                    }
                    else {
                        $("#mainContent_hid").val(0);
                        $("#mainContent_ddlCity option").remove();
                        $("#mainContent_ddlCounty option").remove();
                        $("#<%=ddlCity.ClientID %>").html("<option value='0'>选择市</option>");
                        $("#<%=ddlCounty.ClientID %>").html("<option value='0'>选择县/区</option>");
                    }
            })
      })
            $("#<%=ddlCity.ClientID %>").change(function () {
            $.getJSON("../data/locationss.ashx", { "locationid": $("#<%=ddlCity.ClientID %>").val(), "type": "county" }, function (json) {
                    $("#mainContent_ddlCounty option").remove();
                    json = JSON.parse(json);
                    if (json[0].Message === "OK") {
                        $("#<%=ddlCounty.ClientID %>").html(json[1].data);
                        $("#mainContent_hid").val($("#mainContent_ddlCounty").val());
                    }
                    else {
                        $("#mainContent_hid").val(-1);
                        $("#mainContent_ddlCounty option").remove();
                        $("#<%=ddlCounty.ClientID %>").html("<option value='0'>选择县/区</option>")
                    }
            })
            })
            $("#<%=ddlCounty.ClientID %>").change(function () {
            $("#<%=qx.ClientID %>").val(this.value);
                $("#mainContent_hid").val($("#mainContent_ddlCounty").val());

            });
    </script>
</asp:Content>
