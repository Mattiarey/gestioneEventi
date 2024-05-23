<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aggiungiArtisti.aspx.cs"
	Inherits="BluaRey_Eventi.aggiungiArtisti" %>

	<!DOCTYPE html>

	<html xmlns="http://www.w3.org/1999/xhtml">

	<head runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<meta charset="UTF-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1.0" />
		<link href='https://unpkg.com/boxicons@2.1.4/css/boxicons.min.css' rel='stylesheet' />
		<link rel="stylesheet" href="./css/style.css" />
		<title>Pianificatore di Eventi</title>
	</head>

	<body>
		<div class="wrapper">
			<h1>Aggiungi Artisti</h1>
			<form runat="server" id="form1">
				<div class="input-box">
					<asp:TextBox ID="txt_nomeArtista" runat="server" PlaceHolder="Nome"></asp:TextBox>
				</div>
				<div class="dimenticato"><a href="AreaRiservata.aspx">Torna all'area riservata</a></div>
				<asp:Button ID="btn_aggiungiArtista" OnClick="btn_aggiungiArtista_Click" runat="server"
					Text="Aggiungi" class="btn"/>
			</form>
		</div>
	</body>

	</html>