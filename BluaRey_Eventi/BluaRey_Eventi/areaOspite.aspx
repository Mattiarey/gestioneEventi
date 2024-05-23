<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="areaOspite.aspx.cs" Inherits="BluaRey_Eventi.areaOspite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txt_territorio" runat="server" PlaceHolder="Territorio"></asp:TextBox>
        <asp:TextBox ID="txt_provincia" runat="server" PlaceHolder="Provincia"></asp:TextBox>
        <asp:Button ID="btn_visualizzaEventi" <!--OnClick="btn_visualizzaEventi_Click"--> runat="server" Text="Visualizza"/><br/><br/>
        <asp:Button ID="btn_visualizzaPost" <!--OnClick="btn_visualizzaPost_Click"--> runat="server" Text="Visualizza post"/><br/>
        <asp:GridView ID="dgvDati" runat="server">
        </asp:GridView>
        <br/>
        <a href = "Home.html">Logout</a>
    </form>
</body>
</html>
