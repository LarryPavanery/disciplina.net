using Sebo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sebo
{
    public partial class GerenciadorEditora : Form
    {
        public GerenciadorEditora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new DBContext()) 
            {
                Editora editora = new Editora
                {
                    Nome = "Editora Aleph",
                    Email = "rh@editoraaleph.com.br"
                };

                context.Editoras.Add(editora);
                context.SaveChanges();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new DBContext())
            {

            }
        }

        private void GerenciadorEditora_Load(object sender, EventArgs e)
        {

        }
    }
}
