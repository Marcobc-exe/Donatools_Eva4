<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="registroUsuario.aspx.cs" Inherits="Donatools_Eva3.registroUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/style.css" rel="stylesheet" />
    <link href="Estilos/estiloForm.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
        <div class="box_form">
            <h1>Registro Usuarios</h1>
            <asp:TextBox ID="txtUsername" PlaceHolder="Nombre de usuario" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtPassword" Class="Pass" PlaceHolder="Contraseña" TextMode="Password" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtPass2" Class="Pass" PlaceHolder="Confirmar contraseña" TextMode="Password" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtCodigo" PlaceHolder="Código" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtRut" PlaceHolder="Rut" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtNombre"  PlaceHolder="Nombre" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtApellido"  PlaceHolder="Apellido" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtEdad" PlaceHolder="Edad" runat="server"></asp:TextBox>
            <asp:RadioButtonList ID="rblGenero" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <asp:ListItem Value="f">Femenino</asp:ListItem>
                <asp:ListItem Value="m">Masculino</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="txtTelefono" PlaceHolder="Telefono" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtMail" PlaceHolder="Correo" runat="server"></asp:TextBox>
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
            <div class="panel_error">
                <asp:RequiredFieldValidator Display="Dynamic" ControltoValidate="txtUsername" runat="server" ErrorMessage="Nombre de Usuario Obligatorio" ForeColor="red"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator Display="Dynamic" ControltoValidate="txtPassword" runat="server" ErrorMessage="Contraseña Obligatoria" ForeColor="red"></asp:RequiredFieldValidator>
                <asp:CompareValidator Display="Dynamic" ControltoValidate="txtPassword" ControltoCompare="txtPass2" runat="server" ErrorMessage="Las contraseñas no coinciden" ForeColor="red"></asp:CompareValidator>
                <asp:RequiredFieldValidator Display="Dynamic" ControltoValidate="txtCodigo" runat="server" ErrorMessage="Codigo Obligatorio" ForeColor="red"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator Display="Dynamic" ControltoValidate="txtRut" runat="server" ErrorMessage="Rut Obligatorio"  ForeColor="red"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator Display="Dynamic" ControltoValidate="txtNombre" runat="server" ErrorMessage="Nombre Obligatorio" ForeColor="red"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator Display="Dynamic" ControltoValidate="txtApellido" runat="server" ErrorMessage="Apellido Obligatorio" ForeColor="red"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator Display="Dynamic" ControltoValidate="txtEdad" runat="server" ErrorMessage="Edad Obligatoria" ForeColor="red"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator Display="Dynamic" ControltoValidate="rblGenero" runat="server" ErrorMessage="Genero Obligatorio"  ForeColor="red"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator Display="Dynamic" ControltoValidate="txtTelefono" runat="server" ErrorMessage="Telefono Obligatorio"  ForeColor="red"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator Display="Dynamic" ControltoValidate="txtMail" runat="server" ErrorMessage="Correo Obligatorio"  ForeColor="red"></asp:RequiredFieldValidator>
            </div>
        </div>
        
    </main>
</asp:Content>
