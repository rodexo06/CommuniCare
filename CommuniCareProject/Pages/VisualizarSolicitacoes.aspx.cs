using CommuniCareProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommuniCareProject.Pages
{
    public partial class VisualizarSolicitacoes : System.Web.UI.Page
    {
        Solicitacao solicitacao;
        protected void Page_Load(object sender, EventArgs e)
        {
            MontaVisualizacao();

        }

        public string MontaVisualizacao()
        {
            var html = "";
            string usuario = (string)Session["Login"];
            var solicitacoes = SolicitacaoBd.SolicitacaoAlimentacao(usuario);

            foreach (var solicitacao in solicitacoes)
            {

                html += "<div class='row well p-lg'>" +
                            "<div class='text-center col-2 mt-xl'>" +
                                 "<h3 class='m0'>" + solicitacao.IdSolicitacao + "</h3>";

                var statusSol = StatusBd.StatusAlimentacao();

                var area = SolicitacaoBd.AreaSolcitacaoListar();

                var tipo = SolicitacaoBd.TipoSolcitacaoListar();

                var sStatusSol = "";

                var sArea = "";

                var sTipo = "";

                sStatusSol = statusSol.Where(x => x.IdStatus == solicitacao.Status).Select(x => x.Descricao).FirstOrDefault().ToString();


                sArea = area.Where(x => x.Id == solicitacao.IdArea).Select(x => x.NomeArea).FirstOrDefault().ToString();
              

                sTipo = tipo.Where(x => x.IdTipo == solicitacao.IdTipo).Select(x => x.Descricao).FirstOrDefault().ToString();

                html += "<div><medium class='text-green'>" + sStatusSol + "</medium></div>";

                html += "<div><medium class='text-bold'>" + sArea + ":</medium></div>";

                html += "<div><medium class='text-bold'>" + sTipo + "</medium></div>";

                html +=  
                "</div>" +
                "<div class='col-8'>" +
                    "<div class='col-12'>" +
                        "<h3 class='m0'>" + solicitacao.Descricao.ToString() + "</h3>" +
                            "<div>" +
                                "<small>Data de Abertura: " + solicitacao.DataHora + "</small>" +
                              "</div>" +
                          "</div>" +
                      "</div>" +
                      "<div class='col-2'>" +
                          "<div class='col-12 text-center'>Ações</div>" +
                            "<div class='col-12 text-center'>" +
                                "<div class='col-sm-12' data-toggle='tooltip' data-placement='top' title='Tooltip on top'>" +
                                    "<a href='#' data-toggle='dropdown' aria-expanded='false'>" +
                                        "<em class='fa fa-eye'>" + "</em>" +
                                    "</a>" +
                                "</div>" +
                                "<div class='col-sm-12'>" +
                                    "<a href='#' data-toggle='dropdown' aria-expanded='false'>" +
                                        "<em class='fa fa-cube'>" + "</em>" +
                                    "</a>" +
                                "</div>" +
                              "</div>" +
                          "</div>" +
                      "</div>";
            }

            visualizacoes.InnerHtml = html;

            return html;
        }

    }
}