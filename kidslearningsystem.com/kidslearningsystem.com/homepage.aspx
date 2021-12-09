<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="kidslearningsystem.com.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Alphabets</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 482px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
            Welcome<br />
            To<br />
            Kids Learing System<br />
            <br />
            Learning Items:<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Alphabets" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Picture" OnClick="Button2_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Games" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Maths" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="National Anthem" />
        </div>
    </form>
</body>
</html>
