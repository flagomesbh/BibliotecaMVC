using System;
using System.Net.Http;
using System.Net.Http.Json;

namespace BibliotecaMVC.Service
{
    public class BibliotecaService
    {
        private const string url = "https://itunes.apple.com/search";

        public Response BuscaLivro(string textoPesquisa)
        {
            Response retorno = null;
            string parametros = $"?term={textoPesquisa}&entity=ibook";
            var newUrl = $"{url}{parametros}";

            HttpClient clienteApi = new()
            {
                BaseAddress = new Uri(url)
            };

            var resultado = clienteApi.GetAsync(newUrl).Result;
            if (resultado.IsSuccessStatusCode)
            {
                retorno = resultado.Content.ReadFromJsonAsync<Response>().Result;
            }
            
            clienteApi.Dispose();
            return retorno;
        }
    }
}
