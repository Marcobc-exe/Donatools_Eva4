<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Donatools_Eva3.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Inicio de Sesión</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
    <div class="box_form">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <h1>Iniciar Sesión</h1>
                <asp:TextBox ID="txtUsername" PlaceHolder="Nombre de usuario" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtPassword" Class="Pass" Textmode="password" PlaceHolder="Contraseña" runat="server" ></asp:TextBox>
                <asp:Label ID="lblMensaje2" runat="server" Text=""></asp:Label>
                <asp:Button ID="btnLogin" runat="server" Text="Ingresar" OnClick="btnLogin_Click" />
        
                <div class="panel_error">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nombre Obligatorio </br>" ForeColor="Red" ControlToValidate="txtUsername"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Contraseña Obligatoria" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    
    <asp:UpdateProgress ID="UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1" runat="server">
        <ProgressTemplate>
            <div class="loading-container position-absolute">
                <div id="loading">
                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>

</asp:Content>
