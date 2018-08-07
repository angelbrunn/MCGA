<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webmaster.aspx.cs" 
    Inherits="MotoPoint.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Content/css/webmaster.css" rel="Stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>WebMaster</title>
</head>
<body>
    <form id="fromAdministrador" name="fromAdministrador" runat="server">
    <div id="dbEstado">
      <p>
        <asp:Label ID="lblDbEstado" Text="DB - DIGITO VERIFICADOR - OK" value="1" runat="server"></asp:Label>
      </p>
    </div>

    <div id="abmUser">
    <p>Administracion de Usuarios - ABM Perfiles - <asp:LinkButton ID="LinkGestionPerfiles" runat="server" OnClick="LinkGestionPerfiles_Click">Gestion Perfiles</asp:LinkButton></p>
    <p>Ir a la WebSite MotoPoint! - <asp:LinkButton ID="LinkHome" runat="server" OnClick="LinkHome_Click">Ir a MotoPoint!</asp:LinkButton></p>
    </div>
    <div id="abmContingencia">
    Se han producidos errores criticos - <asp:LinkButton ID="linkContingencia" runat="server" OnClick="linkContingencia_Click">Ver contingencia!</asp:LinkButton>
    </div>
    <br />
    <div>
    <asp:Table ID="tbBitacora" runat="server" Height="102px" Width="100%">
    <asp:TableRow>
        <asp:TableCell>idEvento</asp:TableCell>
        <asp:TableCell>idUsuario</asp:TableCell>
        <asp:TableCell>descripcion</asp:TableCell>
        <asp:TableCell>fecha</asp:TableCell>
    </asp:TableRow>
    </asp:Table>
    </div>
    <br />
    <div id="admBackup">
    <p>Administracion de arquitectura Base - Resguardo y Restauracion.</p> 
        <p>
        <asp:CheckBox ID="chkbxBitacora" Text="Bitacora" runat="server" />
        <asp:CheckBox ID="chkbxUsuario" Text="Usuario" runat="server" />
        <asp:CheckBox ID="chkbxGrupo" Text="Grupo" runat="server" />
        <asp:CheckBox ID="chkbxGrupoPermiso" Text="GrupoPermisos" runat="server" />
        <asp:CheckBox ID="chkbxPermiso" Text="Permiso" runat="server" />
        <asp:CheckBox ID="chkbxMultiIdioma" Text="Multi-Idioma" runat="server" />
        <asp:CheckBox ID="chkbxUsuarioGrupo" Text="UsuarioGrupo" runat="server" />
        </p>
        <p>
        <asp:Button class="btn success" ID="btnExportar" Text="Exportar" runat="server" OnClick="btnExportar_Click"/>
        <asp:Button class="btn success" ID="btnImportar" Text="Importar" runat="server" OnClick="btnImportar_Click"/>
        </p>
        <br />
    </div>
    <div id="admDebug">
        <p>Administracion de arquitectura Base - Debug</p>
        <asp:Button class="btn warning" ID="btnTbitacora" Text="Test Bitacora" runat="server" OnClick="btnTbitacora_Click"/>
        <asp:Button class="btn warning" ID="btnTidioma" Text="Cambiar Idioma" runat="server"/>
        <asp:Button class="btn info" ID="btnTinfo" Text="Info" runat="server"/>
        <asp:Button class="btn danger" ID="btnSalir" Text="Salir" runat="server" OnClick="btnSalir_Click"/>
    </div>
    </form>
</body>
</html>
<script>
    var dbEstadoSession = '<%= Session["dbEstado"].ToString() %>';
    var dbEstadoContingencia = '<%= Session["dbContingencia"].ToString() %>';
    var dbEstadoExportacion = '<%= Session["fExportar"].ToString() %>';
    var dbEstadoImportacion = '<%= Session["fImportar"].ToString() %>';

    if (dbEstadoSession == 1) {
        document.getElementById("dbEstado").style.background = '#e81212';
        document.getElementById('lblDbEstado').innerHTML = 'DB - ERROR DIGITO VERIFICADOR!';
    }
    if (dbEstadoExportacion == 1) {
        alert("La exportacion se realizo de forma correcta!");
    }
    if (dbEstadoImportacion == 1) {
        alert("La importacion se realizo de forma correcta!");
    }
    if (dbEstadoContingencia == 1) {
        document.getElementById("abmContingencia").style.margin = '-5px 0px';
        document.getElementById("abmContingencia").style.textAlign = 'left';
        document.getElementById("abmContingencia").style.fontFamily = 'arial, sans-serif';
    } else {
        document.getElementById("abmContingencia").style.display = 'none';
    }
</script>
