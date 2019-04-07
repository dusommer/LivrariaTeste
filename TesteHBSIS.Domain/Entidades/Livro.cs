using prmToolkit.NotificationPattern;
using TesteHBSIS.Domain.Argumentos.Livro;
using TesteHBSIS.Domain.Entidades.Base;

namespace TesteHBSIS.Domain.Entidades
{
    public class Livro : EntidadeBase
    {
        protected Livro()
        {

        }

        public Livro(string titulo, decimal preco, int estoque, int edicao, int idGenero, int idAutor)
        {
            Titulo = titulo;
            Preco = preco;
            Estoque = estoque;
            Edicao = Edicao;
            IdGenero = idGenero;
            IdAutor = idAutor;
            ValidarEntidade();
        }

        public override void ValidarEntidade()
        {
            new AddNotifications<Livro>(this)
                .IfNullOrEmpty(x => x.Titulo, "O nome é obrigatório.")
                .IfAreEquals(x => x.Preco, 0, "O preço é obrigatório e maior que 0.")
                .IfAreEquals(x => x.IdGenero, 0, "O genero é obrigatório.")
                .IfAreEquals(x => x.IdAutor, 0, "O autor é obrigatório.");
        }

        public void AlterarLivro(AlterarLivroRequest request)
        {
            Titulo = request.Titulo;
            Preco = request.Preco;
            Estoque = request.Estoque;
            Edicao = request.Edicao;
            IdAutor = request.IdAutor;
            IdGenero = request.IdGenero;
            ValidarEntidade();
        }

        public string Titulo { get; private set; }
        public decimal Preco { get; private set; }
        public int Estoque { get; private set; }
        public int Edicao { get; private set; }
        public int IdGenero { get; private set; }
        public int IdAutor { get; private set; }

        public virtual Genero Genero { get; set; }
        public virtual Autor Autor { get; set; }
    }
}
