﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usa.aspx.cs" Inherits="kidslearningsystem.com.usa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" CssClass="auto-style1" Height="276px" ImageUrl="~/image/usa.png" OnClick="ImageButton1_Click" Width="498px" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Stop" />
    
    </div>
    </form>
</body>
</html>
