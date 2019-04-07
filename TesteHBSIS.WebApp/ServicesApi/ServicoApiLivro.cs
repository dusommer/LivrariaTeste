using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using TesteHBSIS.WebApp.Models;
using TesteHBSIS.WebApp.Models.Args;
using TesteHBSIS.WebApp.Utils;

namespace TesteHBSIS.WebApp.ServicesApi
{
    public class ServicoApiLivro : IServicoApiLivro
    {
        public AdicionarLivroResponse AdicionarLivro(AdicionarLivroRequest request)
        {
            byte[] objBytes = Encoding.UTF8.GetBytes(request.ToString());
            var response = JsonConvert.DeserializeObject<AdicionarLivroResponse>(ServicoApiUtil.ApiResponse("api/livro/Adicionar", "POST", request));

            return new AdicionarLivroResponse();
        }

        public AlterarLivroResponse AlterarLivro(AlterarLivroRequest request)
        {
            byte[] objBytes = Encoding.UTF8.GetBytes(request.ToString());
            var response = JsonConvert.DeserializeObject<AlterarLivroResponse>(ServicoApiUtil.ApiResponse("api/livro/Alterar", "POST", request));

            return new AlterarLivroResponse();
        }

        public LivroResponse ObterLivroPorId(int id)
        {
            return JsonConvert.DeserializeObject<LivroResponse>(ServicoApiUtil.ApiResponse("api/livro/ObterPorId?id=" + id, "GET"));
        }

        public List<LivroResponse> ObterLivros(FIltroConsultaRequest filtro = null)
        {
            if (filtro != null)
            {
                return JsonConvert.DeserializeObject<List<LivroResponse>>(ServicoApiUtil.ApiResponse("api/livro/Listar", "POST", filtro));
            }
            else
            {
                return JsonConvert.DeserializeObject<List<LivroResponse>>(ServicoApiUtil.ApiResponse("api/livro/Listar", "GET"));
            }
        }

        public void Remover(int id)
        {
            ServicoApiUtil.ApiResponse("api/livro/Remover?id=" + id, "GET");
        }
    }
}