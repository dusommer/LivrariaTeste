using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TesteHBSIS.Domain.Entidades.Base;
using TesteHBSIS.Domain.Interfaces.Repositorios.Base;

namespace TesteHBSIS.Infra.Persistencia.Repositorios.Base
{
    public class RepositorioBase<TEntidade, TId> : IRepositorioBase<TEntidade, TId>
        where TEntidade : EntidadeBase
        where TId : struct
    {
        private readonly DbContext _contexto;

        public RepositorioBase(DbContext contexto)
        {
            _contexto = contexto;
        }

        public TEntidade Adicionar(TEntidade entidade)
        {
            return _contexto.Set<TEntidade>().Add(entidade);
        }

        public TEntidade Editar(TEntidade entidade)
        {
            _contexto.Entry(entidade).State = EntityState.Modified;

            return entidade;
        }

        public void Remover(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Remove(entidade);
        }

        public IQueryable<TEntidade> Listar()
        {
            IQueryable<TEntidade> query = _contexto.Set<TEntidade>();

            return query;
        }

        public TEntidade ObterPorId(TId id)
        {
            return _contexto.Set<TEntidade>().Find(id);
        }
    }
}
