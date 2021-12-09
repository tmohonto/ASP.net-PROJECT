<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="kidslearningsystem.com.loginpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Login Page"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/registration.aspx">Donot have any account. Register now.</asp:HyperLink>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email -Id"></asp:Label>
&nbsp;:
        <asp:TextBox ID="textBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
&nbsp;:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="textBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
