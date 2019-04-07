using prmToolkit.NotificationPattern;
using System.Collections.Generic;
using System.Linq;
using TesteHBSIS.Domain.Argumentos.Genero;
using TesteHBSIS.Domain.Interfaces.Repositorios;
using TesteHBSIS.Domain.Interfaces.Servicos;

namespace TesteHBSIS.Domain.Servicos
{
    public class ServicoGenero : Notifiable, IServicoGenero
    {
        private readonly IRepositorioGenero _repositorioGenero;
        public ServicoGenero()
        {

        }

        public ServicoGenero(IRepositorioGenero repositorioGenero)
        {
            _repositorioGenero = repositorioGenero;
        }

        public IEnumerable<GeneroResponse> ListarGenero()
        {
            return _repositorioGenero.Listar().ToList().Select(genero => (GeneroResponse)genero).ToList();
        }
    }
}
