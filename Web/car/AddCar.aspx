<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCar.aspx.cs" Inherits="car_AddCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>添加车辆信息</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <link rel="icon" sizes="any"  href="../images/c.jpg" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <link href="../css/weui.min.css" rel="stylesheet" />
    <link href="../css/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:0 auto;max-width:640px;">
            <div class="weui_cells weui_cells_form">
                <div>
                    <%-- <div class="l_weui_cell">
                        <div class="l_weui_cell_hd"><label class="l_weui_label"><img src="../images/57fdebf.png" style="width:33px;margin:-10px 0" /><span>车辆类型</span></label></div>
                        <div class="l_weui_cell_bd l_weui_cell_primary l_weui_cell_lift">
                            <label><input name="car" type="radio" value="1" checked ="checked"/>小型车 </label>
                            <label><input name="car" type="radio" value="2" />大型车 </label>
                        </div>
                    </div>--%>
                    <div class="weui_cell">
                        <div class="weui_cell_hd"><label class="weui_label_l"> 车牌号码</label></div>
                        <div class="weui_cell_bd weui_cell_primary weui_cell_lift">
                            <input id="txtcarnum" class="weui_input" type="text" placeholder="如：鲁A12345" onkeyup="UC()"/>
                        </div>
                    </div>
                    <div class="weui_cell">
                        <div class="weui_cell_hd"><label class="weui_label_l">识别代号</label></div>
                        <div class="weui_cell_bd weui_cell_primary weui_cell_lift">
                            <input id="txtCarFrame" class="weui_input" type="text" placeholder="车辆识别代号后六位" onkeyup="value=value.replace(/[^\w\.\/]/ig,'')"/>
                        </div>
                    </div>
                </div>
            </div>
            <div class="weui_btn_area">
                <a class="weui_btn weui_btn_warn" href="javascript:void(0);" onclick="addcl()">添加</a>
            </div>
             <div class="weui_cells weui_cells_form">
                <div style="margin:0 auto;max-width:640px;">
                    <div style="text-align:center;margin-top:20px;">
                        <a href="#" style="color:#2a5a9b;font-size: 15px;text-decoration: underline;">更多信息，请下载App查询</a>
                    </div>
                    <div style="overflow:hidden;margin: 20px 10px;">
                        <div style="float:left;padding:10px;background-color:#2b3e4f;border-radius:10px;color:#fff;width:40%;font-size:15px;text-align: center;">
                            <img src="../images/1-55.png" style="width:20px;"/>
                            <span> 分享到朋友圈</span>
                        </div>
                        <div style="float:right;padding:10px;background-color:#2b3e4f;border-radius:10px;color:#fff;width:40%;font-size:15px;text-align: center;">
                            <img src="../images/1-66.png"  style="width:20px;" />
                             <span> 关注公众账号</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <%-- weixin --%>
       <div id="toast" style="display: none;">
            <div class="weui_mask_transparent"></div>
            <div class="weui_toast">
                <i class="weui_icon_toast"></i>
                <p class="weui_toast_content">添加成功</p>
            </div>
        </div>

       <div id="shensu" class="weui_dialog_confirm"  style="display: none;">
            <div class="weui_mask"></div>
            <div class="weui_dialog">
                <div class="weui_dialog_hd"><strong class="weui_dialog_title">车牌已被绑定是否申诉？</strong></div>
               <%-- <div class="weui_dialog_bd">自定义弹窗内容，居左对齐显示，告知需要确认的信息等</div>--%>
                <div class="weui_dialog_ft">
                    <a onclick="jQuery('#shensu').hide()" class="weui_btn_dialog default">取消</a>
                    <a href="../user/Appeal.aspx?userid=<%=userid %>" class="weui_btn_dialog primary">申诉</a>
                </div>
            </div>
        </div>
        <div class="weui_toptips weui_warn js_tooltips" style="display: none;"></div> 
    </form>
    <script>
        function UC() {
            obj = document.getElementById("txtcarnum");
            obj.value = (obj.value.toUpperCase());
            obj.value = (obj.value.replace(/[^\w\u4E00-\u9FA5]/g, ''));
        }
       
        function addcl()
        {
            var typecar = 1;
            //var radios = document.getElementsByName("car");
            //for (var i = 0; i < radios.length; i++) {
            //    if (radios[i].checked == true) {
            //        typecar = radios[i].value;
            //       // alert("你最喜欢的语言是：" + radios[i].value);
            //    }
            //} 
            var re = /^[\u4e00-\u9fa5]{1}[A-Z]{1}[A-Z_0-9]{5}$/;
            var carnum = $.trim(document.getElementById("txtcarnum").value);//请输入车牌号
            //alert(carnum.substr(0, 1));
            if (carnum == ""||carnum.length!=7) {
                $(".js_tooltips").html("请输入车牌号！正确的车牌号")
                $(".js_tooltips").show();
                setTimeout(function () { $(".js_tooltips").hide() }, 5000);
                return;
            }
            //alert(carnum);
            var CarFrame = $.trim(document.getElementById("txtCarFrame").value);//请输入车辆识别代号
            if (CarFrame == "" || document.getElementById("txtCarFrame").value.length != 6) {
                $(".js_tooltips").html("请输入车辆识别代号！应为6位！")
                $(".js_tooltips").show();
                setTimeout(function () { $(".js_tooltips").hide() }, 5000);
                return;
            }
            var userid = "<%=userid%>";

            $.ajax({
                url: '../data/data.aspx',
                type: 'POST',
                data: {
                    type: 'addcar',
                    userid:userid,
                    typecar: typecar,
                    carnum: carnum,
                    CarFrame: CarFrame
                },
                success: function (result) {
                    //alert(result);
                    if (result == 1) {
                        $("#toast").show();
                        //setTimeout(function () { $("#toast").show(); window.location.href = "ListCar.aspx"; }, 1000);
                        setTimeout(function () {  window.location.href = "ListCar.aspx"; });
                    }
                    if (result == 2) {
                        $("#shensu").show();
                    }
                    if (result == -1) {
                        $(".js_tooltips").html("添加失败！")
                        $(".js_tooltips").show();
                        setTimeout(function () { $(".js_tooltips").hide() }, 1000);
                        //alert("添加失败！");
                        location.reload();
                    }
                }
            })
        }
    </script>
</body>
</html>
