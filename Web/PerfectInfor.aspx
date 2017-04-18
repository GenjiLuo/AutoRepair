<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PerfectInfor.aspx.cs" Inherits="PerfectInfor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>个人资料-完善资料</title>
    <script src="js/jquery-1.7.2.min.js"></script>
    <link href="css/weui.min.css" rel="stylesheet" />
    <link href="css/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <!--weiui-->
        <div class="weui_toptips weui_warn js_tooltips" style="display: none;">请输入真实姓名！</div>

        <div id="toast" style="display: none;">
            <div class="weui_mask_transparent"></div>
            <div class="weui_toast">
                <i id="i_picture" class="weui_icon_toast"></i>
                <p class="weui_toast_content">保存成功</p>
            </div>
        </div>
        <!---->
        <div class="weui_cells weui_cells_form">
            
            <div class="weui_cell">
                <div class="weui_cell_hd">
                    <label class="weui_label_l">姓名</label>
                </div>
                <div class="weui_cell_bd weui_cell_primary">
                    <input class="weui_input" maxlength="10" placeholder="请输入真实姓名" id="txt_RealName" />
                </div>
            </div>
            <div class="weui_cell weui_cell_select weui_select_after">
                <div class="weui_cell_hd">
                    <label for="" class="weui_label_t">证件类型</label>
                </div>
                <div class="weui_cell_bd weui_cell_primary">
                    <select class="weui_select" name="select2" id="ddlIdentityType">
                        <option value="1">身份证</option>
                    </select>
                </div>
            </div>
            <div class="weui_cell">
                <div class="weui_cell_hd">
                    <label class="weui_label_l">证件号</label>
                </div>
                <div class="weui_cell_bd weui_cell_primary">
                    <input class="weui_input" maxlength="18" placeholder="请输入证件号" id="txt_IdCard" />
                </div>
            </div>
            <div class="weui_cell">
                <div class="weui_cell_hd">
                    <label class="weui_label_l">邮箱</label>
                </div>
                <div class="weui_cell_bd weui_cell_primary">
                    <input class="weui_input" placeholder="请输入邮箱" id="txt_Mail" />
                </div>
            </div>
            <div class="weui_cell weui_cell_select weui_select_after">
                <div class="weui_cell_hd">
                    <label for="" class="weui_label_t">省</label>
                </div>
                <div class="weui_cell_bd weui_cell_primary">
                    <select class="weui_select" name="select2" id="ddlProvince" runat="server" onchange="provinceChange(0)">
                    </select>
                </div>
            </div>
            <div class="weui_cell weui_cell_select weui_select_after">
                <div class="weui_cell_hd">
                    <label for="" class="weui_label_t">市</label>
                </div>
                <div class="weui_cell_bd weui_cell_primary">
                    <select class="weui_select" name="select2" id="ddlCity" onchange="cityChange()">
                        <option value="0">选择市</option>
                    </select>
                </div>
            </div>
            <div class="weui_cell weui_cell_select weui_select_after">
                <div class="weui_cell_hd">
                    <label for="" class="weui_label_t">区</label>
                </div>
                <div class="weui_cell_bd weui_cell_primary">
                    <select class="weui_select" name="select2" id="ddlCounty">
                        <option value="0">选择县/区</option>
                    </select>
                </div>
            </div>
        </div>
        <div class="weui_cells_tips">为了您能正常获取和使用积分，请确认您填写的信息真实有效！</div>
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
            //已经完善过资料
            var mark = "<%=mark %>";
            if (parseInt(mark) === 1) {
                $("#ddlIdentityType").prop("disabled", true);
                $("#txt_IdCard").prop("disabled", true);
                $("#txt_RealName").prop("disabled", true);
                $("#txt_Mail").prop("disabled", true);
                $("#ddlIdentityType").val(parseInt('<%=idCard %>'));
                $("#txt_IdCard").val('<%=idCard %>');
                $("#txt_RealName").val('<%=realName %>');
                $("#txt_Mail").val('<%=mail %>');
                $("#ddlProvince").val(parseInt('<%=locationId %>'));
                provinceChange(1);
            }
            //确定提交
            $("#showTooltips").click(function () {
                var treg = /^\d{15}|\d{18}$/;
                if (!treg.test($.trim($("#txt_IdCard").val()))) {
                    $(".js_tooltips").html("身份证格式不正确！");
                    $(".js_tooltips").show();
                    setTimeout(function () {
                        $(".js_tooltips").hide();
                    }, 1000);
                    return;
                }
                if ($.trim($("#txt_RealName").val()) === "") {
                    //姓名为空提示
                    $(".js_tooltips").show();
                    setTimeout(function () {
                        $(".js_tooltips").hide();
                    }, 1000);
                    return;
                }
                var reg = /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/;
                if (!reg.test($.trim($("#txt_Mail").val()))) {
                    $(".js_tooltips").html("邮箱格式不正确！");
                    $(".js_tooltips").show();
                    setTimeout(function () {
                        $(".js_tooltips").hide();
                    }, 1000);
                    return;
                }
                if ($("#ddlCounty").val() === "0") {
                    $(".js_tooltips").html("请选择地址！");
                    $(".js_tooltips").show();
                    setTimeout(function () {
                        $(".js_tooltips").hide();
                    }, 1000);
                    return;
                }
                var userid = '<%=userId %>';
                $.post("data/data.aspx", { type: "PerfectInfor", idcode: $.trim($("#txt_IdCard").val()), identitytype: $.trim($("#ddlIdentityType").val()), realname: $.trim($("#txt_RealName").val()), mail: $.trim($("#txt_Mail").val()), userid: userid, locationid: $("#ddlCounty").val() }, function (result) {
                    if (parseInt(result) === 1) {
                        $("#toast").show();
                        setTimeout(function () { $("#toast").show(); window.location.href = "user/Person.aspx"; }, 1000);
                    }
                    else if (parseInt(result) === -1) {
                        $(".js_tooltips").html("保存失败！");
                        $(".js_tooltips").show();
                        setTimeout(function () { $(".js_tooltips").hide(); }, 1500);
                    }
                    else if (parseInt(result) === -2) {
                        $(".js_tooltips").html("没有注册信息，保存失败！");
                        $(".js_tooltips").show();
                        setTimeout(function () { $(".js_tooltips").hide(); }, 1500);
                    }
                })
            })
        })
        //级联方法 
        function getJsonObjLength(jsonObj) {
            var Length = 0;
            for (var item in jsonObj) {
                Length++;
            }
            return Length;
        }
        function addCityItem(text, value) {
            var tOption = document.createElement("Option");
            tOption.text = text;
            tOption.value = value;
            document.getElementById("ddlCity").add(tOption);
        }
        function addCountyItem(text, value) {
            var tOption = document.createElement("Option");
            tOption.text = text;
            tOption.value = value;
            document.getElementById("ddlCounty").add(tOption);
        }
        //省改变方法
        //参数num标识
        function provinceChange(num) {
            $.getJSON("data/location.ashx", { "locationid": $("#ddlProvince").val(), "type": "city" }, function (json) {
                $("#ddlCity option").remove();
                json = JSON.parse(json); 
                if (json[0].Message === "OK") {
                    for (var i = 1; len = getJsonObjLength(json), i < len; i++) {
                        addCityItem(json[i].text, json[i].value);
                    };
                    if (num > 0) {
                        $("#ddlCity").val(parseInt('<%=locationId2 %>'));
                    }
                    //市改变方法填充区
                    $.getJSON("data/location.ashx", { "locationid": $("#ddlCity").val(), "type": "county" }, function (json) {
                        $("#ddlCounty option").remove();
                        json = JSON.parse(json);
                        if (json[0].Message === "OK") {
                            for (var i = 1; len = getJsonObjLength(json), i < len; i++) {
                                addCountyItem(json[i].text, json[i].value);
                            };
                            if (num > 0) {
                                $("#ddlCounty").val(parseInt('<%=locationId3 %>')); 
                            }
                        }
                        else {
                            $("#ddlcounty option").remove();
                            addCountyItem("选择县/区", "0");
                        }
                    })
                }
                else {
                    alert(123);
                    $("#ddlCity option").remove();
                    addCityItem("选择市", "0");
                    $("#ddlCounty option").remove();
                    addCountyItem("选择县/区", "0");
                }
            })
        }
        //市改变方法填充区
        //参数num标识
        function cityChange() {
            $.getJSON("data/location.ashx", { "locationid": $("#ddlCity").val(), "type": "county" }, function (json) {
                $("#ddlCounty option").remove();
                json = JSON.parse(json);
                if (json[0].Message === "OK") {
                    for (var i = 1; len = getJsonObjLength(json), i < len; i++) {
                        addCountyItem(json[i].text, json[i].value);
                    }; 
                }
                else {
                    $("#ddlcounty option").remove();
                    addCountyItem("选择县/区", "0");
                }
            })
        }
    </script>
</body>
</html>
