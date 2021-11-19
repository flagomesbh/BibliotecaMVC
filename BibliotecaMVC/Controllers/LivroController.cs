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

        public IActionResult LivroDetail(int Id)
        {
            var livro = listaDeLivros.Find(livro => livro.Id == Id);
            return View(livro);
        }
    }
}
