using CommuniCareProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommuniCareProject.Pages
{
    public partial class LoginValida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var senha = Request.QueryString["senha"].ToUpper().ToString();
            var user = Request.QueryString["user"].ToString();
            var validaLogin = PerfilBd.LoginValidacao(user, senha);
            //var pegalogin = SolicitacaoBd.PegarLogin(user);
            //var tipo = SolicitacaoBd.VoltarLogin(user);
            Session["Login"] = user;
            if (validaLogin)
            {
                Response.Redirect("Default.aspx");
            }

            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}