<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_006_övning2_databas.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button runat="server" id="buttonOne" OnClick="buttonOne_OnClick"/>
        <asp:DropDownList runat="server" id="DropDownList1" AutoPostBack="True"/>
        <asp:Label runat="server" ID="Label1" Text="" Visible="False"></asp:Label>
    </div>
    </form>
</body>
</html>
