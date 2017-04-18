<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CarinDetail.aspx.cs" Inherits="car_CarinDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>车辆信息</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <link rel="icon" sizes="any"  href="../images/c.jpg" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <link href="../css/weui.min.css" rel="stylesheet" />
    <link href="../css/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    
            <div class="d_carw">
                <div class="weui_cells weui_cells_form">
                    <%if (n>0) {  %>
                    <ul>
                       <li><div style="text-align:center">车辆信息</div></li>
                   </ul>
                     <div class="d_car_l1">
                           <div class="d_car_l1_1" >车主姓名</div>
                           <div class="d_car_l1_2" ><%=LinkMan %></div>
                    </div>
                    <div class="d_car_l1">
                           <div class="d_car_l1_1" >联系电话</div>
                           <div class="d_car_l1_2" ><%= Phone%></div>
                    </div>
                    <div class="d_car_l1">
                           <div class="d_car_l1_1" >车主单位</div>
                           <div class="d_car_l1_2" ><%=UnitName %></div>
                    </div>
                    <div class="d_car_l1">
                           <div class="d_car_l1_1" >车牌号码</div>
                           <div class="d_car_l1_2 " ><%=PlateNumber %></div>
                    </div>
                    <div class="d_car_l1">
                           <div class="d_car_l1_1" >车牌颜色</div>
                           <div class="d_car_l1_2" ><%= PlateColor%></div>
                    </div>
                    <div class="d_car_l1">
                           <div class="d_car_l1_1" >车架号VIN码</div>
                           <div class="d_car_l1_2" ><%=VIN %></div>
                    </div>
                    <div class="d_car_l1">
                           <div class="d_car_l1_1" >厂牌型号</div>
                           <div class="d_car_l1_2" ><%=AutoBrand %></div>
                    </div>
                    <div class="d_car_l1">
                           <div class="d_car_l1_1" >车辆类型</div>
                           <div class="d_car_l1_2" ><%=AutoType %></div>
                    </div>
                    <div class="d_car_l1">
                           <div class="d_car_l1_1" >发动机号</div>
                           <div class="d_car_l1_2" ><%=EngineNumber %></div>
                    </div>
                    <div class="d_car_l1">
                           <div class="d_car_l1_1" >车身颜色</div>
                           <div class="d_car_l1_2" ><%= AutoColor%></div>
                    </div>
                    <div class="d_car_l1">
                           <div class="d_car_l1_1" >底盘号码</div>
                           <div class="d_car_l1_2" ><%=ChassisNumber %></div>
                    </div>
                    <div class="d_car_l1">
                           <div class="d_car_l1_1" >会员卡</div>
                           <div class="d_car_l1_2" ><%=CardNumber %></div>
                    </div>
                    <div class="d_car_l1">
                           <div class="d_car_l1_1" >维修企业代码</div>
                           <div class="d_car_l1_2" ><%=UnitID %></div>
                    </div>
                    <div class="d_car_l1">
                           <div class="d_car_l1_1" >提交时间</div>
                           <div class="d_car_l1_2" ><%= UploadTime%></div>
                    </div>
                    <%}else{ %>
                    <div style="text-align: center;color: #d4d4d4;padding: 20px;">暂无车辆信息.....</div>
                    <%} %>
                   
                 </div>
            </div>
    </form>

</body>
</html>
