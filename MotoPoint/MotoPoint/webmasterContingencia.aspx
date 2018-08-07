<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webmasterContingencia.aspx.cs" 
    Inherits="MotoPoint.admContingencia" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Content/css/webmaster.css" rel="Stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>WebMaster</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="SistemaLogHeader">
            <div id="abmUser">
            <asp:Label ID="lblContingencia" runat="server" Text="Errores criticos reportados del Sistema"></asp:Label>
            </br>
            </br>
            <asp:LinkButton ID="LinkAdmin" runat="server" OnClick="LinkAdmin_Click">Ir a WebMaster !</asp:LinkButton>
            </div>
        </div>
        <div class="SistemaLogContenido">
            <asp:GridView ID="GridViewLogSystem" Class="LogSystemView" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
