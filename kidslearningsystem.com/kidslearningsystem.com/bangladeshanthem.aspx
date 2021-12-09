<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bangladeshanthem.aspx.cs" Inherits="kidslearningsystem.com.bangladeshanthem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" CssClass="auto-style1" Height="292px" ImageUrl="~/image/bangladesh.png" OnClick="ImageButton1_Click" Width="447px" />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style2" OnClick="Button1_Click" Text="Stop" Width="108px" />
    
    </div>
    </form>
</body>
</html>
