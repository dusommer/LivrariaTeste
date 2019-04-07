using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using TesteHBSIS.Domain.Interfaces.Servicos.Base;
using TesteHBSIS.Infra.Transacao;

namespace TesteHBSIS.Api.Controllers.Base
{
    public class ControllerBase : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private IServicoBase _servicoBase;

        public ControllerBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<HttpResponseMessage> ResponseAsync(object result, IServicoBase serviceBase)
        {
            _servicoBase = serviceBase;

            if (!serviceBase.Notifications.Any())
            {
                try
                {
                    _unitOfWork.Commit();

                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.Conflict, $"Erro interno: {ex.Message}");
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.PreconditionFailed, serviceBase.Notifications );
            }
        }

        public async Task<HttpResponseMessage> ResponseExceptionAsync(Exception ex)
        {
            return Request.CreateResponse(HttpStatusCode.InternalServerError, new { errors = ex.Message, exception = ex.ToString() });
        }

        protected override void Dispose(bool disposing)
        {
            if (_servicoBase != null)
            {
                _servicoBase.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}