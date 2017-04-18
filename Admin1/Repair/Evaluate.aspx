<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Evaluate.aspx.cs" Inherits="Repair_Evaluate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>汽车健康档案查看评价</title>
    <link href="../css/repairlist.css" rel="stylesheet" />
    <link href="../css/repair.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <div class="rt_whiteBox" style="height: 784px;">

        <div class="page_title" style="margin: auto 16px;">
            <h2><strong style="font-size: 20px;">汽车健康档案查看评价</strong></h2>
        </div>
        <div class="cb_box pos-r">
            <div class="table_body_box table_A ">
                <%if(n>0){ %>
                <table width="98%" border="1" style="color: #ffffff; margin: 12px 18px;">
                    <tbody>
                        <tr class="tbb_title">

                            <th style="width: 25%">评价</th>
                            <th style="width: 25%">评价时间</th>
                            <th style="width: 25%">追加评论</th>
                            <th style="width: 25%">追加评论时间</th>
                        </tr>
                    </tbody>
                    <tr style="color: #000; border: 1px solid #808080; height: 30px; border: 1px solid #E1DFDF;">
                        <td><%=AssessCount %></td>
                        <td><%=AddTime %></td>
                        <td><%=AssessCount2%></td>
                        <td><%=AddTime2 %></td>
                    </tr>
                </table>
                <%}else{ %>
                <div style="text-align:center;">
                    暂无评价记录......
                </div>
                <%} %>
            </div>
        </div>

    </div>

</asp:Content>

