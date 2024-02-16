<%@ Page Title="" Language="C#" MasterPageFile="~/Ottica.Master" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="progettoWebform_backend.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>EPICOTTICA - Dettagli</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Articolo selezionato:</h2>

    <div style="border: 1px solid #000; padding: 1rem; margin: 1rem;">
        <h3>Articolo: <asp:Label ID="lblNomeArticolo" runat="server" /></h3>
        <asp:Image ID="imgArticolo" runat="server" AlternateText="Immagine Articolo" style="max-width: 7rem; max-height: 7rem;"/>
        <p>Descrizione: <asp:Label ID="lblDescrizione" runat="server" /></p>
        <p><asp:Label ID="lblPrezzo" runat="server" /></p>
        <asp:Button ID="btnAggiungiAlCarrello" runat="server" Text="Aggiungi al Carrello" OnClick="AggiungiAlCarrello_Click" />
    </div>

    <asp:Label ID="lblMessaggio" runat="server" Text="" ForeColor="Red"></asp:Label>
</asp:Content>
