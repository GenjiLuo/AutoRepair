<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Information.aspx.cs"  EnableEventValidation="false" Inherits="Repair_Information" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>档案信息实时统计</title>
    <script src="../js/echarts.min.js"></script>
    <link href="../css/Unitstyle.css" rel="stylesheet" />
    <link href="../css/repairlist.css" rel="stylesheet" />
    <link href="../css/Organization.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
       <div >
            <div class="m-search_order clear" style=" margin: 20px 92px;">
                <div class="cbs_box fo">
                    <div class="xtb_class">
                        <b class="xtb_name">省：</b>
                        <span class="xtb_text_box width124">
                            <asp:DropDownList ID="ddlProvince" runat="server" CssClass="xtb_choose"></asp:DropDownList>
                        </span>
                    </div>
                    <div class="xtb_class" style="padding-left: 15px;">
                        <b class="xtb_name">市：</b>
                        <span class="xtb_text_box width124">
                            <asp:DropDownList ID="ddlCity" runat="server" CssClass="xtb_choose">
                                <asp:ListItem Value="0">选择市</asp:ListItem>
                            </asp:DropDownList>
                            <asp:TextBox ID="txt_hid" runat="server" style="display:none"></asp:TextBox>
                        </span>
                    </div>
                    <div class="xtb_class" style="padding-left: 15px;">
                        <b class="xtb_name">区（县）：</b>
                        <span class="xtb_text_box width124"> 
                            <asp:DropDownList ID="ddlCounty" runat="server" CssClass="xtb_choose">
                                <asp:ListItem Value="0">选择县/区</asp:ListItem>
                            </asp:DropDownList>
                            <asp:TextBox ID="qx" runat="server" Style="display: none;"  ></asp:TextBox>
                        </span>
                    </div> 
                    <%--style="padding-top: 6px; width: 1086px;"--%>
                    <div>
                        <span style="float: right; padding-right: 5px;"> 
                            <asp:Button ID="savess" runat="server" Text="查询" CssClass="xtb_button bg_blue" Style="position: absolute;" OnClick="savess_Click1" />
                        </span>
                    </div>

                </div>
                <asp:TextBox ID="hid" runat="server" Text="0" Style="display: none;" ></asp:TextBox>
            </div>
        </div>
    <div id="main" style="width: 98%; height: 450px; text-align: center;"></div>
     <script type="text/javascript">  

         $(document).ready(function(){   
             // 基于准备好的dom，初始化echarts实例
             var myChart = echarts.init(document.getElementById('main')); 
             var datas=<%= data %>;
             var datal=<%=datalist%>;
                    // 指定图表的配置项和数据
                    var option = {
                        title: {
                            text: '档案信息实时统计',
                            left:'10%',
                        },
                        tooltip: {},
                        legend: {
                            data: ['档案信息实时统计'],

                        },
                        xAxis: {
                            data:datas
                        },
                        yAxis: {},
                        grid: {
                            //left: '30%',
                            //right: '30%',
                            //bottom: '30%',
                            containLabel: true
                        },
                        series: [{
                            name: '档案信息实时统计',
                            type: 'bar',
                            //barWidth: '30%',
                            data: datal
                        }]
                    };

                    // 使用刚指定的配置项和数据显示图表。
                    myChart.setOption(option);
                }) 

            </script>
     <script type="text/javascript">
         //级联方法 
     
         $("#<%=ddlProvince.ClientID %>").change(function () {
             $.getJSON("../data/locationss.ashx", { "locationid": $("#<%=ddlProvince.ClientID %>").val(), "type": "city" }, function (json) {
                     $("#mainContent_ddlCity option").remove(); 
                     json = JSON.parse(json); 
                     if (json[0].Message === "OK") { 
                         $("#<%=ddlCity.ClientID %>").html(json[1].data);
                         $("#<%=txt_hid.ClientID %>").val($("#<%=ddlCity.ClientID %>").val());
                        //市改变方法填充区
                        $.getJSON("../data/locationss.ashx", { "locationid": $("#<%=ddlCity.ClientID %>").val(), "type": "county" }, function (json) {
                            $("#mainContent_ddlCounty option").remove();
                            json = JSON.parse(json);
                            if (json[0].Message === "OK") {
                                $("#<%=ddlCounty.ClientID %>").html(json[1].data);
                                $("#<%=qx.ClientID %>").val($("#mainContent_ddlCounty").val());
                            }
                            else { 
                                $("#<%=qx.ClientID %>").val(-1);
                                $("#mainContent_ddlCounty option").remove();
                                $("#<%=ddlCounty.ClientID %>").html("<option value='0'>选择县/区</option>"); 
                            }
                        })
                    }
                     else { 
                         $("#<%=txt_hid.ClientID %>").val(0);
                        $("#<%=qx.ClientID %>").val(-1);
                        $("#mainContent_ddlCity option").remove();
                        $("#mainContent_ddlCounty option").remove();
                        $("#<%=ddlCity.ClientID %>").html("<option value='0'>选择市</option>");
                        $("#<%=ddlCounty.ClientID %>").html("<option value='0'>选择县/区</option>"); 
                    }
            })
             })
            $("#<%=ddlCity.ClientID %>").change(function () {
             $.getJSON("../data/locationss.ashx", { "locationid": $("#<%=ddlCity.ClientID %>").val(), "type": "county" }, function (json) {
                    $("#mainContent_ddlCounty option").remove();
                    json = JSON.parse(json);
                    if (json[0].Message === "OK") {
                        $("#<%=txt_hid.ClientID %>").val($("#<%=ddlCity.ClientID %>").val());
                        $("#<%=ddlCounty.ClientID %>").html(json[1].data);
                        $("#<%=qx.ClientID %>").val($("#mainContent_ddlCounty").val());
                    }
                    else {
                        $("#<%=txt_hid.ClientID %>").val(0);
                        $("#<%=qx.ClientID %>").val(-1);
                        $("#mainContent_ddlCounty option").remove();
                        $("#<%=ddlCounty.ClientID %>").html("<option value='0'>选择县/区</option>")
                    }
            })
            })
            $("#<%=ddlCounty.ClientID %>").change(function () {
             $("#<%=qx.ClientID %>").val(this.value);
                $("#<%=qx.ClientID %>").val($("#mainContent_ddlCounty").val());

            });
      
          
    </script>
   
    <div style="text-align: center; padding-left: 6%;">
        <table class="table" style="width: 80%; text-align: center; border-collapse: collapse;">
            <tr class="trbg">
                <td class="td_rlast" style="width: 100px">企业名称</td>
           <%-- <td class="td_rlast" style="width: 50px">在线状态</td>--%>
                <td class="td_rlast" style="width: 100px">已接车订单数量</td>
                <td class="td_rlast" style="width: 100px">在修订单数量</td>
                <td class="td_rlast" style="width: 100px">出厂订单数量</td>
                <td class="td_rlast" style="width: 100px">已结算订单数量</td>
                <td class="td_rlast" style="width: 100px">未结算订单数量</td>
                <td class="td_rlast" style="width: 100px">结算总额</td>
                <td class="td_rlast" style="width: 100px">操作</td>
            </tr>
            <asp:Repeater ID="rptTaskList" runat="server">
                <ItemTemplate>
                    <tr>
                        <td class="td_rlast" style="width: 60px"><%#Eval("UnitName").ToString().Length>7?Eval("UnitName").ToString().Substring(0,7)+"":Eval("UnitName")%></td>
                        <td class="td_rlast" style="width: 60px"><%#Eval("num")%></td>
                        <td class="td_rlast" style="width: 60px"><%#Eval("numjin")%></td>
                        <td class="td_rlast" style="width: 60px"><%#Eval("numchu")%></td>
                        <td class="td_rlast" style="width: 60px"><%#Eval("numchu")%></td>
                        <td class="td_rlast" style="width: 60px"><%#Eval("numjin")%></td>
                        <td class="td_rlast" style="width: 60px"><%#Eval("picenum")%></td>
                        <td class="td_rlast" style="width: 60px"><a href="RepairList.aspx?unitID=<%#Eval("UnitID")%>">查看订单</a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>

</asp:Content>

