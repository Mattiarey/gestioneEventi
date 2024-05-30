<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="areaOspite.aspx.cs" Inherits="BluaRey_Eventi.areaOspite" %>

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
        <form id="form1" runat="server" class="formino">
            <div class="wrapperignolo">
                <h1>Area ospite</h1>
                <div class="gruppone">
                    <div class="sinistra">
                        <div class="input-morethings">
                            <label for="data_data">Data da cui vuoi ricercare:</label>
                            <asp:TextBox ID="data_data" runat="server" type="date"></asp:TextBox>
                        </div>
                        <div class="input-box">
                            <asp:TextBox ID="txt_territorio" runat="server" PlaceHolder="Territorio interessato">
                            </asp:TextBox>
                        </div>
                        <div class="input-box">
                            <asp:TextBox ID="txt_provincia" runat="server" PlaceHolder="Provincia"></asp:TextBox>
                        </div>
                        <div class="button-box">
                            <asp:Button ID="btn_visualizzaEventi" OnClick="btn_visualizzaEventi_Click" runat="server"
                                Text="Cerca" class="btn" />
                        </div>

                    </div>
                    <div class="destra">
                        <div class="input-box">
                            <asp:TextBox ID="txt_evento" runat="server" PlaceHolder="Evento"></asp:TextBox>
                        </div>
                        <div class="button-box">
                            <asp:Button ID="btn_visualizzaPost" OnClick="btn_visualizzaPost_Click" runat="server"
                                Text="Visualizza post e voti" class="btn" />
                        </div>
                    </div>
                </div>
                <div class="dimenticato">
                    <a href="Home.html">Home</a>
                </div>
            </div>
            <div class="tabella" id="iddo">
                <asp:GridView ID="dgvDati" runat="server"></asp:GridView>
            </div>
        </form>
    </body>
    <script>
        window.onbeforeunload = puppa()

        function puppa() {
            if(window.sessionStorage.getItem("caricato")!= "true"){
                window.sessionStorage.setItem("caricato", "true")
            }
            else{
                document.getElementsByClassName("tabella")[0].style.visibility = "visible";
            }
        }
    </script>
    </html>