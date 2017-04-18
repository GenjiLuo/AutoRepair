<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EvaluationDetails.aspx.cs" Inherits="car_EvaluationDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <title>评价详情</title>
    <link href="../css/CarList.css" rel="stylesheet" />
    <link href="../css/weui.min.css" rel="stylesheet" />
    <style type="text/css" accesskey="；">
        body, div, span { letter-spacing: 2px; padding: 0;  margin: 0;   font-size: 13px;  }
        .center_1 .section {   font-size: 15px;  text-align: center;   }
        .center_1 {   background-color: #ffffff;   }
        .con_title, .con_start{ width: 98%;  height: 30px; margin: 2px auto;line-height: 15px;  }
        .con_content, .con_content2 { width: 98%; margin: 2px auto;line-height: 15px;  }
        .center_1 .center_2 .con_start { border-bottom: 1px solid #ded7d7;  }
        .con_title .con_unitname { float: left; font-size: 16px;margin-top:5px;width:70%;overflow:hidden;text-overflow:ellipsis;white-space:nowrap;}
        .con_start .star {  float: left; }
        .con_start .con_fenshu {  float: right;   }
        .con_content .con_cenneirong , .con_content2 .con_cenneirong2 {  height: 60px;overflow: hidden;margin:10px auto; line-height: 16px;  }
        .con_title .con_gongdan {float: right; font-size: 12px;margin-top:5px;  }
        .con_content .con_time, .con_content2 .con_time2{ left:50%; color: #bdb5b5;font-size: 12px; }
    </style>
</head>
<body>
    <div class="center_1">
        <div class="center_2">
            <asp:Repeater runat="server" ID="rptEvaluation">
                <ItemTemplate>
                    <div class="con_title">
                        <div class="con_unitname">
                           <%#Eval("AutoUnit") %>
                        </div>
                        <div class="con_gongdan">工单 <%#Eval("RepairNumber") %></div>
                    </div>
                    <div class="con_start">
                        <%#Eval("zonghe").ToString()!=""?star(float.Parse(Eval("zonghe").ToString())):"<div class=\"star\" style=\" background-position:-0px -75px;\"></div>"%>
                        <div class="con_fenshu"><b><%#Eval("zonghe") %></b>&nbsp;<span style="color: #bdb5b5;font-size: 12px;" >分</span></div>
                    </div>
                    <div class="con_content"style="border-bottom:1px solid #ded7d7">
                        <div class="con_cenneirong"><%#Eval("AssessCount") %></div>
                        <div class="con_time"><%#Eval("AddTime") %></div>
                    </div>
                    <div class="con_content2" style="margin-top:15px;display:none;">
                        <div class="con_cenneirong2"><%#Eval("AssessCount2") %></div>
                        <div class="con_time2"><%#Eval("AddTime2") %></div>
                    </div>

                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

      <div class="weui_cells weui_cells_form"style="position:fixed;bottom:0;width:100%;">
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
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script type="text/javascript">
        $(function () {
            var str = "<%=Isbool%>";
            if (str != "") {
                $(".con_content2").css("display", "block");
            }
        });
    </script>
</body>
</html>
