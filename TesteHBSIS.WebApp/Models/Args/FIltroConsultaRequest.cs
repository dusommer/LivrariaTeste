using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteHBSIS.WebApp.Models.Args
{
    public class FIltroConsultaRequest
    {
        public int? IdAutor { get; set; }
        public int? IdGenero { get; set; }
        public string Titulo { get; set; }
        public decimal? PrecoDe { get; set; }
        public decimal? PrecoAte { get; set; }
    }
}