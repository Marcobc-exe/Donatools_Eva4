<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="donacionFormulario.aspx.cs" Inherits="Donatools_Eva3.donacionFormulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos/style.css" rel="stylesheet" />
    <link href="Estilos/estiloForm.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x" crossorigin="anonymous">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" class="auto-style1">
        <asp:TextBox ID="txtTitulo" placeholder="Titulo" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtDescripcion" placeholder="Descripcion" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtFecha" placeholder="fecha" runat="server"></asp:TextBox>
        <asp:RadioButtonList ID="rblTipo" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
            <asp:ListItem Value="ropa">Ropa</asp:ListItem>
            <asp:ListItem Value="comida">Comida</asp:ListItem>
            <asp:ListItem Value="ollaComun">Olla Común</asp:ListItem>
            <asp:ListItem Value="hogarAcogida">Hogar Acogida</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="btnCrearDonacion" runat="server" Text="Donar" OnClick="btnCrearDonacion_Click" />
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </form>
</asp:Content>
