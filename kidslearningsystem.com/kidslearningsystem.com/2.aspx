<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2.aspx.cs" Inherits="kidslearningsystem.com._2" %>

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
    </style>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div style="text-align: left">
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton2" runat="server" Height="145px" ImageUrl="~/image/stick.jpg" Width="145px" />
        <asp:Button ID="Button1" runat="server" CssClass="newStyle1" Height="145px" Text="+" Width="145px" />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="145px" ImageUrl="~/image/stick.jpg" Width="145px" />
        <asp:Button ID="Button2" runat="server" CssClass="newStyle2" Height="145px" Text="=" Width="145px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" CssClass="newStyle3" Height="145px" OnClick="Button3_Click" Text="2" Width="145px" />
    
    </div>
    </form>
</body>
</html>
