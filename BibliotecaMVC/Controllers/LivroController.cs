using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Livro()
        {
            //var listaDeLivros = new Livro("Quem tem medo do feminismo negro", "", 20.00, new Autora("Djamila"), new string[] { });
            // var listaDeLivros = new List<Livro>();

            // var autora = new Autora("Djamila");

            // var livroUm = new Livro();
            // livroUm.Titulo = "Titulo 1";
            // livroUm.Autora = autora;
            // livroUm.Preco = 20.00;
            // listaDeLivros.Add(livroUm);

            // var livroDois = new Livro();
            // livroDois.Titulo = "Titulo 2";
            // livroDois.Autora = autora;
            // livroDois.Preco = 15.40;
            // listaDeLivros.Add(livroDois);
            
            var listaDeLivros = new Livro().GetLivros();
            return View(listaDeLivros);
        }
    }
}
