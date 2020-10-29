<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SISTEMADECLINICA.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.css"/>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.js"></script>

<script type="text/javascript">
    function mostrarMensaje(mensaje, tipoMensaje) {
        console.log(mensaje+tipoMensaje)
        $.alert({
            title: mensaje,
            content: tipoMensaje,
        });
    }
</script>
</head>
<body style="background:#DFE2E2;">
<div class="row">
  <div class="col-sm-8" style="color:#DFE2E2;;">col-sm-8</div>
  <div class="col-sm-4"style="color:#DFE2E2;;">col-sm-4</div>
</div>
<div class="row">
  <div class="col-sm-8"style="color:#DFE2E2;;">col-sm-8</div>
  <div class="col-sm-4"style="color:#DFE2E2;;">col-sm-4</div>
</div>
<div class="row">
  <div class="col-sm-8"style="color:#DFE2E2;;">col-sm-8</div>
  <div class="col-sm-4"style="color:#DFE2E2;;">col-sm-4</div>
</div>
<div class="row">
  <div class="col-sm-8"style="color:#DFE2E2;;">col-sm-8</div>
  <div class="col-sm-4"style="color:#DFE2E2;;">col-sm-4</div>
</div>
<div class="row">
  <div class="col-sm"></div>
  <div class="col-sm">
    <div class="card">
        <article class="card-body">
        <h4 class="card-title mb-4 mt-1">Iniciar Sesi&oacute;n</h4>
            <form id="form2" runat="server">
                <div class="form-group">
                    <label>Usuario</label>
                    <asp:TextBox ID="txtLogin" runat="server" class="form-control" name="login" placeholder="login"></asp:TextBox>
                    <strong>
                    <asp:Label ID="lblUsuario" runat="server" ForeColor="Red"></asp:Label>
                    </strong>
                    <br />
                </div> 
                <div class="form-group">
                    <label>Contase&ntilde;a</label>
                    <asp:TextBox ID="txtPassword" runat="server" class="form-control" placeholder="Contrase&ntilde;a" TextMode="Password" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>
                    <strong>
                    <asp:Label ID="lblContra" runat="server" ForeColor="Red"></asp:Label>
                    </strong>
                    <br />
                </div>
                <div class="form-group"> 
                <div class="checkbox">
                  <label> 
                    <asp:CheckBox ID="chkRecordar" runat="server" />
                    Recordar Contase&ntilde;a</label>
                    <br />
                    <asp:Label ID="lblMensajes" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                </div>
                </div>
            <div class="form-group">
                <asp:Button ID="btnIniciar" runat="server" Text="Iniciar Sesión" class="btn btn-primary" value="Log In" OnClick="btnIniciar_Click"/>
            </div>                                                          
        </form>
        </article>
    </div>
  </div>
  <div class="col-sm"></div>
  </div>
</body>
</html>
