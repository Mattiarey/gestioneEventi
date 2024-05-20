<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrazione.aspx.cs" Inherits="BluaRey_Eventi.Registrazione"
    %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <meta charset="UTF-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
        <link href='https://unpkg.com/boxicons@2.1.4/css/boxicons.min.css' rel='stylesheet'/>
        <link rel="stylesheet" href="./css/style.css"/>
        <title>Pianificatore di Eventi</title>
    </head>

    <body>
        <div class="wrapper">
            <h1>Registrazione</h1>
            <form runat="server" id="form1">
                <div class="input-box">
                    <asp:TextBox ID="txt_emailR" runat="server" PlaceHolder="Email" TextMode="Email"></asp:TextBox>
                    <br />
                </div>
                <div class="input-box">
                    <asp:TextBox ID="txt_pwdR" runat="server" PlaceHolder="Password" TextMode="Password"></asp:TextBox>
                </div>
                <div class="dimenticato">
                    <div><asp:CheckBox id="checkbox1" runat="server" AutoPostBack="False" Text="Ricordami" /></div>
                    <a href="./Login.aspx"><span>Già registrato?</span></a>
                </div>
                <asp:Button ID="btn_registrazione" OnClick="btn_registrazione_Click" runat="server" Text="Registrati" class="btn"/>
            </form>
        </div>
    </body>

    </html>