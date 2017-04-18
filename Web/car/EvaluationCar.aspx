<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EvaluationCar.aspx.cs" Inherits="car_EvaluationCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <meta name="apple-mobile-web-app-capable" content="yes" />
    <title>评价</title>
    <link href="../css/bootstrap-cerulean.min.css" rel="stylesheet" />
    <link href="../css/weui.min.css" rel="stylesheet" />
    <link rel="icon" sizes="any" href="../images/c.jpg" />
    <link href="../statics/grade.css" rel="stylesheet" />
    <script src="../statics/jquery-latest.pack.js"></script>
    <script src="../statics/grade.js"></script>
    <style type="text/css">
        body { margin: 0;padding: 0;  letter-spacing: 2px; background-color: #f3f3f3;  }
        .pf .glyphicon { color: orange;user-select: none;padding: 0px 10px;}
        .pf li {padding: 10px 0px; font-size: 16px; }
        .pblockm ul li {padding-left: 20px;}
        .weui_cell {margin-top: 50px; }
        .afterview { width: 98%;height:130px;  margin: 10px auto;background-color:white;}
        .afterview .after_content {  display:block;word-break:break-all;float:left; padding: 13px;height: 100px;width: 98%;overflow: hidden;}
        .afterview .after_time {   display: block; float: right; font: 300 10px arial,verdana; padding: 13px;}
        #foot {  font-family: 微软雅黑; text-decoration: none;display:block;margin-top:15px;}
        .weui_cell_line { border-top: 1px solid #ebe9e9;border-bottom: 1px solid #ebe9e9; margin-top: 40px; }
        #foot:link, #foot:visited, #foot:hover { color: white;  }
        #box tbody tr th{font-weight:600; } 
    </style>
</head>
<body>
    <section>
        <asp:Repeater runat="server" ID="rptEvaluate">
            <ItemTemplate>
                <div class="afterview">
                    <span class="after_content"><%#Eval("AssessCount") %></span>
                    <span class="after_time"><%#Eval("Type").ToString()=="1"?Eval("AddTime"):Eval("AddTime2") %></span>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </section>
    <div class="weui_cell_bd weui_cell_primary weui_cell_line">
        <div style="width: 98px; height: 30px; margin-top: 3px; font-weight: bold; font-family: 微软雅黑; display: none;" id="append_com">&nbsp;&nbsp;追加评价</div>
        <textarea class="weui_textarea" id="comment" style="padding: 12px;" onkeyup=' if(value.length>200){ layer.msg("字数不能超过200字吆"); value=value.substr(0,200);}' placeholder="写下使用感受来帮助其他小伙伴……" rows="6"></textarea>
        <div class="weui_textarea_counter"><span id="nubmerin">0</span>/200&nbsp;&nbsp;&nbsp;</div>
    </div>
       <div id="box">
        <div class="content">
            <div id="doPoint">
                <table>
                    <tbody>
                        <tr>
                            <th>服务态度</th>
                            <td><span class="star9" id="item1"><small>1</small><small>2</small><small>3</small><small>4</small><small>5</small><small>6</small><small>7</small><small>8</small><small>9</small><small>10</small></span></td>
                            <td><strong id="Attitude">9</strong><em>(很不错)</em></td>
                        </tr>
                        <tr>
                            <th>维修价格</th>
                            <td><span class="star9" id="item2"><small>1</small><small>2</small><small>3</small><small>4</small><small>5</small><small>6</small><small>7</small><small>8</small><small>9</small><small>10</small></span></td>
                            <td><strong id="Speed">9</strong><em>(物超所值)</em></td>
                        </tr>
                        <tr>
                            <th>维修质量</th>
                            <td><span class="star9" id="item3"><small>1</small><small>2</small><small>3</small><small>4</small><small>5</small><small>6</small><small>7</small><small>8</small><small>9</small><small>10</small></span></td>
                            <td><strong id="Quality">9</strong><em>(超赞)</em></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class="weui_btn_area">
        <a href="javascript:void(0);" id="foot" class="weui_btn weui_btn_warn">提交评价</a>
    </div>
    <script src="../js/jquery-1.7.2.min.js"></script>
     <script src="../layer/layer.js"></script>
    <script type="text/javascript">

        //判断文本框是否为空
        $("#foot").on('click', function () {
            var type = "<%=type%>";

            //Type=0：评价   
            if (type == 0) {
                var Attitude = $("#Attitude").text();//获取服务态度星级评分
                var Speed = $("#Speed").text();//获取维修价格星级评分
                var Quality = $("#Quality").text();//获取维修质量星级评分

                var content = $(".weui_textarea").val();//获取评价内容
                if (content.trim() == "") {
                    layer.msg('请填写1-200个字吆');
                    return;
                } else {
                    $.ajax({
                        url: '../data/data.aspx',
                        type: 'POST',
                        data: { type: 'addevaluation', RecordsId: "<%=id%>", Unitid: "<%=unitid%>", content: content, attitude: Attitude, speed: Speed, quality: Quality },
                        success: function (result) {
                            if (result == 1) {
                                layer.msg('感谢您的评价');
                                location.href = "GarageList.aspx";
                            } else {
                                layer.msg('请稍后再试');

                            }
                        }
                    })
                }
            }
            //Type=1：追评
            if (type == 1) {
                var content = $(".weui_textarea").val();//获取评价内容
                if (content.trim() == "" || content.length > 200) {
                    layer.msg('请填写1-200个字吆');
                    return;
                } else {
                    $.ajax({
                        url: '../data/data.aspx',
                        type: 'POST',
                        data: { type: 'AppendEvaluation', AssessId: "<%=AssessId%>", content: content },
                        success: function (result) {
                            if (parseInt(result) == 1) {
                                layer.msg('追加评价成功');
                                location.href = "GarageList.aspx";
                            } else {
                                layer.msg('请稍后再试');
                            }
                        }
                    })
                }
            }
        });
        //动态显示字数
        window.onload = function () {
            document.getElementById('comment').onkeydown = function () {
                document.getElementById("nubmerin").innerText = $(".weui_textarea").val().length;
            }
        }
        //对评价状态做判断
        $(document).ready(function () {
            var type = "<%=type%>";
            if (type == 1) {
                $("#box").css("display", "none");
                $("#append_com").css("display", "block");
            }
        })
    </script>
</body>
</html>
