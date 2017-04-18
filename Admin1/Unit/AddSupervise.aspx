<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddSupervise.aspx.cs" Inherits="Unit_AddSupervise" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>企业列表</title>
    <link href="../css/Unitstyle.css" rel="stylesheet" />
    <link href="../css/Style2.css" rel="stylesheet" />
    <link href="../css/Organization.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <div>
        <div class="cb_box" style="margin-right: 182px; margin-left: 15px;">
            <div class="cbs_box fo" style="padding-left: 0px;">
              
                <div class="cbs_box fo">
                    <div class="xtb_class" style="width: 100%; padding-left: 48px;">
                        <b class="xtb_name">许可证号：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtxukezheng" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 48px;">
                        <b class="xtb_name">企业名称：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtqiye" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 35px;">
                        <b class="xtb_name">法定负责人：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtfuzeren" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 77px;">
                        <b class="xtb_name">电话：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtdianhua" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 49px;">
                        <b class="xtb_name">所在区域：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtquyu" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 77px;">
                        <b class="xtb_name">地址：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtdizhi" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 77px;">
                        <b class="xtb_name">税号：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtshuihao" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 49px;">
                        <b class="xtb_name">工商执照：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtzhizhao" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 49px;">
                        <b class="xtb_name">授权密钥：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtmiyao" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 20px;">
                        <b class="xtb_name">质量信誉等级：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtdengji" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 49px;">
                        <b class="xtb_name">经营类别：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtleibie" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 49px;">
                        <b class="xtb_name">经营范围：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtfanwei" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 77px;">
                        <b class="xtb_name">备注：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtbeizhu" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 77px;">
                        <b class="xtb_name">经度：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtjingdu" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                    <div class="xtb_class" style="width: 100%; padding-left: 77px;">
                        <b class="xtb_name">纬度：</b>
                        <span class="xtb_text_box width563" style="width:400px">
                            <input id="txtweidu" class="xtb_text" style="width: 390px;padding-left:2%" type="text" />
                        </span>
                    </div>
                </div>
                <div style="width: 100%; float: right; padding: 0 5px; margin: 5px;">
                    <div class="xtb_class" style="padding-left: 150px; margin-top: 15px">
                        <span class="xtb_button_box">
                            <%--<asp:Button ID="btn_seave" class="xtb_button bg_blue" runat="server" Text="保存" OnClientClick="check()" />--%>
                            <a href="javascript:function()" class="xtb_button bg_blue" style="min-width: 4em; height: 38px; padding: 10px 15px; font-size: 17px; text-align: center; color: #fff; font-family: Arial;" id="seave">保存</a>
                            <%--<input class="xtb_button bg_blue" id="baocun" value="保存" onclick="check()" />--%>
                        </span>
                    </div>
                    <div class="xtb_class">
                        <span class="xtb_button_box">
                            <input class="xtb_button bg_blue" value="重置" type="reset" />
                        </span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        var unitId = '<%=unitID %>';
        $("#seave").click(function () {
            var xukezhenghao = $.trim($("#txtxukezheng").val());
            if (xukezhenghao == "") {
                alert("请填写许可证号！");
                return;
            }
            var qiyename = $.trim($("#txtqiye").val());
            if (qiyename == "") {
                alert("请填写企业名称！");
                return;
            }
            var fuzeren = $.trim($("#txtfuzeren").val());
            if (fuzeren == "") {
                alert("请填写法定负责人！");
                return;
            }
            var dianhua = $.trim($("#txtdianhua").val());
            if (dianhua == "") {
                alert("请填写电话！");
                return;
            }
            var quyu = $.trim($("#txtquyu").val());
            if (quyu == "") {
                alert("请填写所在区域！");
                return;
            }
            var dizhi = $.trim($("#txtdizhi").val());
            if (dizhi == "") {
                alert("请填写地址！");
                return;
            }
            var shuihao = $.trim($("#txtshuihao").val());
            if (shuihao == "") {
                alert("请填写税号！");
                return;
            }
            var zhizhao = $.trim($("#txtzhizhao").val());
            if (zhizhao == "") {
                alert("请填写工商执照！");
                return;
            }
            var miyao = $.trim($("#txtmiyao").val());
            if (miyao == "") {
                alert("请填写授权密钥！");
                return;
            }
            var xinyu = $.trim($("#txtdengji").val());
            if (xinyu == "") {
                alert("请填写质量信誉等级！");
                return;
            }
            var leibie = $.trim($("#txtleibie").val());
            if (leibie == "") {
                alert("请填写经营类别！");
                return;
            }
            var fanwei = $.trim($("#txtfanwei").val());
            if (fanwei == "") {
                alert("请填写经营范围！");
                return;
            }
            var beizhu = $.trim($("#txtbeizhu").val());
            if (beizhu == "") {
                alert("请填写备注！");
                return;
            }
            var jingdu = $.trim($("#txtjingdu").val());
            var weidu = $.trim($("#txtweidu").val());
            if (unitId > 0) {
                $.ajax({
                    url: "../data/data.aspx",
                    type: "POST",
                    data: {
                        type: "UpdSpuervise",
                        xukezhenghao: xukezhenghao,
                        qiyename: qiyename,
                        fuzeren: fuzeren,
                        dianhua: dianhua,
                        quyu: quyu,
                        dizhi: dizhi,
                        shuihao: shuihao,
                        zhizhao: zhizhao,
                        miyao: miyao,
                        xinyu: xinyu,
                        leibie: leibie,
                        fanwei: fanwei,
                        beizhu: beizhu,
                        jingdu: jingdu,
                        weidu: weidu,
                    },
                    success: function (result) {
                        if (result > 0) {
                            alert("修改成功！");
                            window.location.href = "/Unit/Supervise.aspx";
                        }
                        else {
                            alert("修改失败！");
                        }
                    }
                })
            }
            else {
                $.ajax({

                    url: "../data/data.aspx",
                    type: "POST",
                    data: {
                        type: "addSpuervise",
                        xukezhenghao: xukezhenghao,
                        qiyename: qiyename,
                        fuzeren: fuzeren,
                        dianhua: dianhua,
                        quyu: quyu,
                        dizhi: dizhi,
                        shuihao: shuihao,
                        zhizhao: zhizhao,
                        miyao: miyao,
                        xinyu: xinyu,
                        leibie: leibie,
                        fanwei: fanwei,
                        beizhu: beizhu,
                        jingdu: jingdu,
                        weidu: weidu,
                    },
                    success: function (result) {
                        if (result > 0) {
                            alert("添加成功！");
                            window.location.href = "/Unit/Supervise.aspx";
                        }
                        else {
                            alert("添加失败！");
                        }
                    }
                })
            }
        })
        $(function () {

            if (parseInt(unitId) > 0) {
                var json = '<%=json %>';
                json = JSON.parse(json);
                $("#txtxukezheng").val(json.xukezhenghao);
                $("#txtqiye").val(json.qiyename);
                $("#txtfuzeren").val(json.fuzeren);
                $("#txtdianhua").val(json.dianhua);
                $("#txtquyu").val(json.quyu);
                $("#txtdizhi").val(json.dizhi);
                $("#txtshuihao").val(json.shuihao);
                $("#txtzhizhao").val(json.zhizhao);
                $("#txtmiyao").val(json.miyao);
                $("#txtdengji").val(json.xinyu);
                $("#txtleibie").val(json.leibie);
                $("#txtfanwei").val(json.fanwei);
                $("#txtbeizhu").val(json.beizhu);
            }
        })
    </script>
</asp:Content>

