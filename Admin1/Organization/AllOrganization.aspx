<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllOrganization.aspx.cs" Inherits="Organization_AllOrganization" MasterPageFile="~/MasterPage.master" EnableEventValidation="false" %>

<asp:Content runat="server" ContentPlaceHolderID="header">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <link href="../css/repairlist.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
    <link href="../css/Organization.css" rel="stylesheet" />
    <script src="../layer/layer.js"></script>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">

    <style>
        .table {
            border-collapse: collapse;
            overflow: hidden;
        }

            .table th, table td {
                border: 1px solid #E1DFDF;
                border-width: 0 1px 1px 0;
            }
    </style>

    <div class="page_title" style="margin: auto 16px;">
        <h2><strong style="font-size: 20px;">机构列表</strong></h2>
    </div>
    <div class="cb_box pos-r">
        <div class="table_title_box">
            <div class="m-search_order clear" style="margin: 20px;">
                <div class="cbs_box fo">
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
                    <%--style="padding-top: 6px; width: 1086px;"--%>
                    <div>
                        <span style="float: right; padding-right: 5px;">
                            <%-- <input class="xtb_button bg_blue" style="position: absolute;" value="搜索" type="submit" />--%>
                            <asp:Button runat="server" CssClass="xtb_button bg_blue" Style="position: absolute;" Text="查询" ID="savess" OnClick="savess_Click" />
                        </span>
                    </div>

                </div>
                <asp:TextBox ID="hid" runat="server" Text="0" Style="display: none;"></asp:TextBox>
            </div>
        </div>
        <div class="table_body_box table_A ">
            <table width="98%" border="1" style="color: #ffffff; margin: 12px 18px;">
                <tbody>
                    <tr class="tbb_title">
                        <th>用户名</th>
                        <th>所在地区</th>
                        <th>机构名称</th>
                        <th>联系人</th>
                        <th>联系电话 </th>
                        <th>操作</th>

                    </tr>
                </tbody>
                <asp:Repeater runat="server" ID="rptl" OnItemCommand="rptl_ItemCommand">
                    <ItemTemplate>
                        <tr style="color: #000; border: 1px solid #808080; height: 30px; border: 1px solid #E1DFDF;">
                            <td><%#Eval("UserName") %></td>
                            <td><%#Eval("Address")%></td>
                            <td><%#Eval("Name") %></td>
                            <td><%#Eval("Contacts") %></td>
                            <td><%#Eval("Phone") %></td>

                            <td>
                                <span style="margin: 1px;">
                                    <asp:Button ID="delbutton" class="xtb_button_a " runat="server" Style="background-color: #fff;color:#2C6AA0; font-family: '微软雅黑';" Text="删除" CommandArgument='<%#Eval("DepartmentId") %>' CommandName="delete" />
                                </span>
                                <span style="margin: 1px;">
                                    <a class="xtb_button_in " type="button" style="padding: 5px 6px; padding-top: 1px; color: #2C6AA0;" href="OrganizationNew.aspx?id=<%#Eval("DepartmentId") %>">修改</a>
                                </span>


                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>

    </div>




    <script> 
       
        $("#<%=ddlProvince.ClientID %>").change(function () {
            $.getJSON("../data/locationss.ashx", { "locationid": $("#<%=ddlProvince.ClientID %>").val(), "type": "city" }, function (json) {
                $("#mainContent_ddlCity option").remove(); 
                    json = JSON.parse(json); 
                    if (json[0].Message === "OK") { 
                        $("#<%=ddlCity.ClientID %>").html(json[1].data);
                        $("#<%=qx.ClientID %>").val($("#<%=ddlCity.ClientID %>").val());
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
                    $("#<%=qx.ClientID %>").val($("#<%=ddlCity.ClientID %>").val()); 
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
                $("#mainContent_hid").val(this.value);  
            }); 
      

    </script>
</asp:Content>
