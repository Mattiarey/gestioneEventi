<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aggiungiPost.aspx.cs" Inherits="BluaRey_Eventi.aggiungiPost"
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
            <h1>Aggiungi Post</h1>
            <form id="form1" runat="server">
                <div class="input-box">
                    <asp:TextBox ID="txt_titoloPost" runat="server" PlaceHolder="Titolo"></asp:TextBox>
                </div>
                <div class="input-box">
                    <asp:TextBox ID="txt_commento" runat="server" PlaceHolder="Descrizione"></asp:TextBox>
                </div>
                <div class="input-box">
                    <asp:TextBox ID="txt_voto" runat="server" PlaceHolder="Voto"></asp:TextBox>
                </div>
                <div class="input-box">
                    <asp:TextBox ID="txt_evento" runat="server" PlaceHolder="Evento collegato"></asp:TextBox>
                </div>
                <div class="dimenticato">
                    <a href="./AreaRiservata.aspx">Torna all'area riservata</a>
                </div>
                <asp:Button ID="btn_post" OnClick="btn_post_Click" runat="server" Text="Post" class="btn" />
            </form>
        </div>
    </body>

    </html>