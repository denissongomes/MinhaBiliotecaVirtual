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
        int livroIdSelecionado; // Armazena o ID do livro a ser editado

        // Construtor do formulário frmEditarLivro, recebe o ID do livro a ser editado
        public frmEditarLivro(int livroId)
        {
            InitializeComponent(); // Inicializa os componentes do formulário, configurados no designer
            livroIdSelecionado = livroId; // Armazena o ID do livro passado como argumento
            PegarDadosDoLivro(); // Preenche os campos do formulário com os dados do livro a ser editado
        }

        // Evento acionado quando o botão "OK" é clicado
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool validacaoDosCampos = true; // Flag para rastrear a validação dos campos

            // Validação de todos os controles (TextBox e ComboBox) no formulário
            foreach (Control control in this.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (control is TextBox || control is ComboBox)
                {
                    if (string.IsNullOrWhiteSpace(control.Text))
                    {
                        // Se algum campo de texto estiver vazio ou só com espaços em branco
                        validacaoDosCampos = false;
                        control.BackColor = Color.IndianRed; // Destaca o campo inválido com cor de fundo vermelha
                        control.Focus(); // Coloca o foco no campo inválido
                        MessageBox.Show("Um ou mais campos não foram preenchidos, por favor tente novamente!", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break; // Interrompe a validação adicional
                    }
                    else if (cbCategoria.SelectedItem == null)
                    {
                        // Se a ComboBox "Categoria" não tiver um item selecionado
                        validacaoDosCampos = false;
                        cbCategoria.BackColor = Color.IndianRed; // Destaca a ComboBox inválida com cor de fundo vermelha
                        cbCategoria.Focus(); // Coloca o foco na ComboBox inválida
                        MessageBox.Show("O campo 'Categoria' não está selecionado, por favor tente novamente!", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break; // Interrompe a validação adicional
                    }
                }
            }

            if (validacaoDosCampos)
            {
                try
                {
                    // Se a validação for bem-sucedida, tenta salvar as alterações do livro
                    EditarDadosDoLivro(); // Chama o método para salvar as alterações do livro no banco de dados
                    this.Close(); // Fecha o formulário após salvar com sucesso
                }
                catch (Exception ex)
                {
                    // Em caso de exceção, exibe a mensagem de erro
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Método para pegar os dados do livro a ser editado e preencher os campos do formulário
        void PegarDadosDoLivro()
        {
            Livro livro = new Livro(); // Cria uma nova instância da classe Livro
            livro = livro.GetLivros(livroIdSelecionado); // Obtém os dados do livro com o ID fornecido

            // Preenche os campos do formulário com os dados do livro
            txtTitulo.Text = livro.Titulo;
            txtIsbn.Text = livro.ISBN;
            txtEditoraNome.Text = livro.EditoraNome;
            txtAutorNome.Text = livro.AutorNome;
            cbCategoria.SelectedItem = livro.CategoriaNome; // Define o item selecionado na ComboBox como a categoria do livro
            cbCategoria.GetItemText(cbCategoria.SelectedItem); // Converte o item selecionado na ComboBox para string
        }

        // Método para salvar as alterações feitas nos dados do livro
        void EditarDadosDoLivro()
        {
            Livro livro = new Livro(); // Cria uma nova instância da classe Livro

            // Atribui os valores dos campos do formulário às propriedades do objeto livro
            livro.LivroId = livroIdSelecionado; // Define o ID do livro a ser editado
            livro.Titulo = txtTitulo.Text;
            livro.ISBN = txtIsbn.Text;
            livro.EditoraNome = txtEditoraNome.Text;
            livro.AutorNome = txtAutorNome.Text;
            livro.CategoriaNome = cbCategoria.GetItemText(cbCategoria.SelectedItem); // Converte o item selecionado na ComboBox para string

            livro.EditarLivro(livro); // Chama o método para salvar as alterações do livro no banco de dados
        }
    }
}
