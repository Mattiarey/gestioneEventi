<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AreaRiservata.aspx.cs" Inherits="BluaRey_Eventi.AreaRiservata"
	%>

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
			<h1>Area Riservata</h1>
			<form id="form1" runat="server">
				<div class="bottoniInColonna">
					<div class="button-box">
						<asp:Button OnClick="aggiungiArtisti" class="btn" text="Aggiungi artista" runat="server"/>
					</div>
					<div class="button-box">
						<asp:Button OnClick="creaEvento" class="btn" text="Crea un evento" runat="server"/>
					</div>
					<div class="button-box">
						<asp:Button OnClick="aggiungiPost" class="btn" text="Aggiungi post" runat="server"/>
					</div>
					<div class="button-box">
						<asp:Button OnClick="modificaEventi" class="btn" text="Modifica eventi" runat="server"/>
					</div>
					<div class="button-box">
						<asp:Button ID="btn_visualizzaEventi" OnClick="btn_visualizzaEventi_Click" runat="server"
							Text="Visualizza eventi" class="btn" />
					</div>
				</div>
				<div class="dimenticato">
					<a href="Home.html">Logout</a>
				</div>
				<asp:GridView ID="dgvDati" runat="server"></asp:GridView>
			</form>
		</div>
	</body>

	</html>