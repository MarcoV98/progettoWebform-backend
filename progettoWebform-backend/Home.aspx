<%@ Page Title="" Language="C#" MasterPageFile="~/Ottica.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="progettoWebform_backend.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>EPICOTTICA - Home</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>EPICOTTICA - Il tuo ottico di Fiducia</h2>

    <asp:Repeater ID="rptArticoli" runat="server">
        <ItemTemplate>
        <div style="border: 1px solid #000; padding: 1rem; margin: 1rem;">
            <img src='<%# Eval("ImmagineUrl") %>' alt='<%# Eval("Nome") %>' style="max-width: 10rem; max-height: 10rem;" />
            <h3><%# Eval("Nome") %></h3>
            <p><%# Eval("Descrizione") %></p>
            <p>Prezzo: €<%# Eval("Prezzo", "{0:N2}") %></p>
            <a href='<%# "Dettaglio.aspx?Nome=" + Server.UrlEncode(Eval("Nome").ToString()) + "&Prezzo=" + Eval("Prezzo") + "&Descrizione=" + Server.UrlEncode(Eval("Descrizione").ToString()) + "&ImmagineUrl=" + Server.UrlEncode(Eval("ImmagineUrl").ToString()) %>'>Dettagli</a>
        </div>
    </ItemTemplate>
    </asp:Repeater>
</asp:Content>
