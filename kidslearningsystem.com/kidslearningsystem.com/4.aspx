<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4.aspx.cs" Inherits="kidslearningsystem.com._4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-size: 100px;
        }
        .newStyle2 {
            font-size: 100px;
        }
        .newStyle3 {
            font-size: 100px;
        }
        .newStyle4 {
            font-size: 100px;
        }
        .newStyle5 {
            font-size: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/stick.jpg" />
        <asp:Button ID="Button1" runat="server" CssClass="newStyle3" Height="145px" Text="+" Width="145px" />
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/image/stick.jpg" />
        <asp:Button ID="Button2" runat="server" CssClass="newStyle4" Height="145px" Text="+" Width="145px" />
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/image/stick.jpg" />
        <asp:Button ID="Button3" runat="server" CssClass="newStyle5" Height="145px" Text="+" Width="145px" />
        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/image/stick.jpg" />
        <asp:Button ID="Button4" runat="server" CssClass="newStyle1" Height="145px" Text="=" Width="145px" />
        <asp:Button ID="Button5" runat="server" CssClass="newStyle2" Height="145px" OnClick="Button5_Click" Text="4" Width="145px" />
    
    </div>
    </form>
</body>
</html>
