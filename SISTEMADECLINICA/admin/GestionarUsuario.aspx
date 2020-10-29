<%@ Page Title="" Language="C#" MasterPageFile="~/plantilla.Master" AutoEventWireup="true" CodeBehind="GestionarUsuario.aspx.cs" Inherits="SISTEMADECLINICA.admin.GestionarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.css"/>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.js"></script>

	<script type="text/javascript">
		function mostrarMensaje(mensaje, tipoMensaje) {
			console.log(mensaje + tipoMensaje)
			$.alert({
				title: mensaje,
				content: tipoMensaje,
			});
		}
	</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!-- Content Row -->
<div class="row">
    <!--  Main container -->
    <div class="col-xl-12 col-lg-12" id="containerCard">
        <div class="card shadow mb-4">
            <!-- Card Header -  -->
            <div class="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                <h6 class="m-0 font-weight-bold text-dark">Gestionar Usuario</h6>
            </div>
            <!-- Card Body -->
            <div class="card-body">
                <!--Content-->
            <div class="row">
			   <div class="col">
				   <div class="form-group">
					   <asp:DropDownList ID="ddlEmpleado" runat="server" class="form-control">
					   </asp:DropDownList>
				   </div>
			   </div>
			   <div class="col">
				   <div class="form-group">
					   <asp:Button ID="Button2" runat="server" Text="Buscar" class="btn btn-success"/>
				   </div>
			   </div>
			</div>
			<div class="row">
				<div class="col">
					<div class="form-group">
						<label for="nombre">Login:</label> 
						<span class="text-danger">*</span> 
						<asp:TextBox ID="txtLogin" runat="server" class="form-control" placeholder="Login"></asp:TextBox>
					</div>
				</div>
				<div class="col">
					<div class="form-group">
						<label for="nombre">Contraseña:</label> 
						<span class="text-danger">*</span>
						<asp:TextBox ID="txtContra" runat="server" class="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
					</div>
				</div>
			</div>
			<div class="row">
				<div class="col">
					<div class="form-group">
						<label for="nombre">Privilegio:</label> 
						<span class="text-danger">*</span> <br />
						<asp:DropDownList ID="ddlPrivilegios" runat="server" class="form-control">
						</asp:DropDownList>
						&nbsp;</div>
				</div>
				<div class="col">
					<div class="form-group">
						<label for="nombre">Estado:</label> 
						<span class="text-danger">*</span><br />
						&nbsp;&nbsp;&nbsp;
						<asp:CheckBox ID="chEstado" runat="server" Text="Activo" style="width: 23px; height: 23px;"/>
					</div>
				</div>
			</div>
			<div class="row">
				<div class="col">
					<div class="form-group">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-info" OnClick="btnGuardar_Click"/>
&nbsp;
                        <asp:Button ID="btnModificar" runat="server" Text="Modificar" class="btn btn-warning"/>
&nbsp;
                        <asp:Button ID="btnInactivar" runat="server" Text="Inactivar" class="btn btn-danger"/>
					</div>
				</div>
			</div>
                <!--End content-->
            </div>
        </div>
    </div>
</div> 
</asp:Content>
