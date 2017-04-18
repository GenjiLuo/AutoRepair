<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Appeal.aspx.cs" Inherits="user_Appeal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>我要申诉</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <link href="../css/weui.min.css" rel="stylesheet" />
    <link href="../css/person.css" rel="stylesheet" />
    <link href="../css/login.css" rel="stylesheet" />
    <link rel="icon" sizes="any"  href="../images/c.jpg" />
    <script src="../js/jquery-1.7.2.min.js"></script>
    <script src="../js/plupload.full.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="max-width:640px;width:100%;margin:0 auto;">
            <div class="weui_cells weui_cells_form">
                <div class="weui_cell_hd" style="padding:5px;">
                    <label class="" style="font-size:17px">申诉内容<span style="color:red;font-size:14px">(*填写你要申诉的内容)</span></label>
                    <textarea id="appealcount" class="weui_textarea"   placeholder="输入你要申诉的内容......"   rows="6"  style="padding: 5px 0;border:1px solid #d4d4d4" maxlength="200" ></textarea>
                    <div class="weui_textarea_counter"><span id="nubmerin">0</span>/200&nbsp;&nbsp;&nbsp;</div>
                    <label class="" style="font-size:17px">申诉图片<span style="color:red;font-size:14px">(*最多上传5张图片)</span></label>
                    <div>
                        <ul id="file-list">
		                    <li style="float:left;margin:0 5px" >
                                <img src="" onerror="this.src='../images/sc.jpg'" style="width:80px;height:80px;" id="browse1">
		                    </li>
                            <li style="float:left;margin:0 5px">
                                <img src="" id="browse2" onerror="this.src='../images/sc.jpg'" style="width:80px;height:80px; <%=imgUrl2==""?"display: none":"" %>">
		                    </li>
                            <li style="float:left;margin:0 5px">
                                <img src="" id="browse3" onerror="this.src='../images/sc.jpg'"  style="width:80px;height:80px;<%=imgUrl3==""?"display: none":"" %>">
		                    </li>
                            <li style="float:left;margin:0 5px">
                                <img src="" id="browse4" onerror="this.src='../images/sc.jpg'" style="width:80px;height:80px;<%=imgUrl4==""?"display: none":"" %>">
		                    </li>
                            <li style="float:left;margin:0 5px">
                                <img src="" id="browse5" onerror="this.src='../images/sc.jpg'" style="width:80px;height:80px;<%=imgUrl5==""?"display: none":"" %>">
		                    </li>
                        </ul> 
                    </div>
                </div>
            
            </div>
            <div class="weui_btn_area">
                <a class="weui_btn weui_btn_warn" id="showTooltips">确定</a>
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
        <div id="toast" style="display: none;">
            <div class="weui_mask_transparent"></div>
            <div class="weui_toast">
                <i class="weui_icon_toast"></i>
                <p class="weui_toast_content">申诉成功</p>
            </div>
        </div>
        <div class="weui_toptips weui_warn js_tooltips" style="display: none;"></div> 
        <!--//图片-->
    <input type="text" id="hid1" value="" style="display: none" />
    <input type="text" id="hid2" value="" style="display: none" />
    <input type="text" id="hid3" value="" style="display: none" />
    <input type="text" id="hid4" value="" style="display: none" />
    <input type="text" id="hid5" value="" style="display: none" />
    </form>
	<script>
	    

        //实例化图片并上传图片
        function uploadfile(number) {
            var uploader = new plupload.Uploader({//实例化一个plupload上传对象    
                browse_button: 'browse' + number,
                url: '/upload.ashx',
                flash_swf_url: '../plupload-2.1.9/Moxie.swf',
                silverlight_xap_url: '../plupload-2.1.9/Moxie.xap',
                filters: {
                    mime_types: [ //只允许上传图片文件
                      { title: "图片文件", extensions: "jpg,gif,png" }
                    ]
                }
            });
            uploader.init(); //初始化 
            //绑定文件添加进队列事件
            uploader.bind('FilesAdded', function (uploader, files) {
                previewImage(files[0], function (imgsrc) {
                    $.ajax({
                        url: "../data/updateloads.ashx",
                        type: "POST",
                        data: { base64: imgsrc },
                        success: function (result) {
                            if (result != "null") {
                                $("#browse" + number + "").attr("src", result);
                                $("#hid" + number + "").val(result);
                                if ($("#browse" + (parseInt(number) + 1) + "").is(":hidden")) {
                                    $("#browse" + (parseInt(number) + 1) + "").show();
                                    uploadfile(parseInt(number) + 1);
                                    $("#txtlinkUrl" + (parseInt(number) + 1) + "").show();
                                }
                            }
                            else {
                                $("#hid").val("");
                            }
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            alert("图片上传失败，请联系管理员！");
                        }
                    })
                })
            });
            //plupload中为我们提供了mOxie对象
            //有关mOxie的介绍和说明请看：https://github.com/moxiecode/moxie/wiki/API
            //如果你不想了解那么多的话，那就照抄本示例的代码来得到预览的图片吧
            function previewImage(file, callback) {//file为plupload事件监听函数参数中的file对象,callback为预览图片准备完成的回调函数
                if (!file || !/image\//.test(file.type)) return; //确保文件是图片
                if (file.type == 'image/gif') {//gif使用FileReader进行预览,因为mOxie.Image只支持jpg和png
                    var fr = new mOxie.FileReader();
                    fr.onload = function () {
                        callback(fr.result);
                        fr.destroy();
                        fr = null;
                    }
                    fr.readAsDataURL(file.getSource());
                } else {
                    var preloader = new mOxie.Image();
                    preloader.onload = function () {
                        preloader.downsize(80, 80);//先压缩一下要预览的图片,宽300，高300
                        var imgsrc = preloader.type == 'image/jpeg' ? preloader.getAsDataURL('image/jpeg', 80) : preloader.getAsDataURL(); //得到图片src,实质为一个base64编码的数据
                        callback && callback(imgsrc); //callback传入的参数为预览图片的url
                        preloader.destroy();
                        preloader = null;
                    };
                    preloader.load(file.getSource());
                }
            }
        }

        $(document).ready(function () {
	        uploadfile(1);
	        var i = 0;
	        var img2 = '<%=imgUrl2%>';
            if (img2 != "") {
                i++;
                uploadfile(2);
            }
            var img3 = '<%=imgUrl3 %>';
            if (img3 != "") {
                i++;
                uploadfile(3);
            }
            var img4 = '<%=imgUrl4 %>';
            if (img4 != "") {
                i++;
                uploadfile(4);
            }
            var img5 = '<%=imgUrl5 %>';
            if (img5 != "") {
                i++;
                uploadfile(5);
            }
            //保存事件
            $("#showTooltips").click(function () {
                var url = location.search; //获取url中"?"符后的字串
                //alert(url);
                if (url.indexOf("?") != -1) {    //判断是否有参数
                    var str = url.substr(1); //从第一个字符开始 因为第0个是?号 获取所有除问号的所有符串
                    strs = str.split("=");   //用等号进行分隔 （因为知道只有一个参数 所以直接用等号进分隔 如果有多个参数 要用&号分隔 再用等号进行分隔）
                    //alert(strs[1]);          //直接弹出第一个参数 （如果有多个参数 还要进行循环的）
                    user = strs[1];
                }
              
                var count = $("#appealcount").val();
                if (count == "") {
                    //alert("请填写申诉内容！");
                    $(".js_tooltips").html("请填写申诉内容！")
                    $(".js_tooltips").show();
                    setTimeout(function () { $(".js_tooltips").hide() }, 3000);
                    return;
                }
                //alert(count);
                var imgUrl1 = $("#hid1").val(), imgUrl2 = $("#hid2").val(), imgUrl3 = $("#hid3").val(), imgUrl4 = $("#hid4").val(), imgUrl5 = $("#hid5").val();
                if (imgUrl1 == "") {
                    //alert("请上传图片！");
                    $(".js_tooltips").html("请上传图片！")
                    $(".js_tooltips").show();
                    setTimeout(function () { $(".js_tooltips").hide() }, 3000);
                    return;
                }
                //alert(imgUrl1);
                var userid = user;
                //alert(userid);
                $.post("../data/data.aspx", {
                    type: "AddAppeal", userid: userid, imgUrl1: imgUrl1, imgUrl2: imgUrl2, imgUrl3: imgUrl3, imgUrl4: imgUrl4, imgUrl5: imgUrl5, count: count
                }, function (result) {
                    if (result == 1) {
                        //alert("申诉成功！");
                        $("#toast").show();
                        setTimeout(function () { window.location.href = "Person.aspx"; }, 1000);
                    }
                    else {
                        $(".js_tooltips").html("申诉失败！")
                        $(".js_tooltips").show();
                        //alert("申诉失败！");
                    }
                })
            })
        })
	   
	    //动态显示字数
	    window.onload = function () {
	       
	        document.getElementById('appealcount').onkeydown = function () {
	            document.getElementById("nubmerin").innerText = $(".weui_textarea").val().length;
	        }
	    }
    </script>
</body>
    
</html>
