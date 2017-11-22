using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adm_ProdutosEdit : System.Web.UI.Page
{
    // String de conexao com o banco de dados
    string conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/app_data/BancoDados.accdb") + ";Persist Security Info = False; ";
    // cria uma instancia da classe para transação no banco de dados access
    // o pacote AppDataBase foi importado para a pasta bin
    AppDatabase.OleDBTransaction ole = new AppDatabase.OleDBTransaction();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) LoadGrid();
    }

    // CARREGA OS DADOS NO GRID
    protected void LoadGrid()
    {
        string comando = "SELECT ProdutoId,Nome,Status FROM Produtos WHERE Status >-1 AND Nome LIKE '%" + BuscarNome.Text + "%' ORDER BY Nome";
        ole.ConnectionString = conexao;
        DataTable tb = (DataTable)ole.Query(comando);
        Produtos.DataSource = tb;
        Produtos.DataBind();
    }

    // BUSCA NO BANCO DE DADOS AS CORRESPONDENCIAS 
    protected void Buscar_Click(object sender, EventArgs e)
    {
        LoadGrid();
    }

    // LIMPA A BUSCA E EXIBE TODOS OS REGISTROS
    protected void LimparBusca_Click(object sender, EventArgs e)
    {
        BuscarNome.Text = "";
        LoadGrid();
    }

    // MÉTODO EXECUTADO QUANDO UM ITEM É SELECIONADO
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string idsel = Produtos.SelectedRow.Cells[1].Text.ToString();
        string comando = "SELECT * FROM Produtos WHERE ProdutoId=" + idsel;
        ole.ConnectionString = conexao;
        DataTable tb = (DataTable)ole.Query(comando);

        if (tb.Rows.Count == 1)
        {
            ProdutoId.Text = tb.Rows[0]["ProdutoId"].ToString();
            Nome.Text = tb.Rows[0]["Nome"].ToString();
            Descricao.Text = tb.Rows[0]["Descricao"].ToString();
            Status.SelectedValue = tb.Rows[0]["Status"].ToString();
            UrlFoto.Value = tb.Rows[0]["UrlFoto"].ToString();
            if (UrlFoto.Value != "")
            {
                Foto.ImageUrl = ResolveUrl(UrlFoto.Value);
                Foto.Visible = true;
            }
            else
            {
                Foto.Visible = false;
            }
        }
    }

    // GRAVA A EDIÇÃO OU INSERE NOVO PRODUTO
    protected void Gravar_Click(object sender, EventArgs e)
    {
        // GRAVA A IMAGEM DO PRODUTO NA PASTA
        if (FileUpload1.HasFile)
        {
            UrlFoto.Value = "~/produtos_fotos/" + FileUpload1.FileName;
            string caminhoFisico = Server.MapPath(UrlFoto.Value);
            // SALVA O ARQUIVO
            FileUpload1.SaveAs(caminhoFisico);
        }
        string sql = "";

        if (ProdutoId.Text != "")
        {
            //UPLOAD
            sql = "UPDATE Produtos SET  Nome='" + Nome.Text + "',Descricao='" + Descricao.Text + "',UrlFoto='" + UrlFoto.Value + "',Status=" + Status.SelectedValue + ",DateTimeUpdate=Now() WHERE ProdutoId=" + ProdutoId.Text;
        }
        else
        {
            // INSERT
            sql = "INSERT INTO Produtos(Nome,Descricao,UrlFoto,Status,DateTimeInsert,DateTimeUpdate) VALUES('" + Nome.Text + "','" + Descricao.Text + "','" + UrlFoto.Value + "'," + Status.SelectedValue + ",Now(),Now());";
        }
        // CONECTA NO BANCO DE DADOS E EXECUTAO O COMANDO SQL
        ole.ConnectionString = conexao;
        ole.Query(sql);
        Limpar();
    }

    protected void Limpar()
    {
        ProdutoId.Text = "";
        Nome.Text = "";
        Descricao.Text = "";
        UrlFoto.Value = "";
        Status.SelectedValue = "1";
        Foto.ImageUrl = "";
        LoadGrid();
        Excluir.Enabled = false;
    }

    // MARCA O PRODUTO COM STATUS-1 "EXCLUIDO"
    protected void Excluir_Click(object sender, EventArgs e)
    {
        // CONECTA NO BANCO DE DADOS E EXECUTAO O COMANDO SQL
        ole.ConnectionString = conexao;
        ole.Query("UPDATE Produtos SET Status=-1, DateTimeUpdate=Now() WHERE ProdutoId=" + ProdutoId.Text + ";");
        Limpar();
    }
}