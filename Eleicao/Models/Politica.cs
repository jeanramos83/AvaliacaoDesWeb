using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eleicao.Models
{
    public class Politica
    {
        public int id { get; set; }
        public string nomeCandidato { get; set; }
        public string partido { get; set; }
        public string numeroCandidato { get; set; }
        public string cargo { get; set; }
        public string foto { get; set; }
    }
}
