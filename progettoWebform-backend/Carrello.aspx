<%@ Page Title="" Language="C#" MasterPageFile="~/Ottica.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="progettoWebform_backend.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>EPICOTTICA - Carrello</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Carrello</h2>

    <p><asp:Label ID="lblMessaggio3" runat="server" Text=""></asp:Label></p>
    <asp:Repeater ID="rptCarrello" runat="server">
        <ItemTemplate>
            <div style="border: 1px solid #000; padding: 1rem; margin: 1rem;">
                <h3><%# Eval("Nome") %></h3>
                <span>Prezzo: €<%# Eval("Prezzo", "{0:N2}") %></span>
                <asp:Button runat="server" Text="Elimina articolo" OnClick="EliminaArticolo_Click" CommandArgument='<%# Eval("Nome") %>' />
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>

    <asp:Button ID="btnProcediAcquisto" runat="server" Text="Procedi all'acquisto" OnClientClick="return false;" />

    <p><asp:Label ID="lblTotalePrezzi" runat="server" Text=""></asp:Label></p>
    <p><asp:Label ID="lblMessaggio2" runat="server" Text=""></asp:Label></p>
</asp:Content>
