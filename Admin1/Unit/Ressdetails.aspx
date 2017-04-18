<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Ressdetails.aspx.cs" Inherits="Unit_Ressdetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>城市企业统计列表</title>
    <link href="../css/Unitstyle.css" rel="stylesheet" />
    <link href="../css/Style2.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <div class="m-search_order clear">
        <div class="searchitem">
            <%--<label>单位名称：</label>
                <asp:TextBox ID="txtProductName" runat="server" class="textbox s textbox_125"></asp:TextBox> --%>
        </div>
        <div class="searchitem">
            <%--<label>负责人：</label>
                <asp:TextBox ID="txtBuyer" runat="server" class="textbox  s textbox_80"></asp:TextBox>--%>
        </div>
        <a href="Statistics.aspx" class="group_btn" style="position: absolute; bottom: 10%; right: 1%; line-height: 30px;">返回</a>
    </div>
    <div>
        <table class="table">
            <tr class="trbg">
                <td class="td_rlast" style="width: 60px">企业名称</td>
                <td class="td_rlast" style="width: 50px">负责人</td>
                <td class="td_rlast" style="width: 50px">电话</td>
                <td class="td_rlast" style="width: 50px">地址</td>
            </tr>
            <asp:Repeater ID="rptTaskList" runat="server">
                <ItemTemplate>
                    <tr class="trbg">
                        <td class="td_rlast" style="width: 60px"><%#Eval("UnitName") %></td>
                        <td class="td_rlast" style="width: 50px"><%#Eval("LinkMan") %></td>
                        <td class="td_rlast" style="width: 50px"><%#Eval("Phone") %></td>
                        <td class="td_rlast" style="width: 50px"><%#Eval("Address") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</asp:Content>

