using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommuniCareProject
{
    public class Solicitacao
    {
        public int IdTipo { get; set; }
        public int IdSolicitacao { get; set; }
        public string Descricao { get; set; }
        public string Usuario { get; set; }
        public string DataHora { get; set; }
        public int Status { get; set; }
        public int IdTicket { get; set; }
        public int IdResposta { get; set; }
        public int IdArea { get; set; }
        public int IdAlteracao { get; set; }
    }
}