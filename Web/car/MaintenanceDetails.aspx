<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MaintenanceDetails.aspx.cs" Inherits="car_MaintenanceDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <title>维修详情</title>
    <link rel="icon" sizes="any" href="../images/c.jpg" />
    <link href="../css/MaintenanceDetails.css" rel="stylesheet" />
    <link href="../css/weui.min.css" rel="stylesheet" />
    <style type="text/css">
        .weui_neiqian{width:70%;overflow: hidden;text-overflow:ellipsis;white-space: nowrap;}
    </style>
</head>
<body>
    <div class="weui_cells_title">企业信息</div>
    <div class="weui_cells">
        <div class="weui_cell">
            <div class="weui_cell_bd weui_cell_primary">
                <p>企业名称</p>
            </div>
            <div class="weui_cell_ft weui_neiqian"><%=UnitName %></div>
        </div>
        <div class="weui_cell">
            <div class="weui_cell_bd weui_cell_primary">
                <p>地址</p>
            </div>
            <div class="weui_cell_ft weui_neiqian"><%=UnitAddress %></div>
        </div>   
        <div class="weui_cell">
            <div class="weui_cell_bd weui_cell_primary">
                <p>联系方式</p>
            </div>
            <div class="weui_cell_ft"><%=UnitPhone %></div>
        </div>   
    </div>
    
    <div class="weui_cells_title">车辆信息</div>
    <div class="weui_cells">
        <div class="weui_cell">
            <div class="weui_cell_bd weui_cell_primary">
                <p>车牌号</p>
            </div>
            <div class="weui_cell_ft"><%=PlateNumber %></div>
        </div>
        <div class="weui_cell">
            <div class="weui_cell_bd weui_cell_primary">
                <p>车身颜色</p>
            </div>
            <div class="weui_cell_ft"><%=CarColor %></div>
        </div>
        <div class="weui_cell">
            <div class="weui_cell_bd weui_cell_primary">
                <p>车辆类型</p>
            </div>
            <div class="weui_cell_ft"><%=AutoType %></div>
        </div>
    </div>
    
    <div class="weui_cells_title">其它信息</div>
    <div class="weui_cells">
        <div class="weui_cell">
            <div class="weui_cell_bd weui_cell_primary">
                <p>维修工单</p>
            </div>
            <div class="weui_cell_ft"><%=RepairNumber %></div>
        </div>
         <div class="weui_cell">
            <div class="weui_cell_bd weui_cell_primary">
                <p>进厂日期</p>
            </div>
            <div class="weui_cell_ft"><%=SignDate %></div>
        </div>
        <div class="weui_cell">
            <div class="weui_cell_bd weui_cell_primary">
                <p>修浚日期</p>
            </div>
            <div class="weui_cell_ft"><%=FinishDate %></div>
        </div>
          <div class="weui_cell">
            <div class="weui_cell_bd weui_cell_primary">
                <p>费用合计</p>
            </div>
            <div class="weui_cell_ft"><%=TotalMoney %>￥</div>
        </div>
    </div>
<%--    <div class="weui_cells weui_cells_form"style="position:fixed;bottom:0;width:100%;">
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
    </div>--%>
</body>
</html>
