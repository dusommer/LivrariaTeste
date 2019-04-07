using System;
using TesteHBSIS.Domain.Entidades;
using TesteHBSIS.Domain.Interfaces.Repositorios;
using TesteHBSIS.Infra.Persistencia.Repositorios.Base;

namespace TesteHBSIS.Infra.Persistencia.Repositorios
{
    public class RepositorioGenero : RepositorioBase<Genero, int>, IRepositorioGenero
    {
        protected readonly HBSISContexto _contexto;

        public RepositorioGenero(HBSISContexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
