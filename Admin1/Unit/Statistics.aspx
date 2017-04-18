<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Statistics.aspx.cs" Inherits="Unit_Statistics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>城市统计列表图</title>
    <script src="../js/echarts.min.js"></script>
    <link href="../css/Unitstyle.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <div id="main" style="width: 98%; height: 450px;text-align:center;"></div>
    <script type="text/javascript">
        var myChart = echarts.init(document.getElementById('main'));
        var datas=<%= data %>;
            var datal=<%=datalist%>;
        var option = {
            title: {
                text: '山东省市区企业统计',
                subtext: '',
                left: '19%'
            },
            tooltip: {
                trigger: 'item',
                formatter: "{a} <br/>{b} : {c} ({d}%)"
            },
            legend: {
                orient: 'vertical',
                left: '6%',
                //center: ['60%', '80%'],
                data: datas
            },
            series: [
                {
                    name: '维修企业',
                    type: 'pie',
                    radius: '55%',
                    center: ['25%', '50%'],
                    data: datal,
                    itemStyle: {
                        emphasis: {
                            shadowBlur: 10,
                            shadowOffsetX: 0,
                            shadowColor: 'rgba(0, 0, 0, 0.5)'
                        }
                    }
                }
            ]
        };
        myChart.setOption(option);
    </script>
    <div style="text-align:center;padding-left: 6%;">
        <table class="table" style="width: 45%; text-align: center; border-collapse: collapse;">
            <tr class="trbg">
                <td class="td_rlast" style="width: 60px">地区</td>
                <td class="td_rlast" style="width: 50px">企业数量</td>
                <td class="td_rlast" style="width: 50px">操作</td>
            </tr>
            <asp:Repeater ID="rptTaskList" runat="server">
                <ItemTemplate>
                    <tr>
                        <td class="td_rlast" style="width: 60px"><%#Eval("LocationName") %></td>
                        <td class="td_rlast" style="width: 60px"><%#Eval("Total") %></td>
                        <td class="td_rlast" style="width: 60px"><a href="Ressdetails.aspx?Area=<%#Eval("Area") %>" >详情</a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</asp:Content>

