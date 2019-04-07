using System;
using TesteHBSIS.Domain.Interfaces.Argumentos;

namespace TesteHBSIS.Domain.Argumentos.Livro
{
    public class AlterarLivroResponse : IResponse
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public int Edicao { get; set; }
        public int IdGenero { get; set; }

        public string Message { get; set; }

        public static explicit operator AlterarLivroResponse(Entidades.Livro livro)
        {
            return new AlterarLivroResponse()
            {
                Id = livro.Id,
                Titulo = livro.Titulo,
                Preco = livro.Preco,
                Estoque = livro.Estoque,
                Edicao = livro.Edicao,
                IdGenero = livro.Genero.Id,
                Message = "Livro adicionado com sucesso."
            };
        }
    }
}
