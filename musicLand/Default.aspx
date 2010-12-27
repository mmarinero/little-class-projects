<%@ Page Language="C#" AutoEventWireup="True" EnableEventValidation="false" CodeBehind="Default.aspx.cs" Inherits="MusicLand._Default" Async="True" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>MusicLand</title>
    <link rel="stylesheet" type="text/css" media="screen" href="Stylesheet1.css" />
    <script src="lyrics.js" type="text/javascript"></script>
</head>
<body  onload="document.getElementById('TBuscador').focus();">
    <div id="header"><a href="default.aspx">MusicLand</a></div>
        <form id="form2" action="Default.aspx">
        <asp:Literal ID="literalBuscar" runat="server"></asp:Literal>
        <br />
        <button id="BBuscador" type="submit">buscar</button>
        <br />
        </form>


    <div id="youtube">
    <asp:Literal ID="literal1" runat="server"></asp:Literal>
    </div>
    <asp:Literal ID="ErrorBox" runat="server"></asp:Literal>
    <asp:DataGrid ID="trackList" runat="server" BackColor="White" 
        BorderColor="#3366CC" BorderWidth="1px" CellPadding="4" >
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <SelectedItemStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" 
            Mode="NumericPages" />
        <ItemStyle BackColor="White" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
    </asp:DataGrid>
</body>
</html>