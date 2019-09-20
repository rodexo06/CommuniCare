using CommuniCareProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommuniCareProject.Pages
{
    public partial class CriarUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var logradouro = Request.QueryString["logradouro"].ToString();
            var bairro = Request.QueryString["bairro"].ToString();
            var cep = Request.QueryString["cep"].ToString();
            var cidade = Request.QueryString["cidade"].ToString();
            var num = Request.QueryString["num"].ToString();
            var complemento = Request.QueryString["complemento"].ToString();
            var uf = Request.QueryString["uf"].ToString();
            var nome = Request.QueryString["nome"].ToString();
            var cpf = Request.QueryString["cpf"].ToString();

            UsuarioBd bd = new UsuarioBd();
            Usuario usuario = new Usuario();

            usuario.Nome = nome;
            usuario.CNPJ = cpf;
            usuario.Cep = cep;
            usuario.Bairro = bairro;
            usuario.Municipio = cidade;
            usuario.Rua = logradouro;
            usuario.Numero = int.Parse(num);
            usuario.Complemento = complemento;
            usuario.Uf = uf;

            bd.PerfilIncluir(usuario);

            Response.Redirect("../default.aspx");
        }
    }
}