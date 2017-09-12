<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   <div>
      <!-- BANNERS -->
      <div class="flexslider">
         <ul class="slides">
            <li>
               <img src="Images/banner1.png" />
            </li>
            <li>
               <img src="Images/banner2.png" />
            </li>
            <li>
               <img src="Images/banner3.png" />
            </li>
         </ul>
         <script type="text/javascript">
            $(window).load(function () {
               $('.flexslider').flexslider({
                  animation: "slide",
               });
            });
         </script>
      </div>
      <!-- TEXTOS -->
      <div style="margin-top: 50px;">
         <!-- box flutuante de texto -->
         <div style="height: 300px; float: left; overflow: hidden; text-align: justify; font-size: 14px; padding: 20px; margin: 20px; border: 1px solid #c0c0c0; width: 260px;">
            <h2>Cuide da segurança</h2>
            <p>
               Lorem ipsum dolor sit amet.<br />
               Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est 
            </p>
         </div>

         <div style="\">
            <h2>Cuide da segurança</h2>
            <p>
               Lorem ipsum dolor sit amet.<br />
               Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est 
            </p>
         </div>

      </div>
   </div>
</asp:Content>

