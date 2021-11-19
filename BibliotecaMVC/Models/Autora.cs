using System.Collections.Generic;

namespace BibliotecaMVC
{
    public class Autora
    {
        private string _nome { get; set; }
        
        public Autora()
        {

        }

        public Autora(string nome)
        {
            Nome = nome;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = $"{value} perfeita"; }
        }

        public List<Autora> Model => new List<Autora>() { 
            this,
            new Autora("Djamila")
        };
    }
}
