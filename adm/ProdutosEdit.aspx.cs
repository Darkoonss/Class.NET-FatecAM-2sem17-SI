using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adm_ProdutosEdit : System.Web.UI.Page
{

    string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/app_data/BancoDados.accdb") + ";Persist Security Info = False; ";
    // cria uma instancia da classe para transação no banco de dados access
    // o pacote AppDataBase foi importado para a pasta bin
    AppDatabase.OleDBTransaction ole = new AppDatabase.OleDBTransaction();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) LoadGrid();
    }

    protected void LoadGrid()
    {
        string comando = "SELECT ProdutoId,Nome,Status FROM Produtos WHERE Status>-1 ORDER BY Nome";
        ole.ConnectionString = conexao;
        DataTable tb = (DataTable)ole.Query(comando);
        Produtos.DataSource = tb;
        Produtos.DataBind();
    }


    protected void Buscar_Click(object sender, EventArgs e)
    {
        LoadGrid();
    }

    protected void LimparBusca_Click(object sender, EventArgs e)
    {
        BuscarNome.Text = "";
        LoadGrid();
    }

    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    // Grava a edição ou insere novo produto
    protected void Gravar_Click(object sender, EventArgs e)
    {
        // Grava a img do prduto na pasta
        if (FileUpload1.HasFile)
        {
            UrlFoto.Value = "~/produtos_fotos/" + FileUpload1.FileName;
            string caminhoFisico = Server.MapPath(UrlFoto.Value);
            // salva a foto
            FileUpload1.SaveAs(caminhoFisico);
        }

        string sql = "";

        if (ProdutoId.Text != "") 
        {
            //upload
            sql = "UPDATE Produtos SET Nome='"+Nome.Text+"',Descricao='"+Descricao.Text+"',UrlFoto='"+UrlFoto.Value+"',Status="+Status.SelectedValue+",DateTimeInsert=Now(),DateTimeUpdate=Now();";

        }
        else
        {
            // insert

            sql = "INSERT INTO Produtos (Nome,Descricao,UrlFoto,Status,DateTimeUpdate) VALUES ('"+Nome.Text+"','"+Descricao.Text+"',UrlFoto='"+UrlFoto.Value+"',DateTimeUpdate=Now();";
        }

        // Conecta no Banco de Dados e Executa o Comando SQL
        ole.ConnectionString = conexao;
        ole.Query(sql);
        Limpar();

    }

    protected void Limpar()
    {
        Nome.Text = "";
        Descricao.Text = "";
        UrlFoto.Value = "";
        Status.SelectedValue = "1";
        Foto.ImageUrl = "";
        Excluir.Enabled = false;
    }

    protected void Excluir_Click(object sender, EventArgs e)
    {

        // Conecta no banco de dados e executao o comando sql
        ole.ConnectionString = conexao;
        ole.Query("UPDATE Produtos SET Status=1, DateTimeUpdate=Now()");
        Limpar();

    }
}