<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>个人登录</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <link href="css/weui.min.css" rel="stylesheet" />
    <link href="css/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:0 auto;max-width:640px;width:100%">
            <div>
                <div class="l_weui_cell">
                    <div class="l_weui_cell_hd"><label class="l_weui_label"><img src="images/57fdebf.png" style="width:33px;" /></label></div>
                    <div class="l_weui_cell_bd weui_cell_primary">
                        <asp:TextBox ID="txtphone" class="l_weui_input"  runat="server" placeholder="请输入手机号" onkeypress="if (event.keyCode < 48 || event.keyCode >57) event.returnValue = false;"></asp:TextBox>
                    
                    </div>
                </div>
               <div class="l_weui_cell">
                    <div class="l_weui_cell_hd"><label class="l_weui_label"><img src="images/673354d.png" style="width:33px;" /></label></div>
                    <div class="l_weui_cell_bd weui_cell_primary">
                        <asp:TextBox ID="txtpwd" class="l_weui_input"  runat="server" placeholder="请输入密码"　TextMode="Password"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div style="padding: 10px;">
                    <%--<a href="#" class="weui_btn weui_btn_warn" onclick="">确认</a>--%>
                <asp:Button runat="server" class="weui_btn weui_btn_warn" Text="确认" OnClick="Unnamed_Click"/>

                <div style="margin:20px 0;">
                    <div style="float:left">新用户？<span style="color:#e73322;font-weight:600">立即注册</span></div>
                    <div style="float:right">密码找回</div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
