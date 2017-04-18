<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Person.aspx.cs" Inherits="user_Person" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>个人中心</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <link href="../css/weui.min.css" rel="stylesheet" />
    <link href="../css/person.css" rel="stylesheet" />
     <link rel="icon" sizes="any"  href="../images/c.jpg" />
    <script src="../js/jquery-1.7.2.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">

        <div class="u_car">
            <%-- 1.个人信息内容 --%>
            <div class="u_car_tb" style="background-image:url('../images/1-1.jpg');background-size: 100% 100%;">
                <img src="<%=img %>" />
                <div class="u_car_tb_name"><%=name %></div>
            </div>
            <%-- <div class="u_beijing"></div>--%>
            <%-- 2.列表功能内容 --%>
            <div class="weui_cells weui_cells_access">

                <a href="/PerfectInfor.aspx" class="weui_cell" style="padding: 14px 15px;">
                    <div class="weui_cell_hd">
                        <img src="../images/1.png" alt="" style="width: 30px; margin-right: 5px; display: block; "></div>
                    <div class="weui_cell_bd weui_cell_primary">
                        <p style="color: #666">个人信息</p>
                    </div>
                    <div class="weui_cell_ft"></div>
                </a>
                <a href="../reservation/ReservationList.aspx" class="weui_cell" style="padding: 14px 15px;">
                    <div class="weui_cell_hd">
                        <img src="../images/2.png" alt="" style="width: 30px; margin-right: 5px; display: block;"></div>
                    <div class="weui_cell_bd weui_cell_primary">
                        <p style="color: #666">预约修车</p>
                    </div>
                    <div class="weui_cell_ft"></div>
                </a>
                <a href="../car/GarageList.aspx" class="weui_cell" style="padding: 14px 15px;">
                    <div class="weui_cell_hd">
                        <img src="../images/4.png" alt="" style="width: 30px; margin-right: 5px; display: block;"/></div>
                    <div class="weui_cell_bd weui_cell_primary">
                        <p style="color: #666">汽车健康档案查询</p>
                    </div>
                    <div class="weui_cell_ft"></div>
                </a>
                <a href="../car/EvaluationList.aspx" class="weui_cell" style="padding: 14px 15px;">
                    <div class="weui_cell_hd">
                        <img src="../images/chaxunjilu.png" alt="" style="width: 30px; margin-right: 5px; display: block;"/></div>
                    <div class="weui_cell_bd weui_cell_primary">
                        <p style="color: #666">维修记录查询评价</p>
                    </div>
                    <div class="weui_cell_ft"></div>
                </a>
                <a href="../car/ListCar.aspx" class="weui_cell" style="padding: 14px 15px;">
                    <div class="weui_cell_hd">
                        <img src="../images/3.png" alt="" style="width: 30px; margin-right: 5px; display: block; "/></div>
                    <div class="weui_cell_bd weui_cell_primary">
                        <p style="color: #666">我的车辆</p>
                    </div>
                    <div class="weui_cell_ft"></div>
                </a>
            <%--    <a href="../user/Appeal.aspx?userid=1" class="weui_cell" style="padding: 14px 15px;">
                    <div class="weui_cell_hd">
                        <img src="../images/c.jpg" alt="" style="width: 45px; margin-right: 5px; display: block; margin-top: 7px;"></div>
                    <div class="weui_cell_bd weui_cell_primary">
                        <p style="color: #666">申诉</p>
                    </div>
                    <div class="weui_cell_ft"></div>
                </a>--%>
            
               <%-- <a href="../car/mapposition.html" class="weui_cell" style="padding: 14px 15px;">
                    <div class="weui_cell_hd">
                        <img src="../images/c.jpg" alt="" style="width: 45px; margin-right: 5px; display: block; margin-top: 7px;"></div>
                    <div class="weui_cell_bd weui_cell_primary">
                        <p style="color: #666">附近维修点</p>
                    </div>
                    <div class="weui_cell_ft"></div>
                </a>--%>
            </div>
        </div>

    </form>
</body>
</html>
