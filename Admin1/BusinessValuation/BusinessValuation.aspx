<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BusinessValuation.aspx.cs" Inherits="BusinessValuation_BusinessValuation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <link href="../css/repairlist.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
    <link href="../css/Organization.css" rel="stylesheet" />
    <script src="../layer/layer.js"></script>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">

    <style>
        .cha {
            border: 1px #2c6aa0 solid;
            background: #2c6aa0;
            color: white;
            padding: 0 15px;
            height: 38px;
            cursor: pointer;
            display: inline-block;
            vertical-align: middle;
            float: right;
            margin-right: -25px;
        }
    </style>

    <div class="page_title" style="margin: auto 16px;">
        <h2><strong style="font-size: 20px;">评价列表</strong></h2>
    </div>
    <div class="cb_box pos-r">
        <div class="table_title_box">
            <div style="margin-bottom: 2%; padding-right: 4%; position: relative; margin: 30px 0px;">
                <div class="searchitem">
                    <label>企业名称：</label>
                    <asp:TextBox ID="txtUnitName" runat="server" class="textbox1 s textbox_125"></asp:TextBox>
                </div>
                <asp:Button ID="btnQuery" class="cha" runat="server" Style="margin-top: -35px;" Text="查询" OnClick="btnQuery_Click" />
            </div>
        </div>
        <div class="table_body_box table_A ">
            <table width="98%" border="1" style="color: #ffffff; margin: 12px 18px;">
                <tbody>
                    <tr class="tbb_title">
                        <th>企业名称</th>
                        <th>评价用户</th>
                        <th>评价内容</th>
                        <th>评价时间</th>
                        <th>追评内容</th>
                        <th>追评时间</th>
                        <th>综合评分 </th>
                        <th>操作</th>
                    </tr>
                </tbody>
                <asp:Repeater runat="server" ID="rptl">
                    <ItemTemplate>
                        <tr style="color: #000; border: 1px solid #808080; height: 30px; border: 1px solid #E1DFDF;">
                            <td><%#Eval("UnitName") %></td>
                            <td><%#Eval("RepairMan") %></td>
                            <td><%#Eval("AssessCount").ToString().Length>10?Eval("AssessCount").ToString().Replace("%20","").Substring(0,10)+"…":Eval("AssessCount").ToString().Replace("%20"," ")  %></td>
                            <td><%#Eval("AddTime") %></td>
                            <td><%#Eval("AssessCount2").ToString().Length>10?Eval("AssessCount2").ToString().Replace("%20","").Substring(0,10)+"…":Eval("AssessCount2").ToString().Replace("%20"," ")  %></td>
                            <td><%#Eval("AddTime2") %></td>
                            <td><%#Eval("ZongHe") %> </td>
                            <td>
                                <a href="../Unit/detailsUnit.aspx?unitID=<%#Eval("UnitID") %>" style="color: #2C6AA0;">查看企业</a>

                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </div>
</asp:Content>

