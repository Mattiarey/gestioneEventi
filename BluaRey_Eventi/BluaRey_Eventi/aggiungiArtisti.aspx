<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aggiungiArtisti.aspx.cs" Inherits="BluaRey_Eventi.aggiungiArtisti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>Aggiungi artista</div><br/>
            <asp:TextBox ID="txt_nomeArtista" runat="server" PlaceHolder ="Nome"></asp:TextBox><br/><br/>
            <asp:Button ID="btn_aggiungiArtista" OnClick="btn_aggiungiArtista_Click" runat="server" Text="Aggiungi" /><br/><br />
            <a href = "AreaRiservata.aspx">Torna all'area riservata</a>
    </form>
        <style>
	button 
	{
		padding: 10px 20px;
		font-size: 16px;
		border: none;
		border-radius: 5px;
		cursor: pointer;
		background-color: grey;
		color: white;
		transition: background-color 0.3s ease;
	}

	body 
	{
		font-family: Arial, sans-serif;
		background-color: #f0f0f0;
		text-align: center;
	}
</style>
</body>

</html>
