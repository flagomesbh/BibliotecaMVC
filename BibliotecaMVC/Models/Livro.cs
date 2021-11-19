

using System.Collections.Generic;
using BibliotecaMVC.Service;

namespace BibliotecaMVC
{
    public class Livro
    {
        private string _titulo { get; set; }
        private string _descricao { get; set; }
        private double _preco { get; set; }
        private Autora _autora { get; set; }
        private string[] _genero { get; set; }
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        public string Descricao 
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        public Autora Autora
        {
            get { return _autora; }
            set { _autora = value; }
        }

        public string[] Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public Livro()
        { }
        
        public Livro(string titulo, string descricao, double preco, Autora autora, string[] genero)
        {
            _titulo = titulo;
            _descricao = descricao;
            _preco = preco;
            _autora = autora;
            _genero = genero;
        }

        public Livro Cadastrar()
        {
            return this;
        }

        public List<Livro> ListaDeLivros => new List<Livro>()
        {
            this,
            new Livro("Lugar de Fala", "", 18.90, new Autora("DJamila"), new string[]{})
        };

        public List<Livro> GetLivros()
        {
            var servico = new BibliotecaService();
            var resposta = servico.BuscaLivro();

            var listaDeLivro = new List<Livro>();
            foreach (var item in resposta.Results)
            {
                var livro = new Livro()
                {
                    Titulo = item.TrackName,
                    Autora = new Autora(item.ArtistName),
                    Preco = item.Price,
                    Genero = item.Genres,
                    Descricao = item.Description
                };

                listaDeLivro.Add(livro);
            }
             
            return listaDeLivro;
        }
    }
}
