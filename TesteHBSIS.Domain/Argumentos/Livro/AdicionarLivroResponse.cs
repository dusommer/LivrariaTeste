using System;
using TesteHBSIS.Domain.Interfaces.Argumentos;

namespace TesteHBSIS.Domain.Argumentos.Livro
{
    public class AdicionarLivroResponse : IResponse
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public static explicit operator AdicionarLivroResponse(Entidades.Livro livro)
        {
            return new AdicionarLivroResponse()
            {
                Id = livro.Id,
                Message = "Livro adicionado com sucesso."
            };
        }
    }
}
