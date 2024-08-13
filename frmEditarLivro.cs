using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaBiliotecaVirtual.Classes
{
    public partial class frmEditarLivro : Form
    {
        int livroIdSelecionado;
        public frmEditarLivro(int livroId)
        {
            InitializeComponent();           
            livroIdSelecionado = livroId;
            PegarDadosDoLivro();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        void PegarDadosDoLivro()
        {           
            Livro livro = new Livro();
            livro = livro.GetLivros(livroIdSelecionado);

            txtTitulo.Text = livro.Titulo;
            txtIsbn.Text = livro.ISBN;
            txtEditoraNome.Text = livro.EditoraNome;
            txtAutorNome.Text = livro.AutorNome;
            txtCategoriaNome.Text = livro.CategoriaNome;
        }
    }
}
