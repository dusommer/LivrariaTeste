using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TesteHBSIS.Api.Controllers.Base;
using TesteHBSIS.Domain.Interfaces.Servicos;
using TesteHBSIS.Infra.Transacao;

namespace TesteHBSIS.Api.Controllers
{
    [RoutePrefix("api/genero")]
    public class GeneroApiController : ControllerBase
    {
        private readonly IServicoGenero _servicoGenero;

        public GeneroApiController(IUnitOfWork unitOfWork, IServicoGenero servicoGenero) : base(unitOfWork)
        {
            _servicoGenero = servicoGenero;
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _servicoGenero.ListarGenero();

                return await ResponseAsync(response, _servicoGenero);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}