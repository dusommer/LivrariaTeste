using Newtonsoft.Json;
using System.Collections.Generic;
using TesteHBSIS.WebApp.Models.Args;
using TesteHBSIS.WebApp.Utils;

namespace TesteHBSIS.WebApp.ServicesApi
{
    public class ServicoApiGenero : IServicoApiGenero
    {
        public List<GeneroResponse> ObterGenero()
        {
            return JsonConvert.DeserializeObject<List<GeneroResponse>>(ServicoApiUtil.ApiResponse("api/genero/Listar", "GET"));
        }
    }
}