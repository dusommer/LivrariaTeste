using System;
using TesteHBSIS.Domain.Entidades;

namespace TesteHBSIS.Domain.Argumentos.Livro
{
    public class LivroResponse
    {
        public static explicit operator LivroResponse(Entidades.Livro livro)
        {
            return new LivroResponse()
            {
                Id = livro.Id,
                Titulo = livro.Titulo,
                Preco = livro.Preco,
                Estoque = livro.Estoque,
                Edicao = livro.Edicao,
                IdGenero = livro.Genero.Id,
                Genero = livro.Genero.Nome,
                IdAutor = livro.Autor.Id,
                Autor = livro.Autor.Nome
            };
        }

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
