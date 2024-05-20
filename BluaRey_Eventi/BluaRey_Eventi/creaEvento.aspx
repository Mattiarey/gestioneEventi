<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="creaEvento.aspx.cs" Inherits="BluaRey_Eventi.creaEvento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <p>Aggiungi un evento</p>
        <asp:TextBox ID="txt_titolo" runat="server" PlaceHolder ="Titolo"></asp:TextBox><br/><br/>
        <asp:TextBox ID="txt_luogo" runat="server" PlaceHolder ="Luogo"></asp:TextBox><br/><br/>
        <asp:TextBox ID="data" runat="server" type="date"></asp:TextBox><br/><br/>
        <asp:TextBox ID="txt_artista" runat="server" PlaceHolder ="Artista"></asp:TextBox><br/><br/>
        <asp:Button ID="btn_aggiungi" OnClick="btn_aggiungi_Click" runat="server" Text="Crea" /><br/><br/>
        <a href = "AreaRiservata.aspx">Torna all'area riservata</a>
    </form>
</body>
    <style>
        body
        {
            text-align:center;
        }
    </style>
</html>
