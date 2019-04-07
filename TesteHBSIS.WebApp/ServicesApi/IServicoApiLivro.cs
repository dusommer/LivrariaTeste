using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteHBSIS.WebApp.Models;
using TesteHBSIS.WebApp.Models.Args;

namespace TesteHBSIS.WebApp.ServicesApi
{
    public interface IServicoApiLivro
    {
        List<LivroResponse> ObterLivros(FIltroConsultaRequest filtro = null);
        AdicionarLivroResponse AdicionarLivro(AdicionarLivroRequest request);
        LivroResponse ObterLivroPorId(int id);
        void Remover(int id);
        AlterarLivroResponse AlterarLivro(AlterarLivroRequest request);
    }
}