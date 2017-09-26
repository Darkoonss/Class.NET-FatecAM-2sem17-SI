using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cadastro : System.Web.UI.Page
{
   protected void Page_Load(object sender, EventArgs e)
   {

   }

   protected void Enviar_Click(object sender, EventArgs e)
   {
      if (Nome.Text.Trim() == "")
      {
         msg.Text = "O nome deve ser digitado!";
      }
      else if (Email.Text.Trim() == "")
      {
         msg.Text = "O nome deve ser digitado!";
      }
      else
      {
         // coneção PostGreSQL
         //User ID = root; Password = myPassword; Host = localhost; Port = 5432; Database = myDataBase; Pooling = true; Min Pool Size = 0; Max Pool Size = 100; Connection Lifetime = 0;

         string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/app_data/BancoDados.accdb") + ";Persist Security Info = False; ";

         string comando = "INSERT INTO Cadastro(Nome,Email,Telefone,Resumo) VALUES('" + Nome.Text + "','" + Email.Text + "','" + Telefone.Text + "','" + Resumo.Text + "');";

         // cria uma instancia da classe para transação no banco de dados access
         // o pacote AppDataBase foi importado para a pasta bin
         AppDatabase.OleDBTransaction ole = new AppDatabase.OleDBTransaction();

         // define a conexão com o database
         ole.ConnectionString = conexao;

         if ((int)ole.Query(comando) == 1)
         {
            Entrada.Visible = false;
            MensagemFinal.Visible = true;
         }
      }
   }
}