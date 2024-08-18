using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            bool validacaoDosCampos = true;
            foreach (Control control in this.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
               if (control is System.Windows.Forms.TextBox || control is System.Windows.Forms.ComboBox)
               {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        validacaoDosCampos = false;
                        control.BackColor = Color.IndianRed;
                        control.Focus();
                        MessageBox.Show("Um ou mais campos não foram preenchidos, por favor tente novamente!", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else if (cbCategoria.SelectedItem == null)
                    {
                        validacaoDosCampos = false;
                        cbCategoria.BackColor = Color.IndianRed;
                        cbCategoria.Focus();
                        MessageBox.Show("O campo 'Categoria' não está selecionado, por favor tente novamente!", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

              }
            }
            if (validacaoDosCampos)
            {
                try
                {
                    //salvar
                    EditarDadosDoLivro();
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
           
        }

        void PegarDadosDoLivro()
        {           
            Livro livro = new Livro();
            livro = livro.GetLivros(livroIdSelecionado);

            txtTitulo.Text = livro.Titulo;
            txtIsbn.Text = livro.ISBN;
            txtEditoraNome.Text = livro.EditoraNome;
            txtAutorNome.Text = livro.AutorNome;
            // txtCategoriaNome.Text = livro.CategoriaNome;
            cbCategoria.SelectedItem = livro.CategoriaNome;
            cbCategoria.GetItemText(cbCategoria.SelectedItem);
    
        }

        void EditarDadosDoLivro()
        {
            Livro livro = new Livro();
            livro.LivroId = livroIdSelecionado;
            livro.Titulo = txtTitulo.Text;
            livro.ISBN = txtIsbn.Text;
            livro.EditoraNome = txtEditoraNome.Text;
            livro.AutorNome = txtAutorNome.Text;
            // livro.CategoriaNome = txtCategoriaNome.Text;
            livro.CategoriaNome = cbCategoria.GetItemText(cbCategoria.SelectedItem);
            livro.EditarLivro(livro);
        }
    }
}
