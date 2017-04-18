<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registered.aspx.cs" Inherits="Registered" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>个人中心-注册/登入</title>
    <script src="js/jquery-1.7.2.min.js"></script>
    <link href="css/weui.min.css" rel="stylesheet" />　
</head>
<body>
    <form id="form1" runat="server">

        <!--weiui-->
        <div class="weui_toptips weui_warn js_tooltips" style="display: none;">格式不对</div> 
        <div id="toast" style="display: none;">
            <div class="weui_mask_transparent"></div>
            <div class="weui_toast">
                <i id="i_picture" class="weui_icon_toast"></i>
                <p class="weui_toast_content">注册成功</p>
            </div>
        </div>
        <!---->

        <div class="weui_cells weui_cells_form">
            <div class="weui_cell">
                <div class="weui_cell_hd">
                    <label class="weui_label">
                        <img src="images/57fdebf.png" width="25" /></label>
                </div>
                <div class="weui_cell_bd weui_cell_primary">
                    <input class="weui_input" id="txtphone" type="number" pattern="[0-9]*" placeholder="请输入手机号" />
                </div>
            </div>
            <div class="weui_cell weui_vcode weui_cell_warn" style="padding: 10px 15px 5px 15px;">
                <div class="weui_cell_hd">
                    <label class="weui_label">
                        <img src="images/33bfae7.png" width="25" /></label>
                </div>
                <div class="weui_cell_bd weui_cell_primary">
                    <input class="weui_input" id="txtyzm" type="number" placeholder="请输入验证码" />
                </div>
                <div class="weui_cell_ft">
                    <input type="button" value="获取验证码" id="btn_yzm" onclick="GetSms()" style="border: 1px solid #ff0000; border-radius: 5px; line-height: 25px; text-align: center; width: 75px; height: 25px; background-color: white; outline-style: none; color: red; font-weight: bold; margin-top: -5px" />
                </div>
            </div> 
        </div>

        <div class="weui_btn_area">
            <a class="weui_btn weui_btn_warn" id="showTooltips">确定</a>
        </div>

        <div class="weui_cells weui_cells_form">
            <div style="margin: 0 auto; max-width: 640px;">
                <div style="text-align: center; margin-top: 20px;">
                    <a href="#" style="color: #2a5a9b; font-size: 15px; text-decoration: underline;">更多信息，请下载App查询</a>
                </div>
                <div style="overflow: hidden; margin: 20px 10px;">
                    <div style="float: left; padding: 10px; background-color: #2b3e4f; border-radius: 10px; color: #fff; width: 40%; font-size: 15px; text-align: center;">
                        <img src="../images/1-55.png" style="width: 20px;" />
                        <span>分享到朋友圈</span>
                    </div>
                    <div style="float: right; padding: 10px; background-color: #2b3e4f; border-radius: 10px; color: #fff; width: 40%; font-size: 15px; text-align: center;">
                        <img src="../images/1-66.png" style="width: 20px;" />
                        <span>关注公众账号</span>
                    </div>
                </div>
            </div>
        </div>

    </form>
    <script>
        $(document).ready(function () {
            //开始注册
            $("#showTooltips").click(function () {
                if ($.trim($("#txtphone").val()) === "") {
                    $(".js_tooltips").html("手机号不能为空！")
                    $(".js_tooltips").show();
                    setTimeout(function () { $(".js_tooltips").hide() }, 1000);
                    return;
                }
                if ($.trim($("#txtyzm").val()) === "") {
                    $(".js_tooltips").html("请输入验证码！")
                    $(".js_tooltips").show();
                    setTimeout(function () { $(".js_tooltips").hide() }, 1000);
                    return;
                }
                var openId = '<%=openId %>';
                $.ajax({
                    url: "data/data.aspx",
                    type: "POST",
                    data: { type: "Regisetered", Phone: $.trim($("#txtphone").val()), openid: openId, yzm: $.trim($("#txtyzm").val()) },
                    success: function (result) {
                        if (parseInt(result) === 1) {
                            location.href = "user/Person.aspx";
                        }
                        else if (parseInt(result) === -2) {
                            $(".js_tooltips").html("验证码错误或已过期！")
                            $(".js_tooltips").show();
                            setTimeout(function () { $(".js_tooltips").hide() }, 1500);
                        }
                        else {
                            $(".js_tooltips").html("登入失败！")
                            $(".js_tooltips").show();
                            setTimeout(function () { $(".js_tooltips").hide() }, 1500);
                        }
                    }
                })
            })
        })
        //发送验证码
        function GetSms() {
            var reg = /^(13[0-9]|14[5|7]|15[0-9]|18[0-9]|17[0-9])\d{8}$/;
            var phone = $.trim($("#txtphone").val());
            if (!reg.test(phone)) {
                $(".js_tooltips").html("手机号格式不正确！")
                $(".js_tooltips").show();
                setTimeout(function () { $(".js_tooltips").hide() }, 1000);
                return;
            }
            $.post("data/data.aspx", { type: "getsms", phone: phone }, function () { settime(); });
        }
        //倒计时
        var countdown = 60;
        function settime() {
            if (countdown === 0) {
                document.getElementById("btn_yzm").removeAttribute("disabled");
                document.getElementById("btn_yzm").value = "获取验证码";
                countdown = 60;
            } else {
                document.getElementById("btn_yzm").setAttribute("disabled", true);
                document.getElementById("btn_yzm").value = "重新发送" + countdown + "";
                countdown--; 
                setTimeout(function () {
                    settime()
                }, 1000)
            } 
        }
    </script>
</body>
</html>
