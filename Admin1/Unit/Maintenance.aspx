<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Maintenance.aspx.cs" Inherits="Unit_Maintenance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>档案信息历史统计</title>
    <script src="../js/echarts.min.js"></script>
    <script src="../js/datepicker/WdatePicker.js"></script>
    <link href="../css/statement.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <div style="position: absolute; height: 100%; width: 100%; overflow: auto">
        <div>
            <ul style="margin: 10px 70px;">
                <li>
                    <span>日期时间：</span>
                    <asp:TextBox id="txt_startTime" class="Wdate" type="text" onfocus="WdatePicker({maxDate:'#F{$dp.$D(\'mainContent_txt_endTime\')||\'%y-%M-{%d-1}\'}'})" runat="server"></asp:TextBox>
                    至
                    <asp:TextBox id="txt_endTime" class="Wdate" type="text" onfocus="WdatePicker({minDate:'#F{$dp.$D(\'mainContent_txt_startTime\')}',maxDate:'%y-%M-{%d-1}'})" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_seach" runat="server" Text="查询" Style="border: 1px #2C6AA0 solid; background: #2C6AA0; color: white; padding: 0 15px; height: 25px;" OnClick="btn_seach_Click" />
                </li>
            </ul>
        </div>
        <div style="margin-left:5%;margin-right:5%;margin-top:2%">
            <table class="table" style="width: 100%; text-align: center; border-collapse: collapse;">
                <tr class="trbg" style="background-color: #f8f8f8">
                    <td class="td_rlast" style="width: 60px">企业名称</td>
                    <td class="td_rlast" style="width: 50px">档案数量</td>
                    <td class="td_rlast" style="width: 50px">结算金额</td>
                    <td class="td_rlast" style="width: 50px">操作</td>

                </tr>
                <asp:Repeater ID="rptStatementt" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td class="td_rlast" style="width: 60px"><%#Eval("UnitName")%></td>
                            <td class="td_rlast" style="width: 60px"><%#Eval("zongshu") %></td>
                            <td class="td_rlast" style="width: 60px"><%#Eval("zongjine") %></td>
                            <td class="td_rlast" style="width: 60px"><a href="../Repair/RepairList.aspx?unitID=<%#Eval("UnitID")%>&FinishDate=<%=where %>">查看订单</a></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
            <br />
        </div>
    </div>
</asp:Content>

