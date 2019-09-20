using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommuniCareProject
{
    public class Endereco
    {
        public string CNPJ { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
    }
}