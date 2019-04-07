using prmToolkit.NotificationPattern;
using System.Collections.Generic;
using TesteHBSIS.Domain.Entidades.Base;

namespace TesteHBSIS.Domain.Entidades
{
    public class Autor : EntidadeBase
    {
        protected Autor()
        {
            Livros = new HashSet<Livro>();
        }

        public Autor(string nome)
        {
            Nome = nome;
            Livros = new HashSet<Livro>();
            ValidarEntidade();
        }

        public override void ValidarEntidade()
        {
            new AddNotifications<Autor>(this)
                .IfNullOrEmpty(x => x.Nome, "O nome é obrigatório.");
        }

        public string Nome { get; private set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
