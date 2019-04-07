using Newtonsoft.Json;
using System.Collections.Generic;
using TesteHBSIS.WebApp.Models.Args;
using TesteHBSIS.WebApp.Utils;

namespace TesteHBSIS.WebApp.ServicesApi
{
    public class ServicoApiAutor : IServicoApiAutor
    {
        public List<AutorResponse> ObterAutor()
        {
            return JsonConvert.DeserializeObject<List<AutorResponse>>(ServicoApiUtil.ApiResponse("api/autor/Listar", "GET"));
        }
    }
}