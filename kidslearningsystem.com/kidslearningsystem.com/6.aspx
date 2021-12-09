<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="6.aspx.cs" Inherits="kidslearningsystem.com._6" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/stick.jpg" />
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/image/stick.jpg" />
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/image/stick.jpg" />
        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/image/stick.jpg" />
        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/image/stick.jpg" />
        <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/image/stick.jpg" />
        <asp:Button ID="Button1" runat="server" CssClass="newStyle1" Height="145px" Text="=" Width="145px" />
        <asp:Button ID="Button2" runat="server" CssClass="newStyle2" Height="145px" OnClick="Button2_Click" Text="6" Width="145px" />
    
    </div>
    </form>
</body>
</html>
