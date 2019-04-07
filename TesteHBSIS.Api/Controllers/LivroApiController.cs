using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TesteHBSIS.Api.Controllers.Base;
using TesteHBSIS.Domain.Argumentos;
using TesteHBSIS.Domain.Argumentos.Livro;
using TesteHBSIS.Domain.Interfaces.Servicos;
using TesteHBSIS.Infra.Transacao;

namespace TesteHBSIS.Api.Controllers
{
    [RoutePrefix("api/livro")]
    public class LivroApiController : ControllerBase
    {
        private readonly IServicoLivro _servicoLivro;

        public LivroApiController(IUnitOfWork unitOfWork, IServicoLivro servicoLivro) : base(unitOfWork)
        {
            _servicoLivro = servicoLivro;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarLivroRequest request)
        {
            try
            {
                var response = _servicoLivro.AdicionarLivro(request);

                return await ResponseAsync(response, _servicoLivro);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Alterar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Alterar(AlterarLivroRequest request)
        {
            try
            {
                var response = _servicoLivro.AlterarLivro(request);

                return await ResponseAsync(response, _servicoLivro);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _servicoLivro.ListarLivro();

                return await ResponseAsync(response, _servicoLivro);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Listar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Listar(FiltroConsultaRequest filtro)
        {
            try
            {
                var response = _servicoLivro.ListarLivro(filtro);

                return await ResponseAsync(response, _servicoLivro);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("ObterPorId")]
        [HttpGet]
        public async Task<HttpResponseMessage> ObterPorId(int id)
        {
            try
            {
                var response = (LivroResponse)_servicoLivro.ObterLivroPorId(id);

                return await ResponseAsync(response, _servicoLivro);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Remover")]
        [HttpGet]
        public async Task<HttpResponseMessage> Remover(int id)
        {
            try
            {
                _servicoLivro.ExcluirLivro(id);

                return await ResponseAsync("Livro removido", _servicoLivro);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
    }
}