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
using static System.Net.Mime.MediaTypeNames;

namespace MinhaBiliotecaVirtual
{
    public partial class frmPrincipal : Form
    {
        // Construtor do formulário frmPrincipal
        public frmPrincipal()
        {
            InitializeComponent(); // Inicializa os componentes do formulário, configurados no designer.
            PreencherGridView(); // Preenche a DataGridView com os dados dos livros ao iniciar.
            AjustarGridView(); // Ajusta a aparência e as colunas da DataGridView.
        }

        // Método para preencher a DataGridView com os dados dos livros.
        void PreencherGridView()
        {
            List<Livro> livroList = new List<Livro>(); // Cria uma lista para armazenar os livros.

            Livro livro = new Livro(); // Cria uma instância da classe Livro.

            livroList = livro.GetLivros(); // Obtém a lista de livros a partir do método GetLivros() da classe Livro.

            dataGridViewLivros.DataSource = livroList; // Define a fonte de dados da DataGridView como a lista de livros.
        }

        // Evento acionado quando o formulário principal é ativado (quando ele ganha foco).
        private void frmPrincipal_Activated(object sender, System.EventArgs e)
        {
            PreencherGridView(); // Atualiza a DataGridView sempre que o formulário é ativado.
        }

        // Evento acionado quando o botão "Novo Livro" é clicado.
        private void btnAbrirFrmNovo_Click(object sender, EventArgs e)
        {
            frmNovoLivro formNovoLivro = new frmNovoLivro(); // Cria uma nova instância do formulário de novo livro.
            formNovoLivro.ShowDialog(); // Abre o formulário como uma caixa de diálogo.
        }

        // Evento acionado quando o botão "Editar Livro" é clicado.
        private void btnAbrirFrmEditar_Click(object sender, EventArgs e)
        {
            EditarLivro(); // Chama o método para editar o livro selecionado.
        }

        // Método para editar o livro selecionado na DataGridView.
        void EditarLivro()
        {
            int livroId;
            livroId = (int)dataGridViewLivros.CurrentRow.Cells[0].Value; // Obtém o ID do livro selecionado.

            frmEditarLivro formEditarLivro = new frmEditarLivro(livroId); // Cria uma nova instância do formulário de edição de livro, passando o ID do livro.
            formEditarLivro.ShowDialog(); // Abre o formulário como uma caixa de diálogo.
        }

        // Evento acionado quando o botão "Deletar Livro" é clicado.
        private void btnDeletarLivro_Click(object sender, EventArgs e)
        {
            DeletarLivro(); // Chama o método para deletar o livro selecionado.
        }

        // Método para deletar o livro selecionado na DataGridView.
        void DeletarLivro()
        {
            int livroId;
            livroId = (int)dataGridViewLivros.CurrentRow.Cells[0].Value; // Obtém o ID do livro selecionado.

            string livroTitulo = dataGridViewLivros.CurrentRow.Cells[1].Value.ToString(); // Obtém o título do livro selecionado.
            string message = "Tem certeza de que deseja excluir o livro: '" + livroTitulo + "'?";
            DialogResult dr = MessageBox.Show(message, "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Exibe uma caixa de diálogo de confirmação.

            if (dr == DialogResult.Yes)
            {
                Livro livro = new Livro(); // Cria uma nova instância da classe Livro.
                livro.DeletarLivro(livroId); // Chama o método para deletar o livro pelo ID.
                PreencherGridView(); // Atualiza a DataGridView após a exclusão.
            }
        }

        // Método para ajustar a aparência e as colunas da DataGridView.
        void AjustarGridView()
        {
            // Define o texto do cabeçalho de cada coluna.
            dataGridViewLivros.Columns[0].HeaderText = "ID";
            dataGridViewLivros.Columns[1].HeaderText = "Título";
            dataGridViewLivros.Columns[2].HeaderText = "ISBN";
            dataGridViewLivros.Columns[3].HeaderText = "Editora";
            dataGridViewLivros.Columns[4].HeaderText = "Autor";
            dataGridViewLivros.Columns[5].HeaderText = "Categoria";

            // Define a largura de cada coluna.
            dataGridViewLivros.Columns[0].Width = 50;
            dataGridViewLivros.Columns[1].Width = 200;
            dataGridViewLivros.Columns[2].Width = 90;
            dataGridViewLivros.Columns[3].Width = 148;
            dataGridViewLivros.Columns[4].Width = 148;
            dataGridViewLivros.Columns[5].Width = 120;
        }

        // Evento acionado quando o formulário principal está prestes a ser fechado.
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exibe uma caixa de diálogo para confirmar se o usuário deseja realmente fechar a aplicação.
            string message = "Tem certeza que deseja sair e encerrar a aplicação?";
            DialogResult res = MessageBox.Show(message, "Sair da aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
            {
                e.Cancel = true; // Cancela o fechamento se o usuário clicar em "No".
                return;
            }
            else
            {
                System.Windows.Forms.Application.ExitThread(); // Fecha a aplicação se o usuário clicar em "Yes".
            }
        }
    }
}
