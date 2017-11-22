using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// PACOTES DE ACESSO A DADOS (DATATABLE)
using System.Data;
using System.IO;
using System.Diagnostics;

public partial class adm_CadastroEdt : System.Web.UI.Page
{
    // String de conexao com o banco de dados
    string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/app_data/BancoDados.accdb") + ";Persist Security Info = False; ";
    // cria uma instancia da classe para transação no banco de dados access
    // o pacote AppDataBase foi importado para a pasta bin
    AppDatabase.OleDBTransaction ole = new AppDatabase.OleDBTransaction();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarNomes();
        }
    }

    private void CarregarNomes()
    {

        string comando = "SELECT Registro,Nome FROM Cadastro ORDER BY Nome";


        // define a conexão com o database
        ole.ConnectionString = conexao;

        DataTable tb = (DataTable)ole.Query(comando);

        // carrega O DROPDOWNlist
        Registros.Items.Clear();
        for (int i = 0; i <= tb.Rows.Count - 1; i++)
        {
            Registros.Items.Add(new ListItem(tb.Rows[i]["nome"].ToString(), tb.Rows[i]["Registro"].ToString()));
        }
        tb.Dispose();
    }

    protected void Buscar_Click(object sender, EventArgs e)
    {
        string comando = "SELECT * FROM Cadastro WHERE Registro=" + Registros.SelectedValue;
        AppDatabase.OleDBTransaction ole = new AppDatabase.OleDBTransaction();
        // define a conexão com o database
        ole.ConnectionString = conexao;
        DataTable tb = (DataTable)ole.Query(comando);
        if (tb.Rows.Count == 1)
        {
            Registro.Text = tb.Rows[0]["Registro"].ToString();
            Nome.Text = tb.Rows[0]["Nome"].ToString();
            Email.Text = tb.Rows[0]["Email"].ToString();
            Telefone.Text = tb.Rows[0]["Telefone"].ToString();
            Resumo.Text = tb.Rows[0]["Resumo"].ToString();

            Gravar.Enabled = true;
            Excluir.Enabled = true;

        }
    }

    protected void Gravar_Click(object sender, EventArgs e)
    {
        string comando = "UPDATE Cadastro SET Nome='" + Nome.Text + "',Email='" + Email.Text + "',Telefone='" + Telefone.Text + "',Resumo='" + Resumo.Text + "' WHERE Registro=" + Registro.Text;

        AppDatabase.OleDBTransaction ole = new AppDatabase.OleDBTransaction();
        // define a conexão com o database
        ole.ConnectionString = conexao;
        if ((int)ole.Query(comando) == 1)
        {
            Limpar();
            CarregarNomes();
        }
        else
        {
            msg.Text = "Falha na atualização dos dados!";
        }
    }
    protected void Limpar()
    {
        Registro.Text = "";
        Nome.Text = "";
        Email.Text = "";
        Telefone.Text = "";
        Resumo.Text = "";
        Gravar.Enabled = false;
        Excluir.Enabled = false;
    }

    protected void Excluir_Click(object sender, EventArgs e)
    {

    }


}