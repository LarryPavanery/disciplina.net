using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebo.Model
{
    class Editora
    {
        public int EditoraID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public ICollection<Livro> Livros { get; set; }
    }
}
