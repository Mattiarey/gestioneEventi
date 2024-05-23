<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="creaEvento.aspx.cs" Inherits="BluaRey_Eventi.creaEvento" %>

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
            <h1>Crea Evento</h1>
            <form id="form1" runat="server">
                <div class="input-box">
                    <asp:TextBox ID="txt_titolo" runat="server" PlaceHolder="Titolo"></asp:TextBox>
                </div>
                <div class="input-box">
                    <asp:TextBox ID="txt_luogo" runat="server" PlaceHolder="Luogo"></asp:TextBox>
                </div>
                <div class="input-box">
                    <asp:TextBox ID="txt_provincia" runat="server" PlaceHolder="Provincia"></asp:TextBox>
                </div>
                <div class="input-box">
                    <asp:TextBox ID="data" runat="server" type="date"></asp:TextBox>
                </div>
                <div class="input-box">
                    <asp:TextBox ID="txt_artista" runat="server" PlaceHolder="Artista"></asp:TextBox>
                </div>
                <div class="dimenticato">
                    <a href="./AreaRiservata.aspx">Torna all'area riservata</a>
                </div>
                <asp:Button ID="btn_aggiungi" OnClick="btn_aggiungi_Click" runat="server" Text="Crea" class="btn" />
            </form>
        </div>
    </body>

    </html>