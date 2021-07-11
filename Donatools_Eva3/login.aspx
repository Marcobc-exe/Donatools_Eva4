<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Donatools_Eva3.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/style.css" rel="stylesheet" />
    <link href="Estilos/estiloForm.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" class="auto-style1">
        <h1>Iniciar Sesión</h1>
        <asp:TextBox ID="txtUsername" PlaceHolder="Nombre de usuario" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtPassword" Class="Pass" Textmode="password" PlaceHolder="Contraseña" runat="server" ></asp:TextBox>
        <asp:Label ID="lblMensaje2" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnLogin" runat="server" Text="Ingresar" OnClick="btnLogin_Click" />
    <div class="panel_error">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nombre Obligatorio" ForeColor="Red" ControlToValidate="txtUsername"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Contraseña Obligatoria" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
    </div>
    </form>
</asp:Content>
