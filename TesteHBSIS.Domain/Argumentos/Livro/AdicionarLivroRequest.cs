using System;
using TesteHBSIS.Domain.Entidades;
using TesteHBSIS.Domain.Interfaces.Argumentos;

namespace TesteHBSIS.Domain.Argumentos.Livro
{
    public class AdicionarLivroRequest : IRequest
    {
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public int Edicao { get; set; }
        public int IdGenero { get; set; }
        public int IdAutor { get; set; }
    }
}
