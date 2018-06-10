<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" 
    Inherits="MotoPoint.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/Content/css/admin.css" rel="Stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>WebMaster</title>
</head>
<body>
    <form id="fromAdministrador" name="fromAdministrador" runat="server">
    <div id="dbEstado">
      <p>
        <asp:Label ID="lblDbEstado" Text="DB IS OK - DIGITO VERIFICADOR isOk" value="1" runat="server"></asp:Label>
      </p>
    </div>

    <div>
    <p><asp:LinkButton ID="LinkGestionPerfiles" runat="server" OnClick="LinkGestionPerfiles_Click">Gestion Perfiles</asp:LinkButton></p>
    <p><asp:LinkButton ID="LinkHome" runat="server" OnClick="LinkHome_Click">Ir a MotoPoint!</asp:LinkButton></p>
    </div>
    <br />
    <div>
    <!-- LLENAR TABLA CON DATOS DE LA BITACORA -->
    <asp:Table ID="Table1" runat="server" Height="102px" Width="622px">
    </asp:Table>
    </div>
    <br />
    <div id="admBackup">
    <p>Administracion de arquitectura Base - Resguardo y Restauracion.</p> 
        <p>
        <asp:Label ID="lblBitacora" Text="Bitacora" name="lblBitacora" runat="server"></asp:Label>
        <asp:RadioButton ID="chkbxBitacora" name="chkbxBitacora" runat="server" />
        <asp:Label ID="lblUsuario" Text="Usuario" name="lblUsuario" runat="server"></asp:Label>
        <asp:RadioButton ID="chkbxUsuario" name="chkbxUsuario" runat="server" />           
        <asp:Label ID="lblGrupo" Text="Grupo" name="lblGrupo" runat="server"></asp:Label>
        <asp:RadioButton ID="chkbxGrupo" name="chkbxGrupo" runat="server" />
        <asp:Label ID="lblGrupoPermiso" Text="GrupoPermisos" name="lblGrupoPermiso" runat="server"></asp:Label>
        <asp:RadioButton ID="chkbxGrupoPermiso" name="chkbxGrupoPermiso" runat="server" />
        <asp:Label ID="lblPermiso" Text="Permisos" name="lblPermiso" runat="server"></asp:Label>
        <asp:RadioButton ID="chkbxPermiso" name="chkbxPermiso" runat="server" />
        <asp:Label ID="lblMultiIdioma" Text="MultiIdioma" name="lblMultiIdioma" runat="server"></asp:Label>
        <asp:RadioButton ID="chkbxMultiIdioma" name="chkbxMultiIdioma" runat="server" />
        <asp:Label ID="lblUsuarioGrupo" Text="UsuarioGrupo" name="lblUsuarioGrupo" runat="server"></asp:Label>
        <asp:RadioButton ID="chkbxUsuarioGrupo" name="chkbxUsuarioGrupo" runat="server" />
        </p>
        <p>
        <asp:Button class="btn success" ID="btnExportar" Text="Exportar" runat="server"/>
        <asp:Button class="btn success" ID="btnImportar" Text="Importar" runat="server"/>
        </p>
        <br />
    </div>
    <div id="admDebug">
        <p>Administracion de arquitectura Base - Debug</p>
        <asp:Button class="btn warning" ID="btnTbitacora" Text="Test Bitacora" runat="server"/>
        <asp:Button class="btn warning" ID="btnTidioma" Text="Cambiar Idioma" runat="server"/>
        <asp:Button class="btn info" ID="btnTinfo" Text="Info" runat="server"/>
        <asp:Button class="btn danger" ID="btnSalir" Text="Salir" runat="server"/>
    </div>
    </form>
</body>
</html>
<script>
    var dbEstadoSession = '<%= Session["dbEstado"].ToString() %>';

    if (dbEstadoSession == 1) {
        document.getElementById("dbEstado").style.background = '#e81212';
    }
</script>
