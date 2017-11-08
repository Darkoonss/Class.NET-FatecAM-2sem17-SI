using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// NECESSÁRIO PARA AUTENTICAÇÃO DO USUÁRIO
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      
   }

   protected void Entrar_Click(object sender, EventArgs e)
   {
      if (Nome.Text == "jose" && Senha.Text == "12345")
      {
         // inicializa a classe de autenticação do usuário
         FormsAuthentication.Initialize();
         // cria o ticket dwe autenticação
         Session["NomeUsuario"] = "jose";
         
         FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, Nome.Text, DateTime.Now, DateTime.Now.AddMinutes(30), false, Session["NomeUsuario"].ToString(), FormsAuthentication.FormsCookiePath);

         // Grava o ticket no cookie de autenticação
         Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket)));

         // redireciona para a página do usuário]
         Response.Redirect(FormsAuthentication.GetRedirectUrl(Nome.Text, false));
      }
   }
}