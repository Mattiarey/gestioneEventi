<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BluaRey_Eventi.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>Login</div><br/><br/>
        <asp:TextBox ID="txt_emailL" runat="server" PlaceHolder ="Email" TextMode="Email"></asp:TextBox><br/>
        <asp:TextBox ID="txt_pwdL" runat="server" PlaceHolder ="Password" TextMode="Password"></asp:TextBox><br/><br/>
        <asp:Button ID="btn_login" OnClick="btn_login_Click" runat="server" Text="Accedi" /><br/><br/>
        <a href = "Registrazione.aspx">Non sei registrato? Registrati!</a><br/>
        <a href = "Home.html">Torna alla home</a>
</form>

<style>
    body
    {
        text-align: center;
    }
</style>
</body>
</html>
