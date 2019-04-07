using System;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;

namespace TesteHBSIS.WebApp.Utils
{
    public static class ServicoApiUtil
    {
        public static string ApiResponse(string metodo, string tipoRequest, Object request = null)
        {
            string ApiBaseUrl = "http://localhost:61032/";
            string response = "";
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiBaseUrl + metodo);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = tipoRequest;
                httpWebRequest.UseDefaultCredentials = true;
                if (request != null)
                {
                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        string json = new JavaScriptSerializer().Serialize(request);

                        streamWriter.Write(json);
                    }
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    response = streamReader.ReadToEnd();
                }
            }
            catch (WebException e)
            {
                using (var stream = e.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    throw new Exception(reader.ReadToEnd());
                }
            }
            return response;
        }
    }
}
