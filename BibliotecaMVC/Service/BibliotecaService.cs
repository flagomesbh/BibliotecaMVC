using System;
using System.Net.Http;
using System.Net.Http.Json;

namespace BibliotecaMVC.Service
{
    public class BibliotecaService
    {
        private const string url = "https://itunes.apple.com/";

        public Response BuscaLivro(string textoPesquisa)
        {
            Response retorno = null;
            string parametros = $"search?term={textoPesquisa}&entity=ibook";
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

        public Response BuscaLivroPeloId(int id)
        {
            Response retorno = null;
            string parametros = $"lookup?id={id}";
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
