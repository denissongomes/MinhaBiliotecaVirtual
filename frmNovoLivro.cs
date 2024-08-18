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
        // Construtor do formulário frmNovoLivro
        public frmNovoLivro()
        {
            InitializeComponent(); // Inicializa os componentes do formulário, configurados no designer.
        }

        // Evento acionado quando o botão "OK" é clicado
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool validacaoDosCampos = true; // Flag para rastrear a validação dos campos.

            // Validação de todos os controles (TextBox e ComboBox) no formulário
            foreach (Control control in this.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (control is TextBox || control is ComboBox)
                {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        // Se algum campo de texto estiver vazio ou só com espaços em branco
                        validacaoDosCampos = false;
                        control.BackColor = Color.IndianRed; // Destaca o campo inválido com cor de fundo vermelha.
                        control.Focus(); // Coloca o foco no campo inválido.
                        MessageBox.Show("Um ou mais campos não foram preenchidos, por favor tente novamente!", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break; // Interrompe a validação adicional.
                    }
                    else if (cbCategoria.SelectedItem == null)
                    {
                        // Se a ComboBox "Categoria" não tiver um item selecionado
                        validacaoDosCampos = false;
                        cbCategoria.BackColor = Color.IndianRed; // Destaca a ComboBox inválida com cor de fundo vermelha.
                        cbCategoria.Focus(); // Coloca o foco na ComboBox inválida.
                        MessageBox.Show("O campo 'Categoria' não está selecionado, por favor tente novamente!", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break; // Interrompe a validação adicional.
                    }
                }
            }

            if (validacaoDosCampos)
            {
                try
                {
                    // Se a validação for bem-sucedida, tenta salvar os dados do livro.
                    SalvarLivroData(); // Chama o método para salvar o novo livro no banco de dados.
                    this.Close(); // Fecha o formulário após salvar com sucesso.
                }
                catch (Exception ex)
                {
                    // Em caso de exceção, exibe a mensagem de erro.
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Evento acionado quando o botão "Cancelar" é clicado
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário sem salvar.
        }

        // Método para salvar os dados do novo livro
        void SalvarLivroData()
        {
            Livro livro = new Livro(); // Cria uma nova instância da classe Livro.

            // Atribui os valores dos campos do formulário às propriedades do objeto livro.
            livro.Titulo = txtTitulo.Text;
            livro.ISBN = txtIsbn.Text;
            livro.EditoraNome = txtEditoraNome.Text;
            livro.AutorNome = txtAutorNome.Text;
            livro.CategoriaNome = cbCategoria.SelectedItem.ToString(); // Converte o item selecionado na ComboBox para string.

            livro.NovoLivro(livro); // Chama o método para salvar o novo livro no banco de dados.
        }
    }
}
