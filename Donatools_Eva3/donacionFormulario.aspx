<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="donacionFormulario.aspx.cs" Inherits="Donatools_Eva3.donacionFormulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box_form">
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
    </div>
</asp:Content>
