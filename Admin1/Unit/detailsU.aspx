<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="detailsU.aspx.cs" Inherits="Unit_detailsU" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <link href="../css/Unitstyle.css" rel="stylesheet" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <link href="../css/Style2.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <div>
        <div class="page_title" style="margin: auto 16px;">
            <h2 style="font-size:20px;float:left">详情信息</h2>
            <a href="Supervise.aspx" style="float:right;margin-top:10px">返回</a>
        </div>
        <!-- 详情信息开始 -->
        <div style="text-align: center">
            <table class="table1">
                <tr class="tr_trbg" style="float: left">
                    <td class="td td_rlast" style="width: 25%">企业代码</td>
                    <td class="td" style="width: 25%"><%=unitID %></td>
                </tr>
                <tr class="tr_trbg" style="float: right">
                    <td class="td td_rlast" style="width: 25%">状态</td>
                    <td class="td" style="width: 25%"><%=UnitState %></td>
                </tr>
                <tr class="tr_trbg" style="float: right">
                    <td class="td td_rlast" style="width: 25%">税号</td>
                    <td class="td" style="width: 25%"><%=TaxNumber %></td>
                </tr>
                <tr class="tr_trbg" style="float: left">
                    <td class="td td_rlast" style="width: 25%">单位名称</td>
                    <td class="td" style="width: 25%"><%=UnitName %></td>
                </tr>
                <tr class="tr_trbg" style="float: right">
                    <td class="td td_rlast" style="width: 25%">地址</td>
                    <td class="td" style="width: 25%"><%=Address %></td>
                </tr>
                <tr class="tr_trbg" style="float: left">
                    <td class="td td_rlast" style="width: 25%">管理密码</td>
                    <td class="td" style="width: 25%"><%=AdminPwd %></td>
                </tr>
                <tr class="tr_trbg" style="float: right">
                    <td class="td td_rlast" style="width: 25%">绑定码</td>
                    <td class="td" style="width: 25%"><%=UsbKey %></td>
                </tr>
                <tr class="tr_trbg" style="float: left">
                    <td class="td td_rlast" style="width: 25%">所在地区</td>
                    <td class="td" style="width: 25%"><%=Area %></td>
                </tr>
                <tr class="tr_trbg" style="float: right">
                    <td class="td td_rlast" style="width: 25%">负责人</td>
                    <td class="td" style="width: 25%"><%=LinkMan %></td>
                </tr>
                <tr class="tr_trbg" style="float: left">
                    <td class="td td_rlast" style="width: 25%">授权密钥</td>
                    <td class="td" style="width: 25%"><%=AuthToken %></td>
                </tr>
                <tr class="tr_trbg" style="float: right">
                    <td class="td td_rlast" style="width: 25%">电话</td>
                    <td class="td" style="width: 25%"><%=Phone %></td>
                </tr>
                <tr class="tr_trbg" style="float: left">
                    <td class="td td_rlast" style="width: 25%">工商执照</td>
                    <td class="td" style="width: 25%"><%=ICNumber %></td>
                </tr>
                <%--<tr class="tr_trbg">
                    <td class="">备注</td>
                    <td class=""><%=Remark %></td>
                </tr>--%>
                <tr>
                    <td>
                        <div class="div1">
                            <div class="div1_1">
                                <span>备注</span>
                            </div>
                            <div class="div1_2">
                                <span><%=Remark %></span>
                            </div>
                        </div>
                    </td>
                </tr>
            </table>
        </div>
        <!-- 详情信息结束 -->
    </div>
</asp:Content>

