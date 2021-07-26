<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar.Master" AutoEventWireup="true" CodeBehind="donacionFormulario.aspx.cs" Inherits="Donatools_Eva3.donacionFormulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box_form">
        <asp:TextBox ID="txtTitulo" placeholder="Titulo" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtDescripcion" placeholder="Descripcion" runat="server"></asp:TextBox>
        <div class="input-group cal-container">
            <asp:TextBox ID="txtFecha" placeholder="Fecha" runat="server" CssClass="form-control"></asp:TextBox>
            <span class="input-group-text calendar-btn">
                <asp:LinkButton ID="calLB" runat="server" OnClick="btnCalendar_Click">
                    <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-calendar-event" viewBox="0 0 16 16">
                        <path d="M11 6.5a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-1a.5.5 0 0 1-.5-.5v-1z"/>
                        <path d="M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM1 4v10a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4H1z"/>
                    </svg>
                </asp:LinkButton>
            </span>
            <span class="calendar-box">
                <asp:Calendar ID="calFecha" runat="server" OnSelectionChanged="calFecha_SelectionChanged"  ondayrender="calFecha_DayRender" ></asp:Calendar>
            </span>
        </div>
        <asp:RadioButtonList ID="rblTipo" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
            <asp:ListItem Value="1">Ropa</asp:ListItem>
            <asp:ListItem Value="2">Comida</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="btnCrearDonacion" runat="server" Text="Donar" OnClick="btnCrearDonacion_Click" />
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
