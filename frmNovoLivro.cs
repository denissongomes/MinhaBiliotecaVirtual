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
            bool validacaoDosCampos = true;       
            foreach (Control control in this.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (control is TextBox || control is ComboBox)
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
                    SalvarLivroData();
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
              
            }


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
