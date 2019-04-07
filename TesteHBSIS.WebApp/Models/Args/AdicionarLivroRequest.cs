namespace TesteHBSIS.WebApp.Models.Args
{
    public class AdicionarLivroRequest
    {
        public string Titulo { get; set; }
        public decimal? Preco { get; set; }
        public int? Estoque { get; set; }
        public int? Edicao { get; set; }
        public int? IdGenero { get; set; }
        public int? IdAutor { get; set; }
    }
}
