<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CadastroEdt.aspx.cs" Inherits="adm_CadastroEdt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   <div>
      <label>SELECIONE O NOME</label>
      <asp:DropDownList ID="Registros" Font-Size="16px" runat="server"></asp:DropDownList>
      <asp:Button ID="Buscar" OnClick="Buscar_Click" runat="server" Font-Size="16px" Text="Buscar" />
   </div>
   <hr />
   <div id="Entrada" runat="server" visible="true">
      <asp:Label ID="msg" BackColor="Red" ForeColor="White" runat="server" />
      <br />
      <asp:Label ID="Registro" runat="server" Font-Size="20px" />
      <br />
      <label>Nome</label>
      <asp:TextBox ID="Nome" runat="server" />
      <label>Email</label>
      <asp:TextBox ID="Email" runat="server" />
      <label>Telefone</label>
      <asp:TextBox ID="Telefone" runat="server" />
      <label>Resumo</label>
      <asp:TextBox ID="Resumo" TextMode="MultiLine" Rows="6" runat="server" />
      <br />
      <br />
      <asp:Button ID="Gravar" Enabled="false" OnClick="Gravar_Click" runat="server" Text="Gravar" />
      <asp:Button ID="Excluir" Enabled="false" OnClick="Excluir_Click" runat="server" Text="Excluir" />
   </div>
</asp:Content>

