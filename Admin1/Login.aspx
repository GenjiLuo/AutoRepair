<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head  runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>后台管理登录</title>

<link href="../css/login.css" rel="stylesheet" type="text/css">

</head>
<body class="login">
    <form id="form1" runat="server">
   <div class="login_m">
	<div class="login_logo"><img src="images/中交档案.png" style="margin-left: -100px;margin-top: 80px;"/></div>
	<div class="login_boder">
        <asp:Label ID="lbError" runat="server" Text=""></asp:Label>
		<div class="login_padding">
			<h2>用户名</h2>
			<label>
                <asp:TextBox ID="txtName" runat="server" class="txt_input txt_input2" onfocus="if (value ==&#39;Your name&#39;){value =&#39;&#39;}" onblur="if (value ==&#39;&#39;){value=&#39;Your name&#39;}"></asp:TextBox>
			</label>
			<h2>密码</h2>
			<label>
                <asp:TextBox ID="txtPwd" TextMode="Password" runat="server" class="txt_input" onfocus="if (value ==&#39;******&#39;){value =&#39;&#39;}" onblur="if (value ==&#39;&#39;){value=&#39;******&#39;}"></asp:TextBox>
			</label>
			<p class="forgot"><a href="javascript:void(0);">忘记密码?</a></p>
			<div class="rem_sub">
				<div class="rem_sub_l">
					<input type="checkbox" name="checkbox" id="save_me">
					<label for="checkbox">记住</label>
				</div>
				<label>
                    <asp:Button ID="btnSave" class="sub_button"  runat="server" Text="登录" style="opacity: 0.7;" OnClick="btnSave_Click" />
				</label>
			</div>
		</div>
	</div><!--login_boder end-->
</div><!--login_m end-->
    </form>
</body>
</html>
