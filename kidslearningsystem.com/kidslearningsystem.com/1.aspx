<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1.aspx.cs" Inherits="kidslearningsystem.com._1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-size: 100;
        }
        .newStyle2 {
            font-size: 95px;
        }
        .newStyle3 {
            font-size: 10px;
        }
        .newStyle4 {
            font-size: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" Height="145px" ImageUrl="~/image/stick.jpg" OnClick="ImageButton1_Click" Width="145px" />
        <asp:Button ID="Button1" runat="server" CssClass="newStyle2" Height="145px" Text="=" Width="145px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" CssClass="newStyle4" Height="145px" OnClick="Button2_Click" Text="1" Width="145px" />
    
    </div>
    </form>
</body>
</html>
