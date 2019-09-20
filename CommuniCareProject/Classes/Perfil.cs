using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommuniCareProject
{
    public class Perfil
    {
        public int IdPerfil { get; set; }
        public int IdLogin { get; set; }
        public string NomePerfil { get; set; }
        public Boolean CriarUsuario { get; set; }
        public string Senha { get; set; }

    }
}