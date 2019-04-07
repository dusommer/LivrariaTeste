using System;
using TesteHBSIS.Domain.Entidades;
using TesteHBSIS.Domain.Interfaces.Repositorios;
using TesteHBSIS.Infra.Persistencia.Repositorios.Base;

namespace TesteHBSIS.Infra.Persistencia.Repositorios
{
    public class RepositorioAutor : RepositorioBase<Autor, int>, IRepositorioAutor
    {
        protected readonly HBSISContexto _contexto;

        public RepositorioAutor(HBSISContexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
