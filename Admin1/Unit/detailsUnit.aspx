<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="detailsUnit.aspx.cs" Inherits="Unit_detailsUnit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>企业详情</title>
    <link href="../css/Unitstyle.css" rel="stylesheet" />
    <link href="../css/Style2.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <div>
        <div class="page_title" style="margin: auto 16px;">
            <h2 style="font-size: 20px; float: left; position: absolute; margin-top: 10px;">详情信息</h2>
            <%--<a href="Supervise.aspx" style="float:right;margin-top:10px">返回</a>
            <a href="Supervise.aspx" class="group_btn" style="position: absolute;right: 1%;line-height: 35px;float:right">返回</a>--%>
        </div>
        <!-- 详情信息开始 -->
        <div class="cb_box pos-r">
            <div class="table_body_box table_A ">
                <table width="98%" border="1" style="color: #ffffff; margin: 12px 18px;">
                    <tr class="tbb_title">
                        <th>许可证号</th>
                        <td class="sj"><%=unitID %></td>
                    </tr>
                    <tr class="tbb_title">
                        <th>企业名称</th>
                        <td class="sj"><%=UnitName %></td>
                    </tr>
                    <tr class="tbb_title">
                        <th>负责人</th>
                        <td class="sj"><%=LinkMan %></td>
                    </tr>
                    <tr class="tbb_title">
                        <th>电话</th>
                        <td class="sj"><%=Phone %></td>
                    </tr>
                    <tr class="tbb_title">
                        <th>所在区域</th>
                        <td class="sj"><%=Area %></td>
                    </tr>
                    <tr class="tbb_title">
                        <th>地址</th>
                        <td class="sj"><%=Address %></td>
                    </tr>
                    <tr class="tbb_title">
                        <th>质量信誉等级</th>
                        <td class="sj"><%=Crerating %></td>
                    </tr>
                    <tr class="tbb_title">
                        <th>经营类别</th>
                        <td class="sj"><%=Categories %></td>
                    </tr>
                    <tr class="tbb_title">
                        <th>经营范围</th>
                        <td class="sj"><%=Range %></td>
                    </tr>
                    <%--<tr class="tr_trbg">
                    <td class="">备注</td>
                    <td class=""><%=Remark %></td>
                </tr>--%>
                </table>
            </div>
        </div>
        <!-- 详情信息结束 -->
    </div>
</asp:Content>

