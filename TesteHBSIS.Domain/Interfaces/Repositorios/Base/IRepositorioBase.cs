using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TesteHBSIS.Domain.Interfaces.Repositorios.Base
{
    public interface IRepositorioBase<TEntidade, TId>
       where TEntidade : class
       where TId : struct
    {
        TEntidade Adicionar(TEntidade entidade);

        TEntidade Editar(TEntidade entidade);

        void Remover(TEntidade entidade);

        IQueryable<TEntidade> Listar();

        TEntidade ObterPorId(TId id);
    }
}
