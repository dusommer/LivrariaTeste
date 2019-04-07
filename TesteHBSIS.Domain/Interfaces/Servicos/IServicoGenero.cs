using System.Collections.Generic;
using TesteHBSIS.Domain.Argumentos.Genero;
using TesteHBSIS.Domain.Interfaces.Servicos.Base;

namespace TesteHBSIS.Domain.Interfaces.Servicos
{
    public interface IServicoGenero : IServicoBase
    {
        IEnumerable<GeneroResponse> ListarGenero();
    }
}
