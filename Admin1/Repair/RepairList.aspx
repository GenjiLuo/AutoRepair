<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RepairList.aspx.cs" Inherits="Repair_RepairList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>汽车健康档案列表</title>
    <link href="../css/repairlist.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
    <link href="../css/repair.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
<%--    <div style="width: 100%; height: 100%; overflow: scroll;">--%>
        <div class="rt_whiteBox" style="height: 784px;">

            <div class="page_title" style="margin: auto 16px;">
                <h2><strong style="font-size: 20px;">汽车健康档案列表</strong></h2>
            </div>
            <div class="cb_box pos-r">
                <div class="table_title_box">
                    <div class="m-search_order clear">
                        <div class="searchitem">
                            <label>许可证号：</label>
                            <asp:TextBox ID="txtUnitID" runat="server" class="textbox1  s textbox_80"></asp:TextBox>
                        </div>
                    

                        <div class="searchitem">
                            <label>汽车健康档案卡号：</label>
                            <asp:TextBox ID="txtCardKey" runat="server" class="textbox1  s textbox_80"></asp:TextBox>
                        </div>
                            <div class="searchitem">
                            <label>送修人：</label>
                            <asp:TextBox ID="txtRepairMan" runat="server" class="textbox1  s textbox_80"></asp:TextBox>
                        </div>
                        <div class="searchitem">
                            <label>车牌号码：</label>
                            <asp:TextBox ID="txtPlateNumber" runat="server" class="textbox1  s textbox_80"></asp:TextBox>
                        </div>
                        <asp:Button ID="btnQuery" class="group_btn1" runat="server" Text="查询" OnClick="btnQuery_Click" />
                    </div>
                </div>
                <div class="table_body_box table_A ">
                    <table width="98%" border="1" style="color: #ffffff; margin: 12px 18px;">
                        <tbody>
                            <tr class="tbb_title">
                                <th>编号</th>
                                <th>许可证号</th>
                                <th>汽车健康档案卡号</th>
                                <th>企业名称</th>
                                <th>送修人</th>
                                <th>电话</th>
                                <th>车牌号码 </th>
                                <th>进厂日期</th>
                                <th>合计费用</th>
                                <th>操作</th>
                            </tr>
                        </tbody>
                        <asp:Repeater ID="rptRepairList" runat="server">
                            <ItemTemplate>
                                <tr style="color: #000; border: 1px solid #808080; height: 30px; border: 1px solid #E1DFDF;">
                                    <td><%#Eval("ID") %></td>
                                    <td><%#Eval("UnitID") %></td>
                                    <td><%#Eval("CardKey") %></td>
                                    <td><%#Eval("UnitName") %></td>
                                    <td><%#Eval("RepairMan") %></td>
                                    <td><%#Eval("Phone") %></td>
                                    <td><%#Eval("PlateNumber") %></td>
                                    <td><%#Eval("SignDate") %></td>
                                    <td><%#Eval("TotalMoney") %></td>
                                    <td><a href="RepairDetails.aspx?id=<%#Eval("Id") %>" style="color: #2C6AA0;">详情</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                         <a href="Evaluate.aspx?id=<%#Eval("Id") %>" style="color: #2C6AA0;">查看评价</a>
                                    </td>
                                   
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </table>
                </div>
            </div>
            <aside class="paging">
                <div class="das_pages">
                    <webdiyer:AspNetPager ID="pager1" CssClass="paginator" CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"
                        FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PageSize="10" PrevPageText="上一页"
                        ShowInputBox="Never" OnPageChanged="AspNetPager1_PageChanged" CustomInfoTextAlign="Left">
                    </webdiyer:AspNetPager>
                </div>
            </aside>
        </div>
 <%--   </div>--%>
</asp:Content>

