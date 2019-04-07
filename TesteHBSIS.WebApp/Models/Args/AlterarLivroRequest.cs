using System;

namespace TesteHBSIS.WebApp.Models.Args
{
    public class AlterarLivroRequest
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public int Edicao { get; set; }
        public int IdGenero { get; set; }
        public int IdAutor { get; set; }

        public static explicit operator AlterarLivroRequest(LivroResponse livro)
        {
            return new AlterarLivroRequest()
            {
                Id = livro.Id,
                Titulo = livro.Titulo,
                Preco = livro.Preco,
                Estoque = livro.Estoque,
                Edicao = livro.Edicao,
                IdGenero = livro.IdGenero,
                IdAutor = livro.IdAutor,
            };
        }
    }
}
