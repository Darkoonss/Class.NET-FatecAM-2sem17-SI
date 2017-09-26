<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   <div id="Entrada" runat="server" visible="true">
      <asp:Label ID="msg" BackColor="Red" ForeColor="White" runat="server" ></asp:Label>
      <br />
      <label>Nome</label>
      <asp:TextBox ID="Nome" runat="server" />
      <label>Email</label>
      <asp:TextBox ID="Email" runat="server" />
      <label>Telefone</label>
      <asp:TextBox ID="Telefone" runat="server" />
      <label>Resumo</label>
      <asp:TextBox ID="Resumo" runat="server" />
      <br />
      <br />
      <asp:Button ID="Enviar" OnClick="Enviar_Click" runat="server" Text="Enviar" />
   </div>
   <div id="MensagemFinal" runat="server" visible="false">
      <p>Seus dados foram enviados com sucesso.</p>
   </div>

</asp:Content>

