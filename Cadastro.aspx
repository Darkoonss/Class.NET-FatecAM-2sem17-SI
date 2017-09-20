<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="Entrada" runat="server" visible="true">
        <label>NOME</label>
        <asp:textbox ID="Nome" runat="server"></asp:textbox>

        <label>Email</label>
        <asp:textbox ID="Email" runat="server"></asp:textbox>

        <label>Telefone</label>
        <asp:textbox ID="Telefone" runat="server"></asp:textbox>

        <label>Resumo</label>
        <asp:textbox ID="Resumo" runat="server"></asp:textbox>
        <br /><br />

        <asp:button ID="Enviar" OnClick="Enviar_Click" runat="server" text="Button" text="Enviar"/>
    </div>
    <div id="MensagemFinal" runat="server" visible="false">
        <p>Seus dados foram enviados com sucesso :P</p>
    </div>

</asp:Content>