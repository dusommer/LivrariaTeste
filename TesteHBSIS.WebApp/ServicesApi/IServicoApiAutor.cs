using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteHBSIS.WebApp.Models;
using TesteHBSIS.WebApp.Models.Args;

namespace TesteHBSIS.WebApp.ServicesApi
{
    public interface IServicoApiAutor
    {
        List<AutorResponse> ObterAutor();
    }
}