<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AreaRiservata.aspx.cs" Inherits="BluaRey_Eventi.AreaRiservata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <p>Area Riservata</p>
    <button onclick="window.location.href='creaEvento.aspx'">Crea un evento</button> <br /><br />
	<button onclick="window.location.href='aggiungiArtisti.aspx'">Aggiungi artista</button> <br /><br />
	<button onclick="window.location.href='aggiungiPost.aspx'">Aggiungi post</button> <br /><br />
    <form id="form1" runat="server">

        <asp:Button ID="btn_visualizzaEventi" OnClick="btn_visualizzaEventi_Click" runat="server" Text="Visualizza eventi"/><br/><br/>
        <a href = "Home.html">Logout</a>
    </form>
</body>
    <style>
	button {
		padding: 10px 20px;
		font-size: 16px;
		border: none;
		border-radius: 5px;
		cursor: pointer;
		background-color: grey;
		color: white;
		transition: background-color 0.3s ease;
	}

	body {
		font-family: Arial, sans-serif;
		background-color: #f0f0f0;
		text-align: center;
	}
</style>
</html>
