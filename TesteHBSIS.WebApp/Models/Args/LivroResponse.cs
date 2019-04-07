namespace TesteHBSIS.WebApp.Models.Args
{
    public class LivroResponse
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public int Edicao { get; set; }
        public int IdGenero { get; set; }
        public string Genero { get; set; }
        public int IdAutor { get; set; }
        public string Autor { get; set; }
    }
}
