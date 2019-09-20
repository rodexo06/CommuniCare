using CommuniCareProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommuniCareProject.Pages
{
    public partial class ListaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MontaTabela();
        }

        public string MontaTabela()
        {
            var usuarios = UsuarioBd.ListaUsuario();
            var html = "";
            foreach (var usuario in usuarios)
            {
                html += "<tr>" +
                            "<td class='text-nowrap align-middle'>" + usuario.CNPJ + "</td>" +
                            "<td class='text-nowrap align-middle'><span>" + usuario.Nome + "</span></td>" +
                            "<td class='text-nowrap align-middle'><span>" + usuario.Rua + "</span></td>" +
                            "<td class='text-center align-middle'>" +
                                "<div class='btn-group align-top'>" +
                                    "<button class='btn btn-sm btn-primary badge' data-target='#user-form-modal' data-toggle='modal' type='button'>Ediar</button>" +
                                "</div>" +
                            "</td>" +
                        "</tr>";
            }

            table.InnerHtml = html;
            return "";
        }
    }
}