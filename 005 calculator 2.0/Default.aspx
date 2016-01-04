<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_005_calculator_2._0.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox id="InputBoxOne" runat="server"/>
        <asp:TextBox id="InputBoxTwo" runat="server"/>
        
        

        <asp:TextBox id="OutputBox" runat="server"/>
    </div>
        <p>
        

        <asp:Button id="ButtonAdd" Text="+" runat="server" OnClick="ButtonAdd_Click"/>
        <asp:Button id="ButtonSubtract" Text="-" runat="server" OnClick="ButtonSubtract_Click"/>

        </p>
    </form>
</body>
</html>
