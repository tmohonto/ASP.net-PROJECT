<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="kidslearningsystem.com.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 259px;
            width: 712px;
        }
        .auto-style2 {
            height: 25px;
        }
        .auto-style4 {
            height: 25px;
            width: 257px;
            text-align: right;
        }
        .auto-style5 {
            width: 257px;
            text-align: right;
        }
        .auto-style6 {
            text-align: left;
        }
        .auto-style7 {
            text-align: left;
            width: 148px;
        }
        .auto-style8 {
            height: 25px;
            width: 148px;
            text-align: left;
        }
        .auto-style9 {
            width: 148px;
        }
        .auto-style10 {
            width: 257px;
            text-align: right;
            height: 27px;
        }
        .auto-style11 {
            width: 148px;
            height: 27px;
            text-align: left;
        }
        .auto-style12 {
            height: 27px;
        }
        .auto-style13 {
            width: 100%;
            height: 256px;
        }
        .auto-style14 {
            width: 257px;
            text-align: right;
            height: 28px;
        }
        .auto-style15 {
            text-align: left;
            width: 148px;
            height: 28px;
        }
        .auto-style16 {
            text-align: left;
            height: 28px;
        }
    </style>
</head>
<body style="height: 276px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        SignUp From<br />
        <table class="auto-style13">
            <tr>
                <td class="auto-style5"><strong><em>First Name :</em></strong></td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox1" runat="server" Width="168px"></asp:TextBox>
                </td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"><strong><em>Last Name :</em></strong></td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox2" runat="server" Width="169px"></asp:TextBox>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style5"><strong><em>Email :</em></strong></td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox3" runat="server" Width="170px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10"><strong><em>Gender :</em></strong></td>
                <td class="auto-style11">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style5"><strong><em>Address ;</em></strong></td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox4" runat="server" Width="166px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"><strong><em>Phone :</em></strong></td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox5" runat="server" Width="167px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14"><strong><em>Password :</em></strong></td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox6" runat="server" Width="170px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox6" ControlToValidate="TextBox7" ErrorMessage="CompareValidator"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"><strong><em>Confirm Password :</em></strong></td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox7" runat="server" Width="170px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style9">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SignUp" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
