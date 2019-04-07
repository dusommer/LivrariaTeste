using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using TesteHBSIS.Domain.Entidades.Base;

namespace TesteHBSIS.Domain.Entidades
{
    public class Genero : EntidadeBase
    {
        protected Genero()
        {
            Livros = new HashSet<Livro>();
        }

        public Genero(string nome)
        {
            Nome = nome;
            Livros = new HashSet<Livro>();
            ValidarEntidade();
        }

        public override void ValidarEntidade()
        {
            new AddNotifications<Genero>(this)
                .IfNullOrEmpty(x => x.Nome, "O nome é obrigatório.");
        }

        public string Nome { get; private set; }
        public int IdLivro { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
