<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aggiungiPost.aspx.cs" Inherits="BluaRey_Eventi.aggiungiPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>Registrazione</div><br/><br/>
        <asp:TextBox ID="txt_titoloPost" runat="server" PlaceHolder ="Titolo"></asp:TextBox><br/>
        <asp:TextBox ID="txt_commento" runat="server" PlaceHolder ="Descrizione"></asp:TextBox><br/><br/>
        <asp:TextBox ID="txt_voto" runat="server" PlaceHolder ="Voto"></asp:TextBox><br/><br/>
        <asp:TextBox ID="txt_evento" runat="server" PlaceHolder ="Evento collegato"></asp:TextBox><br/><br/>
        <asp:Button ID="btn_post" OnClick="btn_post_Click" runat="server" Text="Post" /><br/><br/>
        <a href = "Login.aspx">Sei già registrato? Accedi!</a> <br/>
        <a href = "Home.html">Torna alla home</a>
    </form>
</body>
</html>
