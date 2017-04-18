<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Supervise.aspx.cs" Inherits="Unit_Supervise" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>企业列表</title>
    <link href="../css/Unitstyle.css" rel="stylesheet" />
    <link href="../css/Style2.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <div class="rt_whiteBox" style="height: 784px;">
        <div class="page_title" style="margin: auto 16px;">
            <h2 style="position: absolute; margin-top: 10px;"><strong style="font-size: 20px;">企业列表</strong></h2>
        </div>
        <!-- 头部查询开始 -->
        <div class="cb_box pos-r">
            <div class="table_title_box">
                <div class="m-search_order clear">
                    <div class="searchitem">
                        <label>单位名称：</label>
                        <asp:TextBox ID="txtProductName" runat="server" class="textbox1 s textbox_125"></asp:TextBox>
                    </div>
                    <div class="searchitem">
                        <label>负责人：</label>
                        <asp:TextBox ID="txtBuyer" runat="server" class="textbox  s textbox_80"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnQuery" class="group_btn" runat="server" Text="查询" OnClick="btnQuery_Click" />
                </div>
            </div>
            <!-- 头部查询结束 -->
            <!-- 列表信息开始 -->
            <div class="table_body_box table_A ">
                <table width="98%" border="1" style="color: #ffffff; margin: 12px 18px;">
                    <tr class="tbb_title">
                        <td class="td_rlast" style="width: 8%;line-height: 20px;">企业名称</td>
                        <td class="td_rlast" style="width: 4%;line-height: 20px;">法定代表人</td>
                        <td class="td_rlast" style="width: 3%;line-height: 20px;">电话</td>
                        <td class="td_rlast" style="width: 3%;line-height: 20px;">所在区域</td>
                        <td class="td_rlast" style="width: 8%;line-height: 20px;">地址</td>
                        <td class="td_rlast" style="width: 3%;line-height: 20px;">质量信誉等级</td>
                        <td class="td_rlast" style="width: 3%;line-height: 20px;">经营类别</td>
                        <td class="td_rlast" style="width: 5%;line-height: 20px;">经营范围</td>
                        <td class="td_rlast" style="width: 8%;line-height: 20px;">操作</td>
                    </tr>
                    <asp:Repeater ID="rptTaskList" runat="server">
                        <ItemTemplate>
                            <tr style="color: #000; border: 1px solid #808080; height: 30px; border: 1px solid #E1DFDF;">
                                <td class="td_rlast" style="width: 8%;line-height: 20px;"><%#Eval("UnitName") %></td>
                                <td class="td_rlast" style="width: 4%;line-height: 20px;"><%#Eval("LinkMan") %></td>
                                <td class="td_rlast" style="width: 3%;line-height: 20px;"><%#Eval("Phone") %></td>
                                <td class="td_rlast" style="width: 3%;line-height: 20px;"><%#Eval("LocationName") %></td>
                                <td class="td_rlast" style="width: 8%;line-height: 20px;"><%#Eval("Address") %></td>
                                <td class="td_rlast" style="width: 3%;line-height: 20px;"><%#Eval("Crerating") %></td>
                                <td class="td_rlast" style="width: 3%;line-height: 20px;"><%#Eval("Categories") %></td>
                                <td class="td_rlast" style="width: 5%;line-height: 20px;"><%#Eval("Range") %></td>
                                <td class="td_rlast" style="width: 8%;line-height: 20px;">
                                <%--<a href="detailsUnit.aspx?unitID=<%#Eval("UnitID") %>"><span>查看详情</span></a>
                                <a><span>修改</span></a>
                                <a href="../Repair/RepairList.aspx?unitID=<%#Eval("UnitID") %>"><span>查看订单</span></a>--%>
                                    <%#Eval("UnitState").ToString().Equals("正常")?
                                    "<a href=\"../Repair/RepairList.aspx?unitID="+Eval("UnitID")+"\" class=\"table td a\" style=\"color: #2C6AA0;\"><span>订单</span></a><a href=\"detailsUnit.aspx?unitID="+Eval("UnitID")+"\" class=\"table td a\" style=\"color: #2C6AA0;\"><span>详情</span></a><a href=\"AddSupervis.aspx?unitID="+Eval("UnitID")+"\" class=\"table td a\" style=\"color: #2C6AA0;\"><span>修改</span></a><a href=\"javascript:del(" + Eval("UnitID") + ")\" class=\"table td a\" style=\"color: #2C6AA0;\">停用</a>"
                                    :"<a href=\"#\" class=\"table td a\" style=\"color: #2C6AA0;\"><span>订单</span></a><a href=\"#\" class=\"table td a\" style=\"color: #2C6AA0;\"><span>详情</span></a><a href=\"#\" class=\"table td a\" style=\"color: #2C6AA0;\"><span>修改</span></a><a href=\"javascript:del(" + Eval("UnitID") + ")\" class=\"table td a\" style=\"color: #2C6AA0;\">启用</a>"%>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
        </div>
        <!-- 列表信息结束 -->
        <!--分页-->
        <aside class="paging">
            <div class="das_pages">
                <webdiyer:AspNetPager ID="pager1" CssClass="paginator" CurrentPageButtonClass="cpb" runat="server" AlwaysShow="True"
                    FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PageSize="10" PrevPageText="上一页"
                    ShowInputBox="Never" OnPageChanged="AspNetPager1_PageChanged" CustomInfoTextAlign="Left">
                </webdiyer:AspNetPager>
            </div>
        </aside>
    </div>
    <script type="text/javascript">

        function del(UnitID) {
            if (parseInt(UnitID) > 0) {
                $.ajax({
                    url: "../data/data.aspx",
                    type: "POST",
                    data: {
                        type: "Deleteunit",
                        UnitID: UnitID
                    },
                    success: function (result) {
                        result = result.split(',');
                        if (result[0] == "1") {
                            alert(result[1] + "已停用！");
                            location.reload();
                        }
                        else {
                            alert(result[1] + "已启用！");
                            location.reload();
                        }
                    }
                })
            }
        }
    </script>
</asp:Content>

