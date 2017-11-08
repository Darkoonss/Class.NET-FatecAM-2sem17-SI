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
    <!-- EXIBE O GRID -->
    <asp:Panel ID="Panel1" runat="server" Width="100%" Height="300px" ScrollBars="Vertical">
        <asp:GridView ID="GridView1" AutoGenerateColumns="true" AutoGenerateSelectButton="true" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="100%" CellPadding="8" HeaderStyle-BackColor="#DFDFDF" BorderColor="#cccccc" runat="server">
        </asp:GridView>
    </asp:Panel>

    <!-- Formulario de edição -->
        <div style="padding:30px; width:50%;">
            <asp:label id="ProdutoId" runat="server" text="Label"></asp:label>
            <br /><br />
            Nome<br />
            <asp:textbox id="Nome" runat="server"></asp:textbox>
            <br />
            Descrição<br />
            <asp:textbox id="Descricao" TextMode="MultiLine" Rows="8" runat="server"></asp:textbox>
            <br />
            Status<br />
            <asp:dropdownlist id="Status" runat="server">
                   <asp:ListItem Text="Exibir no site" value="1" select="true" ></asp:ListItem>
                   <asp:ListItem Text="Não exibir no site" value="0" select="true" ></asp:ListItem>
            </asp:dropdownlist>
            <br />
            Foto<br />
            <asp:image id="Foto" runat="server"></asp:image>
            <asp:hiddenfield id="UrlFoto" runat="server"></asp:hiddenfield>
            <br />
            <asp:fileupload id="FileUpload1" runat="server"></asp:fileupload>
            <br /><br /><br />
            <asp:button id="Gravar" OnClick="Gravar_Click" runat="server" text="Gravar" />
            <asp:Button ID="Excluir" OnClick="Excluir_Click" runat="server" Text="Excluir" />
        </div>
    <!-- End Formulario de edição -->
</asp:Content>

