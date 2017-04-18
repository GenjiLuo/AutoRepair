<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RepairDetails.aspx.cs" Inherits="Repair_RepairDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="Server">
    <title>汽车健康档案详情</title>
    <link href="../css/repairlist.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="Server">
    <%--    <div style="width: 100%; height: 100%; overflow: scroll;">--%>
    <div class="rt_whiteBox" style="height: 784px;">

        <div class="page_title" style="margin: auto 16px;">
            <h2><strong style="font-size: 20px;">汽车健康档案详情</strong></h2>
        </div>
        <br />
        <br />
        <br />

        <%--客户档案 --%>
        <span style="font-weight: 700; font-size: 18px; margin: auto 20px;">客户档案</span>
        <table width="68%" border="1" style="color: #000; margin: 12px 18px;">
            <tr style="height: 30px;">
                <td rowspan="4">托修方</td>
                <td>单位名称（车主姓名）</td>
                <td colspan="3"><%=UnitName %></td>
                <td>送修人</td>
                <td><%=RepairMan %></td>
            </tr>
            <tr style="height: 30px;">
                <td>车牌号码</td>
                <td><%=PlateNumber %></td>
                <td>厂牌型号</td>
                <td><%=AutoBrand %></td>
                <td>维修类别</td>
                <td><%=RepairSort %></td>
            </tr>
            <tr style="height: 30px;">
                <td>进厂日期</td>
                <td><%=SignDate %></td>
                <td>合同编号</td>
                <td><%=ContractNumber %></td>
                <td>工单号码</td>
                <td><%=RepairNumber %></td>
            </tr>
            <tr style="height: 30px;">
                <td>出厂里程表读数</td>
                <td><%=Mileage %></td>
                <td>合格证号</td>
                <td><%=HGZH %></td>
                <td>联系电话</td>
                <td></td>
            </tr>
            <tr style="height: 30px;">
                <td colspan="2">承修方单位名称</td>
                <td colspan="3"><%=UnitName %></td>
                <td>联系电话</td>
                <td><%=Phone %></td>
            </tr>
        </table>
        <br />
        <br />

        <%-- 维修费用结算总表 --%>
        <span style="font-weight: 700; font-size: 18px; margin: auto 20px;">维修费用结算总表</span>
        <table width="68%" border="1" style="color: #000; margin: 12px 18px;">
            <tr style="height: 30px;">
                <td>序号</td>
                <td>名    称</td>
                <td>金     额（元）</td>
                <td>维修人</td>
            </tr>
            <tr style="height: 30px;">
                <td>1</td>
                <td>维修诊断费</td>
                <td><%=ZDF %></td>
                <td><%=UnitName %></td>
            </tr>
            <tr style="height: 30px;">
                <td>2</td>
                <td>检测费</td>
                <td><%=JCF %></td>
                <td><%=UnitName %></td>
            </tr>
            <tr style="height: 30px;">
                <td>3</td>
                <td>材料费</td>
                <td><%=CLF %></td>
                <td><%=UnitName %></td>
            </tr>
            <tr style="height: 30px;">
                <td>4</td>
                <td>工时费</td>
                <td><%=GSF %></td>
                <td><%=UnitName %></td>
            </tr>
            <tr style="height: 30px;">
                <td>5</td>
                <td>加工费</td>
                <td><%=JGF %></td>
                <td><%=UnitName %></td>
            </tr>
            <tr style="height: 30px;">
                <td>6</td>
                <td>其他费用</td>
                <td><%=QTF %></td>
                <td><%=UnitName %></td>
            </tr>
            <tr style="height: 30px;">
                <td>7</td>
                <td>合计金额</td>
                <td><%=TotalMoney %></td>
                <td><%=UnitName %></td>
            </tr>
            <tr style="height: 30px;">
                <td colspan="4">实收金额（元）：<%=TotalMoney %>元</td>
            </tr>
        </table>
        <br />
        <br />

        <%--表一 维修诊断费  --%>
        <span style="font-weight: 700; font-size: 18px; margin: auto 20px;">表一 维修诊断费</span>
        <table width="68%" border="1" style="color: #000; margin: 12px 18px;">
            <tr style="height: 30px;">
                <td>序号</td>
                <td>维修诊断项目</td>
                <td>金     额（元）</td>
                <td>备注</td>
            </tr>
            <asp:Repeater ID="rptweixiu" runat="server">
                <ItemTemplate>
                    <tr style="height: 30px;">
                        <td><%#Container.ItemIndex+1 %></td>
                        <td><%#Eval("ItemName") %></td>
                        <td><%#Eval("Money") %></td>
                        <td><%#Eval("Remark")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <tr style="height: 30px;">
                <td colspan="4">维修诊断费合计金额（元）：<%=wxzdnum%></td>
            </tr>
        </table>
        <br />
        <br />

        <%-- 表二 检测费 --%>
        <span style="font-weight: 700; font-size: 18px; margin: auto 20px;">表二 检测费</span>
        <table width="68%" border="1" style="color: #000; margin: 12px 18px;">
            <tr style="height: 30px;">
                <td>序号</td>
                <td>检测项目</td>
                <td>金     额（元）</td>
                <td>备注</td>
            </tr>
            <asp:Repeater ID="rptjiance" runat="server">
                <ItemTemplate>
                    <tr style="height: 30px;">
                        <td><%#Container.ItemIndex+1 %></td>
                        <td><%#Eval("ItemName") %></td>
                        <td><%#Eval("Money") %></td>
                        <td><%#Eval("Remark") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <tr style="height: 30px;">
                <td colspan="4">检测费合计金额（元）：<%=JCnum%></td>
            </tr>
        </table>
        <br />
        <br />

        <%--表三 材料费  --%>
        <span style="font-weight: 700; font-size: 18px; margin: auto 20px;">表三 材料费</span>
        <table width="68%" border="1" style="color: #000; margin: 12px 18px;">
            <tr style="height: 30px;">
                <td>序号</td>
                <td>材料名称</td>
                <td>厂牌规格</td>
                <td>单位</td>
                <td>数量</td>
                <td>单价（元）</td>
                <td>金额（元）</td>
                <td>备注</td>
            </tr>
            <asp:Repeater ID="rptcailiao" runat="server">
                <ItemTemplate>
                    <tr style="height: 30px;">
                        <td><%#Container.ItemIndex+1 %></td>
                        <td><%#Eval("ItemName") %></td>
                        <td><%#Eval("AutoBrand") %></td>
                        <td><%#Eval("ItemUnit") %></td>
                        <td><%#Eval("Amount") %></td>
                        <td><%#Eval("Price") %></td>
                        <td><%#Eval("Money") %></td>
                        <td><%#Eval("Remark") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <tr style="height: 30px;">
                <td colspan="2">托修方自备配件</td>
                <td colspan="6"></td>
            </tr>
            <tr style="height: 30px;">
                <td colspan="8">材料费合计金额（元）：<%=CLnum%></td>
            </tr>
        </table>
        <br />
        <br />

        <%-- 表四 工时费 --%>
        <span style="font-weight: 700; font-size: 18px; margin: auto 20px;">表四 工时费</span>
        <%--  <span style=" font-weight:700;font-size:18px;margin: auto 674px;">  工时单价：10.00 元/工时</span>--%>
        <table width="68%" border="1" style="color: #000; margin: 12px 18px;">
            <tr style="height: 30px;">
                <td>序号</td>
                <td>维修项目</td>
                <td>结算工时</td>
                <td>单价</td>
                <td>金额（元）</td>
                <td>备注</td>
            </tr>
            <asp:Repeater ID="rptgongshi" runat="server">
                <ItemTemplate>
                    <tr style="height: 30px;">
                        <td><%#Container.ItemIndex+1 %></td>
                        <td><%#Eval("ItemName") %></td>
                        <td><%#Eval("WorkTime") %></td>
                        <td><%#Eval("Price") %></td>
                        <td><%#Eval("Money") %></td>
                        <td><%#Eval("Remark") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <tr style="height: 30px;">
                <td colspan="6">工时费合计金额（元）：<%=GSnum%></td>
            </tr>
        </table>
        <br />
        <br />

        <%--表五 加工费  --%>
        <span style="font-weight: 700; font-size: 18px; margin: auto 20px;">表五 加工费</span>
        <table width="68%" border="1" style="color: #000; margin: 12px 18px;">
            <tr style="height: 30px;">
                <td>序号</td>
                <td>加工项目</td>
                <td>金     额（元）</td>
                <td>备注</td>
            </tr>
            <asp:Repeater ID="rptjiagong" runat="server">
                <ItemTemplate>
                    <tr style="height: 30px;">
                        <td><%#Container.ItemIndex+1 %></td>
                        <td><%#Eval("ItemName")%></td>
                        <td><%#Eval("Money") %></td>
                        <td><%#Eval("Remark") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <tr style="height: 30px;">
                <td colspan="4">加工费合计金额（元）：<%=JGnum%></td>
            </tr>
        </table>
        <br />
        <br />

        <%--表六 其它费用  --%>
        <span style="font-weight: 700; font-size: 18px; margin: auto 20px;">表六 其它费用</span>
        <table width="68%" border="1" style="color: #000; margin: 12px 18px;">

            <tr style="height: 30px;">
                <td>序号</td>
                <td>费用项目</td>
                <td>金     额（元）</td>
                <td>备注</td>
            </tr>
            <asp:Repeater ID="rptqita" runat="server">
                <ItemTemplate>
                    <tr style="height: 30px;">
                        <td><%#Container.ItemIndex+1 %></td>
                        <td><%#Eval("ItemName")%></td>
                        <td><%#Eval("Money") %></td>
                        <td><%#Eval("Remark") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <tr style="height: 30px;">
                <td colspan="4">其它费用合计金额（元）：<%=QTnum%></td>
            </tr>
        </table>
        <br />
        <br />

        <%--<span style="font-weight: 700; font-size: 18px; margin: auto 20px;">表七 其它费用 </span>

        <table width="68%" border="1" style="color: #000; margin: 12px 18px;">

            <tr style="height: 30px;">
                <td>序号</td>
                <td>费用项目</td>
                <td>金     额（元）</td>
                <td>备注</td>
            </tr>
            <asp:Repeater ID="rptqita2" runat="server">
                <ItemTemplate>
                    <tr style="height: 30px;">
                        <td><%#Eval("ID") %></td>
                        <td><%#Eval("ItemName")%></td>
                        <td><%#Eval("Money") %></td>
                        <td><%#Eval("Remark") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <tr style="height: 30px;">
                <td colspan="4">其它费用合计金额（元）：30.00</td>
            </tr>

        </table>

        <br />
        <br />
        <br />--%>


        <span style="font-weight: 700; font-size: 18px; margin: auto 20px;">合格证存根 </span>
        <table width="38%" border="1" style="color: #000; margin: 12px 18px;">
            <tr style="height: 30px;">
                <td colspan="4">存根</td>
            </tr>
            <tr style="height: 30px;">
                <td>托修方</td>
                <td><%=RepairMan %></td>
            </tr>
            <tr style="height: 30px;">
                <td>车牌号码</td>
                <td><%=PlateNumber%></td>
            </tr>
            <tr style="height: 30px;">
                <td>车型</td>
                <td><%=AutoType %></td>
            </tr>
            <tr style="height: 30px;">
                <td>发动机号/编号</td>
                <td><%=EngineNumber %></td>
            </tr>
            <tr style="height: 30px;">
                <td>底盘（车身）号</td>
                <td><%=ChassisNumber %></td>
            </tr>
            <tr style="height: 30px;">
                <td>维修类别</td>
                <td><%=RepairSort %></td>
            </tr>
            <tr style="height: 30px;">
                <td>维修合同编号</td>
                <td><%=ContractNumber %></td>
            </tr>
            <tr style="height: 30px;">
                <td>出厂里程表示值</td>
                <td><%=Mileage %></td>
            </tr>
            <tr style="height: 30px;">
                <td colspan="4">该车按维修合同维修，经检验合格，准予出厂。</td>
            </tr>
            <tr style="height: 30px;">
                <td>质量检验员</td>
                <td>（盖章）<%=CheckMan %></td>
            </tr>
            <tr style="height: 30px;">
                <td>承修单位</td>
                <td>盖章<%=UnitName %></td>
            </tr>
            <tr style="height: 30px;">
                <td>进厂日期：<%=SignDate %></td>
                <td>出厂日期：<%=FinishDate %></td>
            </tr>

            <tr style="height: 30px;">
                <td>托修方接车人</td>
                <td>签字<%=RepairMan %></td>
            </tr>
            <tr style="height: 30px;">
                <td>接车日期</td>
                <td><%=UploadTime %></td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    </div>
    <%-- </div>--%>
</asp:Content>

