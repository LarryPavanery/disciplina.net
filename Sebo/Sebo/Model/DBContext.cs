using Sebo.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebo.Model
{
    class DBContext : DbContext
    {
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Livro> Livros { get; set; }

        /// <summary>
        /// Construtor da classe que chama a classe pai passando o nome da base a ser criada.
        /// </summary>
        public DBContext() : base("Sebo")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DBContext, Configuration>());
        }

        //Criar duas classes para representar as seguintes entidades: livro e editora
        //Criar a seguinte classe para representar a entidade gerenciadora do banco de dados: DBContext, que herda de DbContext
    }
}
