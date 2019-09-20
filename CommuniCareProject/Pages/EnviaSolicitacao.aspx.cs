using CommuniCareProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommuniCareProject.Pages
{
    public partial class EnviaSolicitacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var mensagem = Request.QueryString["mensagem"].ToString();
            var tipoSolicitacao = Request.QueryString["tipoSolicitacao"].ToString();
            var nomeArea = Request.QueryString["nomeArea"].ToString();

            Solicitacao solicitacao = new Solicitacao();
            solicitacao.Usuario = (string)Session["Login"];
            solicitacao.Descricao = mensagem;
            solicitacao.IdSolicitacao = int.Parse(tipoSolicitacao);
            solicitacao.IdArea = int.Parse(nomeArea);

            SolicitacaoBd.SolicitacaoIncluir(solicitacao);

            Response.Redirect("VisualizarSolicitacoes.aspx");
        }
    }
}