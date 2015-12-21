<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_002_måndag_15_12_21_övning.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBoxOne" runat="server" Text="Wello, hurld!"></asp:TextBox>
        <asp:Label ID="LabelOne" runat="server" Text="Stämpel"></asp:Label>
        <asp:Button ID="ButtonOne" runat="server" Text="Knapp"/>
        <asp:HyperLink ID="HyperLinkOne" runat="server" href="www.hd.se" Text="x"></asp:HyperLink>
        <asp:Panel ID="PanelOne" runat="server" Height="50px" Width="50px" BackColor="red"></asp:Panel>
        
    </div>
    </form>
</body>
</html>
