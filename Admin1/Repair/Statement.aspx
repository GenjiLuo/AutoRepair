<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Statement.aspx.cs" Inherits="Repair_Statement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>汽车健康档案记录</title>
    <script src="../js/echarts.min.js"></script>
    <script src="../js/datepicker/WdatePicker.js"></script>
    <link href="../css/statement.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <div style="position: absolute; height: 100%; width: 100%; overflow: auto">
        <div>
            <ul style="margin: 0 70px;">
                <li>
                    <span style="width: 120px;">请选择企业：</span>
                    <asp:DropDownList ID="ddl_Uid" runat="server" Style="border: 1px solid #B0AEAE;height: 25px;" OnSelectedIndexChanged="ddl_Uid_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                    <span>下单时间：</span>
                    <input id="txt_startTime" class="Wdate" type="text" onfocus="WdatePicker({maxDate:'#F{$dp.$D(\'mainContent_txt_endTime\')||\'%y-%M-{%d-1}\'}'})" runat="server"/>  
                    至  
                    <input id="txt_endTime" class="Wdate" type="text" onfocus="WdatePicker({minDate:'#F{$dp.$D(\'mainContent_txt_startTime\')}',maxDate:'%y-%M-{%d-1}'})" runat="server"/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_seach" runat="server" Text="查询" style="border: 1px #2C6AA0 solid; background: #2C6AA0; color: white; padding: 0 15px; height: 25px;" OnClick="btn_seach_Click"/> 
                </li>
            </ul>
        </div>
            <div id="main" style="width:1000px; height: 500px;/*margin: auto 300px;*/ margin-top: 50px;">
            <script type="text/javascript">  

                $(document).ready(function(){   
                    // 基于准备好的dom，初始化echarts实例
                    var myChart = echarts.init(document.getElementById('main')); 
                    var values=<%=value%>; //数据
                    var data = <%=data %>; //日期 
                    // 指定图表的配置项和数据
                    var option = {
                        title: {
                            text: '汽车健康档案统计',
                            left:'10%',
                        },
                        tooltip: {},
                        legend: {
                            data: ['健康档案数量'],

                        },
                        xAxis: {
                            data:data
                        },
                        yAxis: {},
                        grid: {
                            //left: '30%',
                            //right: '30%',
                            //bottom: '30%',
                            containLabel: true
                        },
                        series: [{
                            name: '健康档案数量',
                            type: 'bar',
                            //barWidth: '30%',
                            data: values
                        }]
                    };

                    // 使用刚指定的配置项和数据显示图表。
                    myChart.setOption(option);
                   }) 
            </script>
        </div>
      
        
 
        <div>
                   <div style="margin:auto 350px"> <span >公司：<%=UnitName %></span></div>
            <table class="table" style="width: 800px; text-align: center; border-collapse: collapse; margin: auto 110px">
                <tr class="trbg" style="background-color: #f8f8f8">
                    <td class="td_rlast" style="width: 60px">日期</td>
                    <td class="td_rlast" style="width: 50px">健康档案数量</td>

                </tr>
                <asp:Repeater ID="rptStatementt" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td class="td_rlast" style="width: 60px"><%#Eval("d").ToString().Length>9?Eval("d").ToString().Replace("%20","").Substring(0,9)+" ":Eval("d").ToString().Replace("%20","")%></td>
                            <td class="td_rlast" style="width: 60px"><%#Eval("num") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
            <br />
        </div>
    </div>

</asp:Content>

