using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommuniCareProject
{
    public class Permicoes
    {
        public int IdPerfil { get; set; }
        public Boolean CriarSolic { get; set; }
        public Boolean CriarUsuar { get; set; }
        public Boolean EditarUsuar { get; set; }
        public Boolean ResponderChamado { get; set; }
        public string Bairro { get; set; }
    }
}