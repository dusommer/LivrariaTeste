using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteHBSIS.Domain.Argumentos
{
    public class FiltroConsultaRequest
    {
        public int? IdAutor { get; set; }
        public int? IdGenero { get; set; }
        public string Titulo { get; set; }
        public decimal? PrecoDe { get; set; }
        public decimal? PrecoAte { get; set; }
    }
}
