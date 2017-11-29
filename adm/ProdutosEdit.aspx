<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProdutosEdit.aspx.cs" Inherits="adm_ProdutosEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- FILTRAR NOMES NO GRID -->
    <div style="padding: 20px;">
        <asp:TextBox ID="BuscarNome" Width="160px" runat="server"></asp:TextBox>
        <asp:Button ID="Buscar" OnClick="Buscar_Click" runat="server" Text="Buscar" />
        <asp:Button ID="LimparBusca" OnClick="LimparBusca_Click" runat="server" Text="X" />
    </div>
    <!-- EXIBE O GRID COM OS DADOS DOS PRODUTOS -->
    <asp:Panel ID="Panel1" BorderStyle="Solid" BorderWidth="1px" BorderColor="#c0c0c0" runat="server" Width="100%" Height="300px" ScrollBars="Vertical">
        <asp:GridView ID="Produtos" AutoGenerateColumns="true" AutoGenerateSelectButton="true" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="100%" CellPadding="8" HeaderStyle-BackColor="#DFDFDF" BorderColor="#cccccc" runat="server">
        </asp:GridView>
    </asp:Panel>
    <!-- FORMULÁRIO DE EDIÇÃO -->
    <div style="padding: 30px; width: 50%;">
        <asp:Label ID="ProdutoId" runat="server"></asp:Label>
        <br />
        <br />
        NOME<br />
        <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
        <br />
        DESCRICAO<br />
        <asp:TextBox ID="Descricao" TextMode="MultiLine" Rows="8" runat="server"></asp:TextBox>
        <br />
        STATUS<br />
        <asp:DropDownList ID="Status" runat="server">
            <asp:ListItem Text="EXIBIR NO SITE" Value="1" Selected="True"></asp:ListItem>
            <asp:ListItem Text="NÃO EXIBIR NO SITE" Value="0"></asp:ListItem>
        </asp:DropDownList>
        <br />
        FOTO<br />
        <asp:Image ID="Foto" Style="max-width: 300px;" runat="server" />
        <asp:HiddenField ID="UrlFoto" runat="server" />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <br />
        <asp:Button ID="Gravar" runat="server" OnClick="Gravar_Click" Text="Gravar" />
        <asp:Button ID="Excluir" runat="server" OnClick="Excluir_Click" Text="Excluir" />
    </div>

</asp:Content>

