using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TesteHBSIS.Api.Controllers.Base;
using TesteHBSIS.Domain.Interfaces.Servicos;
using TesteHBSIS.Infra.Transacao;

namespace TesteHBSIS.Api.Controllers
{
    [RoutePrefix("api/autor")]
    public class AutorApiController : ControllerBase
    {
        private readonly IServicoAutor _servicoAutor;

        public AutorApiController(IUnitOfWork unitOfWork, IServicoAutor servicoAutor) : base(unitOfWork)
        {
            _servicoAutor = servicoAutor;
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _servicoAutor.ListarAutor();

                return await ResponseAsync(response, _servicoAutor);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}