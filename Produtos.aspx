<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Produtos.aspx.cs" Inherits="Produtos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>Produtos</h1>
    <br />
    <br />
    <asp:Repeater ID="ListaProdutos" OnItemDataBound="ListaProdutos_ItemDataBound" runat="server">
        <ItemTemplate>
            <div style="padding: 10px; margin-bottom: 20px; border-bottom: 1px dotted #c0c0c0;">
                <!-- CAIXA DA IMAGEM -->
                <div style="float: left; margin-right: 20px; width: 200px; height: 200px;">
                    <asp:Image ID="Foto" Style="max-height: 200px; max-width: 200px;" runat="server" />
                </div>
                <div style="float:left; width:600px; padding:10px;">
                    <asp:Label ID="Nome" runat="server" Text='<%#Bind("Nome")%>'></asp:Label>
                    <br /><br />
                    <asp:Label ID="Descricao" runat="server" Text='<%#Bind("Descricao")%>'></asp:Label>
                </div>
            </div>
            <div style="clear: both"></div>
        </ItemTemplate>
    </asp:Repeater>



</asp:Content>

