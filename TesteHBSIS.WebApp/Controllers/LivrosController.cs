using System.Collections.Generic;
using System.Web.Mvc;
using TesteHBSIS.WebApp.Models.Args;
using TesteHBSIS.WebApp.ServicesApi;
using TesteHBSIS.WebApp.Utils;

namespace TesteHBSIS.WebApp.Controllers
{
    public class LivrosController : Controller
    {
        private readonly IServicoApiLivro _servicoLivro;
        private readonly IServicoApiAutor _servicoAutor;
        private readonly IServicoApiGenero _servicoGenero;

        public LivrosController(IServicoApiLivro servicoLivro, IServicoApiAutor servicoAutor, IServicoApiGenero servicoGenero)
        {
            _servicoLivro = servicoLivro;
            _servicoAutor = servicoAutor;
            _servicoGenero = servicoGenero;
        }

        [HttpGet]
        public ActionResult Consulta()
        {
            ObterViewBag();
            ViewBag.Consulta = _servicoLivro.ObterLivros();
            return View(new FIltroConsultaRequest());
        }

        public ActionResult Cadastra()
        {
            AdicionarLivroRequest livro = new AdicionarLivroRequest();
            ObterViewBag();

            return View(livro);
        }

        [HttpPost]
        public ActionResult Cadastra(AdicionarLivroRequest adicionarLivro)
        {
            AdicionarLivroResponse response = null;

            try
            {
                response = _servicoLivro.AdicionarLivro(adicionarLivro);

                if (response != null)
                {
                    return RedirectToAction("Consulta");
                }
            }
            catch (System.Exception ex)
            {
                ControllerUtil.SetarErroModelState(ex.Message, ModelState);
            }

            ObterViewBag();

            return View(adicionarLivro);
        }

        public ActionResult Edita(int id)
        {
            var livro = (AlterarLivroRequest)_servicoLivro.ObterLivroPorId(id);

            ObterViewBag();

            return View(livro);
        }

        [HttpPost]
        public ActionResult Edita(AlterarLivroRequest alterarLivro)
        {
            AlterarLivroResponse response = null;

            try
            {
                response = _servicoLivro.AlterarLivro(alterarLivro);

                if (response != null)
                {
                    return RedirectToAction("Consulta");
                }
            }
            catch (System.Exception ex)
            {
                ControllerUtil.SetarErroModelState(ex.Message, ModelState);
            }

            ObterViewBag();

            return View(alterarLivro);
        }

        public ActionResult Deleta(int? id)
        {
            var response = _servicoLivro.ObterLivroPorId(id.Value);

            return View(response);
        }

        [HttpPost, ActionName("Deleta")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletaConfirmado(int id)
        {
            _servicoLivro.Remover(id);
            return RedirectToAction("Consulta");
        }

        [HttpPost]
        public ActionResult Filtrar(FIltroConsultaRequest filtro)
        {
            List<LivroResponse> retorno = new List<LivroResponse>();

            if (ModelState.IsValid)
            {
                retorno = _servicoLivro.ObterLivros(filtro);
            }

            return PartialView("PartialLivros", retorno);
        }
        
        private void ObterViewBag()
        {
            ViewBag.Autores = _servicoAutor.ObterAutor();
            ViewBag.Generos = _servicoGenero.ObterGenero();
        }
    }
}