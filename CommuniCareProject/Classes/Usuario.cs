using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommuniCareProject
{
    public class Usuario
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        //public DateTime DataAbertura { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }

        public string Email { get; set; }

    }
}