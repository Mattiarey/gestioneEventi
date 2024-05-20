<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrazione.aspx.cs" Inherits="BluaRey_Eventi.Registrazione" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
        <form id="form1" runat="server">
        <div>Registrazione</div><br/><br/>
        <asp:TextBox ID="txt_emailR" runat="server" PlaceHolder ="Email" TextMode="Email"></asp:TextBox><br/>
        <asp:TextBox ID="txt_pwdR" runat="server" PlaceHolder ="Password" TextMode="Password"></asp:TextBox><br/><br/>
        <asp:Button ID="btn_registrazione" OnClick="btn_registrazione_Click" runat="server" Text="Registrati" /><br/><br/>
        <a href = "Login.aspx">Sei già registrato? Accedi!</a> <br/>
        <a href = "Home.html">Torna alla home</a>
    </form>

<style>
    body{
        text-align: center;
    }
    </style>
</body>
</html>
