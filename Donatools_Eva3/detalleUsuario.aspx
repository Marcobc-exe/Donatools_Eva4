<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="detalleUsuario.aspx.cs" Inherits="Donatools_Eva3.detalleUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/style.css" rel="stylesheet" />
    <link href="Estilos/estiloForm.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box_form">
        <h1>Detalle de Usuario</h1>
        <br />
        <asp:HiddenField ID="hdnCodigo" runat="server" />
        <asp:TextBox ID="txtBuscar" placeholder="Código Usuario" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
        <br />
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        <br />
        <asp:Panel ID="Panel1" Visible="false" runat="server">
            <asp:TextBox ID="txtCodigo" Enabled="false" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtRut" Enabled="false" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtNombre" Enabled="false" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtApellido" Enabled="false" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtEdad" Enabled="false" runat="server"></asp:TextBox>
            <asp:RadioButtonList ID="rblGenero" Enabled="false" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <asp:ListItem Value="f">Femenino</asp:ListItem>
                <asp:ListItem Value="m">Masculino</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="txtMail" Enabled="false" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtTelefono" Enabled="false" runat="server"></asp:TextBox>
            <asp:LinkButton ID="lnkEditar" runat="server" OnClick="lnkEditar_Click">Modificar</asp:LinkButton>
            <asp:Button ID="btnModificar" Visible="false" runat="server" Text="Guardar Cambios" OnClick="btnModificar_Click"/>
            <asp:Button ID="btnEliminar" Visible="false" runat="server" Text="Eliminar Usuario" OnClick="btnEliminar_Click" />
            <asp:Label ID="lbMensaje2" runat="server" Text=""></asp:Label>
        </asp:Panel>
    </div>
</asp:Content>
