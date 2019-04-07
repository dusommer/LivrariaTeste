using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteHBSIS.Infra.Persistencia;

namespace TesteHBSIS.Infra.Transacao
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HBSISContexto _contexto;

        public UnitOfWork(HBSISContexto contexto)
        {
            _contexto = contexto;
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }
    }
}
