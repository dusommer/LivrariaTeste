using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteHBSIS.Domain.Argumentos.Autor;
using TesteHBSIS.Domain.Interfaces.Repositorios;
using TesteHBSIS.Domain.Interfaces.Servicos;

namespace TesteHBSIS.Domain.Servicos
{
    public class ServicoAutor : Notifiable, IServicoAutor
    {
        private readonly IRepositorioAutor _repositorioAutor;

        public ServicoAutor()
        {

        }

        public ServicoAutor(IRepositorioAutor repositorioAutor)
        {
            _repositorioAutor = repositorioAutor;
        }

        public IEnumerable<AutorResponse> ListarAutor()
        {
            return _repositorioAutor.Listar().ToList().Select(autor => (AutorResponse)autor).ToList();
        }
    }
}
