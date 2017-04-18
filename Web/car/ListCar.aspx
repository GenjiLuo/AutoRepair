<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListCar.aspx.cs" Inherits="car_ListCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>车辆列表</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <link rel="icon" sizes="any"  href="../images/c.jpg" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <link href="../css/person.css?v=24" rel="stylesheet" />
    <link href="../css/weui.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="max-width:640px;width:100%;margin:0 auto;">
            <%if(num>0){ %>
            <asp:Repeater runat="server" ID="rptlistcar">
                    <ItemTemplate>
          <div class="weui_cells_l weui_cells_form">
            <div class=" weui_cells_access z_carlist1">
                
                        <a class="weui_cell" href="CarinDetail.aspx?platenumber=<%#Eval("CarNum") %>">
                            <div class="weui_cell_bd weui_cell_primary">
                                <p class="p1"> <%#Eval("CarNum") %></p>
                            </div>
                            <div class="weui_cell_ft">说明文字
                            </div>
                        </a>
                        <div class="weui_cell">
                            <div class="weui_cell_bd weui_cell_primary">
                                <p class="p3">车辆识别代号</p>
                            </div>
                            <div class="p2" >
                                <%#Eval("CarFrameNum") %>
                            </div>
                        </div>
                        <div class="weui_cell">
                            <div class="weui_cell_bd weui_cell_primary">
                                <p class="p3">添加时间</p>
                            </div>
                            <div class="p2" >
                                <%#Eval("AddTime") %>
                            </div>
                        </div>
                  
            </div> 
          </div>
                </ItemTemplate>
                </asp:Repeater>
            <%}else{ %>
          <div class="weui_btn_area" style="text-align:center;color:#666;">
          暂没绑定车辆，快去绑定吧......
          </div>
            <%} %>
          <div class="weui_btn_area">
            <a class="weui_btn weui_btn_warn" href="../car/addcar.aspx">添加车辆</a>
         </div>
        </div>
    </form>
</body>
</html>
