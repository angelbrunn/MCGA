<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" 
    Inherits="MotoPoint.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="~/Content/css/home.css" rel="Stylesheet" type="text/css" />
<link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" type="text/css" />


<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>MotoPoint!</title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- INI - NAVEGADOR DE LA WEBAPP -->
        <nav class="navbar navbar-inverse">
            <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="home.aspx">MotoPoint!</a>
            </div>
            <div id="navBarCuerpo">
                <ul class="nav navbar-nav">
                <li><a href="#">Eventos</a></li>
                <li><a href="#">Contacto</a></li>
                <li>
                    <asp:Button ID="btnLogOff" Height="26px" OnClick="btnLogOff_Click" runat="server" Style="display: none"/>
                    <a class="fa fa-power-off" onclick="ExCodeBehindLogOffEvent()"></a>
                </li>
                </ul>
            </div>
            </div>
        </nav>
        <!-- FIN - NAVEGADOR DE LA WEBAPP -->
        <!-- INI - BODY DE LA WEBAPP -->
        <div class="row">
            <div class="col-md-4">
            <h2>Evento 1</h2>
            <p>
              acerca del evento 1.
            </p>
            <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301865">Learn more &raquo;</a></p>
        </div>
        <div class="col-md-4">
            <h2>Evento 2</h2>
            <p>
             acerca del evento 2.
            </p>
            <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301866">Learn more &raquo;</a></p>
        </div>
        <div class="col-md-4">
            <h2>Evento 3</h2>
            <p>
            acerca del evento 3.
            </p>
            <p><a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301867">Learn more &raquo;</a></p>
         </div>
        </div>
        <!-- INI - BODY DE LA WEBAPP -->
    </form>
    <!-- INI - FOOTER DE LA WEBAPP -->
    <div class="footer">
      <div class="container">
         <a href='#'><i class="fa fa-twitch fa-3x fa-fw"></i></a>
         <a href='#'><i class="fa fa-facebook fa-3x fa-fw"></i></a>
         <a href='#'><i class="fa fa-twitter fa-3x fa-fw"></i></a>
         <a href='#'><i class="fa fa-youtube-play fa-3x fa-fw"></i></a>
         <a href='#'><i class="fa fa-rss fa-3x fa-fw"></i></a>
         <a href='#'><i class="fa fa-vine fa-3x fa-fw"></i></a>
         <a href='#'><i class="fa fa-flickr fa-3x fa-fw"></i></a>
         <a href='#'><i class="fa fa-linkedin fa-3x fa-fw"></i></a>
      </div>
    </div>
    <!-- FIN - FOOTER DE LA WEBAPP -->
</body>
</html>
<script>
    function ExCodeBehindLogOffEvent() {
        document.getElementById("btnLogOff").click();
    }
</script>
