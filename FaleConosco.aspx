<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FaleConosco.aspx.cs" Inherits="FaleConosco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   <!-- FORMULÁRIO -->
   <div style="width: 40%; float: left; background-color: #e5e5e5; border-radius: 5px; border: 1px solid #c0c0c0; height: 500px;">
      <div style="padding: 20px; font-size: 12px;">
         <img src="Images/icon_faleconosco.png" />
         <h1>Fale Conosco</h1>

         <!-- FORMULÁRIO -->
         <div id="formEmail" runat="server" visible="true">
            <br />
            <asp:Label ID="Msg" runat="server" BackColor="#990000" ForeColor="White"></asp:Label>
            <br /><br />SEU NOME
         <br />
            <asp:TextBox Width="90%" ID="Nome" runat="server"></asp:TextBox>
            <br />E-MAIL
         <br />
            <asp:TextBox Width="90%" ID="Email" MaxLength="255" runat="server"></asp:TextBox>
            <br />
            MENSAGEM
         <br />
            <asp:TextBox Width="90%" ID="Mensagem" runat="server" TextMode="MultiLine" Rows="4" MaxLength="255"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Enviar" OnClick="Enviar_Click" runat="server" Text="Enviar" />
         </div>

         <!-- MENSAGEM FINAL -->
         <div id="MsgFinal" runat="server" visible="false">
            <br /><br /><br />
            <h2>Seu e-mail foi enviado com sucesso!<br />Obrigado pela participação.</h2>
         </div>
      </div>
   </div>
   <!-- MAPA -->
   <div style="float: right; height: 500px; border: 1px solid #c0c0c0; border-radius: 5px; width: 55%">
      <!-- incorporar o mapa do local aqui-->
      <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3679.6892383522522!2d-47.35252258539616!3d-22.739789185096885!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c89bea5cdb94f9%3A0xffb368bd91ea12ae!2sFatec+Americana!5e0!3m2!1spt-BR!2sbr!4v1504098809762" width="100%" height="100%" frameborder="0" style="border: 0" allowfullscreen></iframe>
   </div>
</asp:Content>

