<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_004_MeasureConverter.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBoxOne" runat="server"></asp:TextBox>
        <%--<asp:TextBox ID="TextBoxTwo" runat="server"></asp:TextBox>--%>
        <asp:Button ID="ConvertToMeter" runat="server" Text="From Feet to Meter"/>
        <asp:Button ID="ConvertToFeet" runat="server" Text="From Meter to Feet"/>
        <asp:Panel ID="PanelOne" runat="server"></asp:Panel>
    </div>
    </form>
</body>
</html>
