<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" 
    Inherits="MotoPoint.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="~/Content/css/login.css" rel="Stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
    <form id="formLogin" runat="server">
    <div>
        <div id="bodyLogin">
            <asp:TextBox runat="server" ID="txtUsuario" placeholder="usuario"></asp:TextBox><br />
            <br />
            <asp:TextBox runat="server" ID="txtContrasenia" TextMode="Password" placeholder="contraseña" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}" minlength="6" required title="Se requiere minimo 6 caracteres,1 Mayuscula,1 Minuscula y 1 caracter Especial!"></asp:TextBox><br />
            <br />
            <asp:Button runat="server" ID="btnLogin" Text="Login" OnClick="btnLogin_Click" />
            <br />
            <br />
            <div id="mensajeLogin">
            <div id="loginEstado">
                <p><font color="red">Usuario invalido! </font></p>
            </div>
            <asp:LinkButton ID="linkRegistrarse" runat="server">Registrarse</asp:LinkButton>
             |
            <asp:LinkButton ID="linkRecordar" runat="server">Recordar</asp:LinkButton>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
<script>
    var dbEstadoLogin = '<%= Session["loginEstado"].ToString() %>';
    if (dbEstadoLogin == 1) {
        document.getElementById("loginEstado").style.display = 'inline';
    } else {
        document.getElementById("loginEstado").style.display = 'none';
    }
</script>
