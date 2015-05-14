using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebo.Model
{
    class Livro
    {
        public int LivroID { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public Editora Editora { get; set; }
    }
}
