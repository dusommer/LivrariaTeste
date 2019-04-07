using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteHBSIS.Domain.Argumentos.Autor;
using TesteHBSIS.Domain.Interfaces.Servicos.Base;

namespace TesteHBSIS.Domain.Interfaces.Servicos
{
    public interface IServicoAutor : IServicoBase
    {
        IEnumerable<AutorResponse> ListarAutor();
    }
}
