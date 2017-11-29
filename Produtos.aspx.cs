using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Produtos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) LoadRepeater();
    }

    string conexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + HttpContext.Current.Server.MapPath("~/App_Data/BancoDados.accdb") + ";Persist Security Info=False;";

    AppDatabase.OleDBTransaction ole = new AppDatabase.OleDBTransaction();

    protected void LoadRepeater()
    {
        // LE OS PRODUTOS DO BANCO DCE DADOS
        string sql = "SELECT * FROM Produtos WHERE Status>0 ORDER BY Nome;";
        ole.ConnectionString = conexao;
        DataTable tb = (DataTable)ole.Query(sql);

        if (tb.Rows.Count > 0)
        {
            // COLOCA OS PRODUTOS NO REPEATER
            ListaProdutos.DataSource = tb;
            ListaProdutos.DataBind();
        }
    }

    protected void ListaProdutos_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        Image Foto = (Image)e.Item.FindControl("Foto");
        DataRowView row = (DataRowView)e.Item.DataItem;

        if (row["UrlFoto"].ToString() != "")
        {
            Foto.ImageUrl = ResolveUrl(row["UrlFoto"].ToString());
            Foto.Visible = true;
        }
        else
        {
            Foto.Visible = false;
        }
    }
}