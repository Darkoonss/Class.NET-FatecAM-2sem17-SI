using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// BIBLIOTECAS PARA ENVIAR EMAIL
using System.Net;
using System.Net.Mail;

public partial class FaleConosco : System.Web.UI.Page
{
   protected void Page_Load(object sender, EventArgs e)
   {

   }

   protected void Enviar_Click(object sender, EventArgs e)
   {

        try
        {

            SmtpClient smtp = new SmtpClient();
            MailMessage email = new MailMessage();

        }
        catch (Exception)
        {

            Msg.Text = "Houve uma falha no envio, tente novamente mais tarde ";

        }

      // Monta a mensagem do email
      email.Subject = "Fale Conosco";
      email.Body = Nome.Text + "\n" + Email.Text + "\n" + Mensagem.Text;
      email.IsBodyHtml = false;
      email.To.Add("contato@seudominio.com.br");
      MailAddress eFrom = new MailAddress("contato@seudominio.com.br");
      email.From = eFrom;

      // AUTENTICAÇÃO NO  SERVER SMTP
      smtp.Host = "smtp.seudominio.com.br";
      smtp.Port = 587;
      smtp.EnableSsl = false;
      smtp.Credentials = new NetworkCredential("contato@seudominio.com.br", "sua senha");
      // ENVIA O EMAIL
      //smtp.Send(email);

      formEmail.Visible = false;
      MsgFinal.Visible = true;

   }
}