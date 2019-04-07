using Newtonsoft.Json;
using prmToolkit.NotificationPattern;
using System.Collections.Generic;
using System.Web.Mvc;

namespace TesteHBSIS.WebApp.Utils
{
    public static class ControllerUtil
    {
        public static void SetarErroModelState(string mensagem, ModelStateDictionary modelState)
        {
            if (mensagem.Contains("property"))
            {
                var erros = JsonConvert.DeserializeObject<IReadOnlyCollection<Notification>>(mensagem);
                foreach (var item in erros)
                {
                    modelState.AddModelError(item.Property.Equals("Livro") ? "" : item.Property, item.Message);
                }
            }
            else
            {
                modelState.AddModelError("", mensagem);
            }
        }
    }
}