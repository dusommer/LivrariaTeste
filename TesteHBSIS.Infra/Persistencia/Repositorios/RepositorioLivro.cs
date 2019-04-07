using System;
using TesteHBSIS.Domain.Entidades;
using TesteHBSIS.Domain.Interfaces.Repositorios;
using TesteHBSIS.Infra.Persistencia.Repositorios.Base;

namespace TesteHBSIS.Infra.Persistencia.Repositorios
{
    public class RepositorioLivro : RepositorioBase<Livro, int>, IRepositorioLivro
    {
        protected readonly HBSISContexto _contexto;

        public RepositorioLivro(HBSISContexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
