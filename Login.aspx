<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-left: 60px;">
      <h1>ENTRAR</h1>
      <asp:Label ID="Mensagem" runat="server" ForeColor="red"></asp:Label>
      <br />
      NOME<br />
      <asp:TextBox ID="Nome" Width="200px" runat="server"></asp:TextBox>
      <br />
      <br />
      SENHA<br />
      <asp:TextBox ID="Senha" Width="200px" TextMode="Password" runat="server"></asp:TextBox>
      <br />
      <br />
      <asp:Button ID="Entrar" runat="server" OnClick="Entrar_Click" Text="Entrar" />
   </div>
</asp:Content>

