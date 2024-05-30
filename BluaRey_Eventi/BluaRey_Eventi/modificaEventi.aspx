<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modificaEventi.aspx.cs"
    Inherits="BluaRey_Eventi.modificaEventi" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <meta charset="UTF-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <link href='https://unpkg.com/boxicons@2.1.4/css/boxicons.min.css' rel='stylesheet' />
        <link rel="stylesheet" href="./css/style.css" />
        <title></title>
    </head>

    <body>
        
        <div class="wrapper">
            <form id="form1" runat="server">
                <h1>Modifica eventi</h1>
                <div class="input-morethings">
                    <label for="txt_titolo">Inserisci il titolo dell'evento da modificare e/o il nome dell'artista e riempi i campi interessati nella modifica</label>
                    <asp:TextBox ID="txt_titolo" runat="server" PlaceHolder="Titolo evento da modificare" class="titoloOriginale"></asp:TextBox>
                </div>
                <div class="input-box">
                    <asp:TextBox ID="txt_titoloM" runat="server" PlaceHolder="Titolo nuovo"></asp:TextBox>
                </div>
                <div class="button-box">
                    <asp:Button ID="btn_titolo" OnClick="btn_titolo_Click" runat="server" Text="Modifica titolo"
                        class="btn" />
                </div>
                <div class="input-box">
                    <asp:TextBox ID="txt_luogoM" runat="server" PlaceHolder="Luogo nuovo"></asp:TextBox>
                </div>
                <div class="button-box">
                    <asp:Button ID="btn_luogo" OnClick="btn_luogo_Click" runat="server" Text="Modifica luogo"
                        class="btn" />
                </div>
                <div class="input-box">
                    <asp:TextBox ID="txt_provinciaM" runat="server" PlaceHolder="Provincia nuova"></asp:TextBox>
                </div>
                <div class="button-box">
                    <asp:Button ID="btn_provincia" OnClick="btn_provincia_Click" runat="server"
                        Text="Modifica provincia" class="btn" />
                </div>
                <div class="input-box">
                    <asp:TextBox ID="dataM" runat="server" type="date"></asp:TextBox>
                </div>
                <div class="button-box">
                    <asp:Button ID="btn_data" OnClick="btn_data_Click" runat="server" Text="Modifica data"
                        class="btn" />
                </div>
                <div class="input-box">
                    <asp:TextBox ID="txt_artista" runat="server" PlaceHolder="Artista pre-modifica"></asp:TextBox>
                </div>
                <div class="input-box">
                    <asp:TextBox ID="txt_artistaM" runat="server" PlaceHolder="Artista nuovo"></asp:TextBox>
                </div>
                <div class="button-box">
                    <asp:Button ID="btn_artista" OnClick="btn_artista_Click" runat="server" Text="Modifica artista"
                        class="btn" />
                </div>
            </form>
        </div>
    </body>

    </html>