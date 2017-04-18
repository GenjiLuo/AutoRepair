<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReservationInfo.aspx.cs" Inherits="reservation_ReservationInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" /> 
    <title>预约维修</title>
    <%-- 适应手机屏幕 --%>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <%-- 调用打电话\发短信 --%>
    <meta name="format-detection" content="telephone=no" />
    <meta http-equiv="x-rim-auto-match" content="none" />
    <%-- 微信样式库 --%>
    <link href="../css/weui.min.css?time=New Date()" rel="stylesheet" /> 
    <%-- 日期控件样式库 --%>
    <link href="../css/DateTimePicker.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <!--weiui-->
        <div class="weui_toptips weui_warn js_tooltips" style="display: none;">请填写真实姓名</div>
        <div id="toast" style="display: none;">
            <div class="weui_mask_transparent"></div>
            <div class="weui_toast">
                <i id="i_picture" class="weui_icon_toast"></i>
                <p class="weui_toast_content">预约成功</p>
            </div>
        </div>
        <%-- 我要预约 --%>
        <div class="weui_cells weui_cells_access">
            <a class="weui_cell" href="">
                <div class="weui_cell_hd">
                    <img src="../images/landmark.png" alt="地标" style="width: 20px; margin-right: 5px; display: block" />
                </div>
                <div class="weui_cell_bd weui_cell_primary">
                    <p><%=unitName %></p>
                </div>
                <div class="weui_cell_ft"></div>
            </a>
            <a class="weui_cell" href="tel:0531-88798878">
                <div class="weui_cell_hd">
                    <img src="../images/Phone.png" alt="电话" style="width: 20px; margin-right: 5px; display: block" />
                </div>
                <div class="weui_cell_bd weui_cell_primary">
                    <p><%=phone %></p>
                </div>
                <div class="weui_cell_ft"></div>
            </a> 
            <div class="weui_cell">
                <div class="weui_cell_hd">
                    <label class="weui_label_l">预约时间</label>
                </div>
                <div class="weui_cell_primary">
                    <input  id="txt_orderTime" class="weui_input endDateTime1" type="text" data-field="datetime" data-startend="end" readonly="true"  placeholder="年/月/日 -- ：--" /> 
                </div>
            </div>
        </div>
        <textarea id="txt_content" class="weui_textarea_l" placeholder="车辆故障描述......" rows="6" style="border: 1px solid #d4d4d4" maxlength="200"></textarea>
        <div class="weui_textarea_counter"><span id="nubmerin">0</span>/200&nbsp;&nbsp;&nbsp;</div>
        <div class="weui_btn_area">
            <a id="showTooltips" class="weui_btn weui_btn_warn">确定</a>
        </div> 
        <%-- 日期控件容器 --%>
        <div id="dtBox"></div>
    </form> 
    <script src="../js/jquery-1.7.2.min.js"></script> 
    <%-- 日期控件 --%>
    <script src="../js/DateTimePicker.js"></script>
    <script>
        $(document).ready(function () {
            //日期控件绑定事件
            $("#dtBox").DateTimePicker();
            //显示当前车辆故障信息字数
            $("#txt_content").keyup(function () {
                $("#nubmerin").html($(this).val().length);
            })
            //保存事件
            $("#showTooltips").click(function () { 
                if ($.trim($("#txt_orderTime").val()) === "") {
                    $(".weui_toptips").html("请选择时间");
                    $(".weui_toptips").show();
                    setTimeout(function () { $(".weui_toptips").hide(); }, 1000);
                    return;
                } 
                var userId = "<%=userId %>", unitId = "<%=unitId %>";
                $.post("../data/data.aspx", { type: "Order", userid: userId, unitid: unitId, ordertime: $.trim($("#txt_orderTime").val()), ordercontent: $.trim($("#txt_content").val()) }, function (result) {
                    if (result === "1") {
                        $("#toast").show();
                        setTimeout(function () { window.location.href = "reservationlist.aspx"; }, 1000);
                    }
                    else if (result === "-1") {
                        $(".weui_toptips").html("保存失败，请重新尝试！");
                        $(".weui_toptips").show();
                        setTimeout(function () { $(".weui_toptips").hide(); }, 2000);
                    }
                    else if (result === "-2") {
                        $(".weui_toptips").html("您最近已经预约过！");
                        $(".weui_toptips").show();
                        setTimeout(function () { $(".weui_toptips").hide(); }, 2000);
                    }
                    else if (result === "-3") {
                        $(".weui_toptips").html("您还没有添加过车辆信息！");
                        $(".weui_toptips").show();
                        setTimeout(function () { $(".weui_toptips").hide(); }, 2000);
                    }
                })
            })
        })
    </script>
</body>
</html>
