
using CommuniCareProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommuniCareProject.Paginas
{
    public partial class AbrirSolicitacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Solicitacao solicitacao = new Solicitacao();

            var html = MontaFormulario();
            abrirSolicitacao.InnerHtml = html;
            //var areasSol = SolicitacaoBd.AreaSolcitacaoListar();
        }

        public string MontaFormulario()
        {
            var html = "";

            html += "<div class='card'>" +
                        "<div class='card-header'>" +
                            "<h3 class='mb-0 card-title'>Abrir Solicitação</h3>" +
                         "</div>";

            var area = SolicitacaoBd.AreaSolcitacaoListar();

            var tipo = SolicitacaoBd.TipoSolcitacaoListar();

            html += "<div class='card-body'>" +
                        "<div class='row'>" +
                            "<div class='col-md-3'>" +
                                "<div class='form-group'>" +
                                    "<label class='form-label'>Área de Solicitação</label>" +
                                    "<select id='nomeArea'>";
            foreach (var a in area)
            {
                html += "<option value='" + a.Id + "'>" + a.NomeArea + "</option>";
            }

            html +=     "</select>" + 
                    "</div>" +
                "</div>";

            html += "<div class='col-md-3'>" +
                        "<div class='form-group'>" +
                        "<label class='form-label' >Tipo de Solicitação</label>" +
                        "<select id='tipoSolicitacao'>";
            foreach (var t in tipo)
            {
                html += "<option value='" + t.IdTipo + "'>" + t.Descricao + "</option>";
            }

            html += "</select>" +
                   "</div>" +
               "</div>";

            html+=    "<div class='col-md-12'>" +
                            "<div class='form-group mb-0'>" +
                                "<label class='form-label'>Mensagem</label>" +
                                "<textarea class='form-control col-md-12' name='example-textarea-input' rows='4' id='mensagem' placeholder='Escreva seu texto aqui..'>" + "</textarea>" +
                            "</div>" +
                        "</div>" +
                        "<div class='col-md-12'>" +
                            "<div style='float: right; padding-top: 5px;'>" +
                                "<a class='btn btn-default' onclick='SalvaForm();'>Enviar</a>" +
                            "</div>" +
                        "</div>" +
                    "</div>" +
                "</div>" +
            "</div>";
            return html;
        }
    }
}