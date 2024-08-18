using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaBiliotecaVirtual.Classes;
using MySqlX.XDevAPI.Relational;

namespace MinhaBiliotecaVirtual
{
    public partial class frmNovoLivro : Form
    {
        public frmNovoLivro()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SalvarLivroData();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        void SalvarLivroData()
        {
            Livro livro = new Livro();

            livro.Titulo = txtTitulo.Text;
            livro.ISBN = txtIsbn.Text;
            livro.EditoraNome = txtEditoraNome.Text;
            livro.AutorNome = txtAutorNome.Text;

            livro.CategoriaNome = cbCategoria.SelectedItem.ToString();//txtCategoriaNome.Text;

            livro.NovoLivro(livro);

        }
    }
}
