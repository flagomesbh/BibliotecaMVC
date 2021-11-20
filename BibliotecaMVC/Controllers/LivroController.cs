using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class LivroController : Controller
    {
        List<Livro> listaDeLivros = null;
        
        public IActionResult Livro(string textoPesquisa)
        {            
            listaDeLivros = new Livro().GetLivros(textoPesquisa);
            return View(listaDeLivros);
        }

        public IActionResult LivroDetail(int id)
        {
            var livro = new Livro().GetLivroPeloId(id);
            return View(livro);
        }
    }
}
