using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adm_Produtos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack) LoadRepeater();

    }

    // String de conexao com o banco de dados
    string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/app_data/BancoDados.accdb") + ";Persist Security Info = False; ";
    // cria uma instancia da classe para transação no banco de dados access
    // o pacote AppDataBase foi importado para a pasta bin
    AppDatabase.OleDBTransaction ole = new AppDatabase.OleDBTransaction();

    protected void LoadRepeater()
    {

        // Le os produtos
        string sql = "SELECT * FROM Produtos WHERE Statu>0 ORDER BY Nome";
        ole.ConnectionString = conexao;
        DataTable tb = (DataTable)ole.Query(sql);

        // Coloca os produtos no repeater
        ListaProdutos.DataSource = tb;
        ListaProdutos.DataBind();
    }


}