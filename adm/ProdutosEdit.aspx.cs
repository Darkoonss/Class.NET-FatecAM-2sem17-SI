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

    }

    protected void Buscar_Click(object sender, EventArgs e)
    {

    }

    protected void LimparBusca_Click(object sender, EventArgs e)
    {

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
            UrlFoto.Value = "~/produtos_fotos/" + FileUpload1.PostedFile.FileName;
            string caminhoFisico = Server.MapPath(UrlFoto.Value);
            // salva a foto
            FileUpload1.SaveAs(caminhoFisico);
        }

        string sql = "";

        if (ProdutoId.Text != "")
        {
            //upload
            sql = "update";

        }
        else
        {
            // insert

            sql = "insert";
        }

    }

    protected void Excluir_Click(object sender, EventArgs e)
    {

    }
}