<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr><td>用户名:</td><td><asp:TextBox runat="server" ID="tbxUserName"></asp:TextBox></td></tr>
        <tr><td>密码:</td><td><asp:TextBox runat="server" ID="tbxPassword" TextMode="Password"></asp:TextBox></td></tr>
        <tr><td><asp:Button runat="server" ID="btnRegister"  OnClick="btnRegister_Click"  Text="注册" /></td><td><asp:Label runat="server" ID="lblMsg"></asp:Label></td></tr>
    </table>
    </div>
    </form>
</body>
</html>
