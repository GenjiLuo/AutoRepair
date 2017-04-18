<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="car_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
    <title>星级评分测试</title>
    <script src="../js/jquery-1.7.2.min.js"></script>
    <link href="../statics/grade.css" rel="stylesheet" />
    <script src="../statics/jquery-latest.pack.js"></script>
    <script src="../statics/grade.js"></script>

</head>
<body>
    <div id="box">
        <div class="content">
            <div id="doPoint">
                <table>
                    <tbody>
                        <tr>
                            <th>服务态度</th>
                            <td><span class="star9" id="item1"><small>1</small><small>2</small><small>3</small><small>4</small><small>5</small><small>6</small><small>7</small><small>8</small><small>9</small><small>10</small></span></td>
                            <td><strong>9</strong></td>
                        </tr>
                        <tr>
                            <th>维修价格</th>
                            <td><span class="star9" id="item2"><small>1</small><small>2</small><small>3</small><small>4</small><small>5</small><small>6</small><small>7</small><small>8</small><small>9</small><small>10</small></span></td>
                            <td><strong>9</strong> </td>
                        </tr>
                        <tr>
                            <th>维修质量</th>
                            <td><span class="star9" id="item3"><small>1</small><small>2</small><small>3</small><small>4</small><small>5</small><small>6</small><small>7</small><small>8</small><small>9</small><small>10</small></span></td>
                            <td><strong>9</strong></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</body>
</html>
