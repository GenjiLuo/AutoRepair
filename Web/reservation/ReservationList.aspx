<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReservationList.aspx.cs" Inherits="reservation_ReservationList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <meta name="format-detection" content="telephone=no" />
    <meta http-equiv="x-rim-auto-match" content="none" />
    <title>预约列表</title>
    <link rel="icon" sizes="any" href="../images/c.jpg" />
    <link href="../css/mui.min.css" rel="stylesheet" />
    <link href="../css/CarList.css" rel="stylesheet" />
    <script type="text/javascript" src="http://api.map.baidu.com/api?v=2.0&ak=oMec4PZ2dm851qSeOvxChSBC9f712RCB"></script>
    <style type="text/css">
        body, html, #map {
            width: 100%;
            height: 100%;
            margin: 0;
            font-family: "微软雅黑";
        }
        #center,#map,#lishi{display:none;}
         #center,#lishi{margin-top:60px;}
    </style>
</head>
<body id="body">
    <!-----------------------------------------选项卡----------------------------------------->
      <header class="mui-bar mui-bar-nav">
         <div class="mui-segmented-control">
              <a class="mui-control-item" href="ReservationList.aspx?type=1">推荐</a>
              <a class="mui-control-item" href="ReservationList.aspx?type=2">地图</a>
              <a class="mui-control-item" href="ReservationList.aspx?type=3">历史</a>
         </div>
      </header>
    <!-----------------------------------------推荐开始---------------------------------------->
    <div id="center" class="cla_div cla_k">
        <div class="center_1">
            <div class="center_2">
                <ul>
                    <asp:Repeater runat="server" ID="rptrecommended">
                        <ItemTemplate>
                            <li>
                                <div class="content_title">
                                    <div style="float: left; font-size: 16px; color: #000000"><%#Eval("UnitName") %></div>
                                    <div class="content_title_chepai"><b><a style="color: #007acc;" href="tel:<%#Eval("Phone") %>"><%#Eval("Phone") %></a></b></div>
                                </div>
                                <div class="content_con">
                                    <%#Eval("zonghe").ToString()!=""?star(float.Parse(Eval("zonghe").ToString())):"<div class=\"star\" style=\" background-position:-0px -75px;\"></div>"%>
                                    <div style="font-size: 12px; padding-top: 3px; color: #bdb5b5;">维修速度：<b><%#Eval("weixiuxl").ToString()!=""?Eval("weixiuxl"):0 %></b> &nbsp;服务态度：<b><%#Eval("fwtd").ToString()!=""?Eval("fwtd"):0 %></b> &nbsp;维修质量：<b><%#Eval("weixuizl").ToString()!=""?Eval("weixuizl"):0 %></b> </div>
                                </div>
                                <div class="content_foot">
                                    <div class="content_foot_address">地址：<%#Eval("Address") %></div>
                                    <div class="content_foot_pingjia"><a href="ReservationInfo.aspx?unitid=<%#Eval("UnitID") %>">预约</a></div>
                                </div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
        </div>
    </div>
    <!-----------------------------------------查看地图----------------------------------------->
    <div id="map" class="cla_div cla_k" ></div>
    <input type="text" id="hid" runat="server" style="display: none" />
    <!-----------------------------------------历史----------------------------------------->
    <div class="cls_yu center_1 cla_div cla_k" id="lishi">
        <div class="center_2">
            <ul>
                <%=record %>
                <asp:Repeater runat="server" ID="rptReservationList">
                    <ItemTemplate>
                        <li>
                            <div class="content_title">
                                <div style="float: left; font-size: 16px; color: #000000"><%#Eval("UnitName") %></div>
                                <div class="content_title_chepai"><b><a style="color: #007acc;" href="tel:<%#Eval("Phone") %>"><%#Eval("Phone") %></a></b></div>
                            </div>
                            <div class="content_con">
                                <div style="float: left; font-size: 12px; color: #bdb5b5;">维修时间：<%#Eval("OrderTime") %></div>
                                <div class="content_con_price">负责人：<%#Eval("LinkMan") %></div>
                            </div>
                            <div class="content_foot">
                                <div class="content_foot_address">地址：<%#Eval("Address") %></div>
                                <div class="content_foot_pingjia"><a href="ReservationInfo.aspx?unitid=<%#Eval("UnitID") %>">预约</a></div>
                            </div>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
    </div>
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript">
        // 百度地图API功能
        var map = new BMap.Map("map");
        var point = new BMap.Point(116.331398, 39.897445);
        map.centerAndZoom(point, 13);

        var geolocation = new BMap.Geolocation();
        geolocation.getCurrentPosition(function (r) {
            if (this.getStatus() == BMAP_STATUS_SUCCESS) { 
                var myIcon = new BMap.Icon("../images/location.gif", new BMap.Size(14, 23));
                var marker2 = new BMap.Marker(r.point, { icon: myIcon });  // 创建标注
                map.addOverlay(marker2);              // 将标注添加到地图中 
                map.panTo(r.point);
                $.getJSON("../data/mapParsing.ashx", { json: r.point.lng+","+r.point.lat }, function (json) {
                    console.log(json);
                    json = JSON.parse(json);
                    for (var i = 0; i < 3; i++) {
                        console.log(json.content[i].lag + "&&" + json.content[i].lat + "&&" + json.content[i].location + "&&" + json.content[i].phone + "&&" + json.content[i].unitid)
                    }
                    if (json.Message[0].Result === "Ok") {
                        var data_info = [
                             [json.content[0].lag, json.content[0].lat, "<span style='font-weight:bold;color:#0079fb'>" + json.content[0].location + "</span><br/>电话：<a  href=\"tel:" + json.content[0].phone + "\">" + json.content[0].phone + "</a><a href='../reservation/ReservationInfo.aspx?unitid=" + json.content[0].unitid + "' style='background-color:#0079fb;font-size:16px;font-weight:600;color:white;padding:5px;border-radius:5px;text-decoration:none;float:right'>去预约</a>"],
                             [json.content[1].lag, json.content[1].lat, "<span style='font-weight:bold;color:#0079fb'>" + json.content[1].location + "</span><br/>电话：<a  href=\"tel:" + json.content[1].phone + "\">" + json.content[1].phone + "</a><a href='../reservation/ReservationInfo.aspx?unitid=" + json.content[1].unitid + "' style='background-color:#0079fb;font-size:16px;font-weight:600;color:white;padding:5px;border-radius:5px;text-decoration:none;float:right'>去预约</a>"],
                             [json.content[2].lag, json.content[2].lat, "<span style='font-weight:bold;color:#0079fb'>" + json.content[2].location + "</span><br/>电话：<a  href=\"tel:" + json.content[2].phone + "\">" + json.content[2].phone + "</a><a href='../reservation/ReservationInfo.aspx?unitid=" + json.content[2].unitid + "' style='background-color:#0079fb;font-size:16px;font-weight:600;color:white;padding:5px;border-radius:5px;text-decoration:none;float:right'>去预约</a>"],
                             //[json.content.lag[3], json.content.lat[3], "<span style='font-weight:bold;color:#0079fb'>" + json.content.location[3] + "</span><br/>电话：" + json.content.phone[3] + "<a href='../reservation/ReservationInfo.aspx?unitid=" + json.content.unitid[3] + "' style='background-color:#0079fb;font-size:16px;font-weight:600;color:white;padding:5px;border-radius:5px;text-decoration:none;float:right'>去预约</a>"],
                             //[json.content.lag[4], json.content.lat[4], "<span style='font-weight:bold;color:#0079fb'>" + json.content.location[4] + "</span><br/>电话：" + json.content.phone[4] + "<a href='../reservation/ReservationInfo.aspx?unitid=" + json.content.unitid[4] + "' style='background-color:#0079fb;font-size:16px;font-weight:600;color:white;padding:5px;border-radius:5px;text-decoration:none;float:right'>去预约</a>"]
                        ];
                        console.log(data_info);
                        var opts = {
                            width: 100,     // 信息窗口宽度
                            //height: 80,     // 信息窗口高度
                            //title: "维修商", // 信息窗口标题
                            //enableMessage: true//设置允许信息窗发送短息
                        };
                        for (var i = 0; i < data_info.length; i++) {
                            var marker = new BMap.Marker(new BMap.Point(data_info[i][0], data_info[i][1]));  // 创建标注
                            var content = data_info[i][2];
                            map.addOverlay(marker);               // 将标注添加到地图中
                            addClickHandler(content, marker);
                        }
                        function addClickHandler(content, marker) {
                            marker.addEventListener("click", function (e) {
                                openInfo(content, e)
                            }
                            );
                        }
                        function openInfo(content, e) {
                            var p = e.target;
                            var point = new BMap.Point(p.getPosition().lng, p.getPosition().lat);
                            var infoWindow = new BMap.InfoWindow(content, opts);  // 创建信息窗口对象
                            map.openInfoWindow(infoWindow, point); //开启信息窗口
                        }
                    }
                })
            }
            else {
                alert('failed' + this.getStatus());
            }
        }, { enableHighAccuracy: true })


        window.onload = function () {
            var type = "<%=type%>";
            if (type == 1)
            {
                $("#center").css("display", "block");
            }
            if (type == 2)
            {
                $("#map").css("display", "block");
            }
            if (type == 3) {
                $("#lishi").css("display", "block");
            }
        }
    </script>
</body>
</html>
