using CommuniCareProject.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Mvc;

namespace CommuniCareProject.Pages
{
    public partial class CriarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MontaFormulario();
        }

        public string MontaFormulario()
        {
            var html = "";

            var area = SolicitacaoBd.AreaSolcitacaoListar();
            
            var optionAreas = "<select id='selectArea' class='form-control select2 custom-select select2-hidden-accessible'>";

            foreach (var a in area)
            {
                optionAreas += "<option value='" + a.Id + "'>" + a.NomeArea + "</option>";
            }

            optionAreas += "</select>";

             opcoes.InnerHtml = optionAreas;

            return html;
        }
    }
}