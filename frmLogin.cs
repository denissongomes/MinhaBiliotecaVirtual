using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaBiliotecaVirtual.Classes;
using MySql.Data.MySqlClient;

namespace MinhaBiliotecaVirtual
{
    public partial class frmLogin : Form
    {
        // Define a string de conexão para o banco de dados MySQL, utilizando uma configuração no arquivo de configuração da aplicação.
        static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        // Cria uma instância da conexão com o banco de dados utilizando a string de conexão definida acima.
        static MySqlConnection con = new MySqlConnection(ConnectionString);

        // Construtor do formulário frmLogin.
        public frmLogin()
        {
            InitializeComponent(); // Inicializa os componentes do formulário, configurados no designer.
        }

        // Evento acionado quando o botão "Login" é clicado.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open(); // Abre a conexão com o banco de dados.

            // Concatena a consulta SQL para selecionar o usuário e senha fornecidos.
            string loginSQL = "SELECT * FROM Usuarios WHERE usuario='" + txtUsuatio.Text + "' AND senha='" + txtSenha.Text + "'";
            MySqlCommand cmd = new MySqlCommand(loginSQL, con);

            // Executa a consulta e obtém um leitor de dados para verificar se o usuário existe.
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                // Se um registro for encontrado, abre o formulário principal e oculta o formulário de login.
                new frmPrincipal().Show();
                this.Hide();
            }
            else
            {
                // Se nenhum registro for encontrado, exibe uma mensagem de erro e limpa os campos de entrada.
                MessageBox.Show("Usuário ou Senha inválidos, por favor tente novamente!", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuatio.Text = "";
                txtSenha.Text = "";
                txtUsuatio.Focus();
            }

            con.Close(); // Fecha a conexão com o banco de dados.
        }

        // Evento acionado quando o botão "Limpar" é clicado.
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos de entrada e coloca o foco no campo de usuário.
            txtUsuatio.Text = "";
            txtSenha.Text = "";
            txtUsuatio.Focus();
        }

        // Evento acionado quando o checkbox de "Mostrar Senha" é alterado.
        private void checkBxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxMostrarSenha.Checked)
            {
                // Exibe a senha em texto claro se o checkbox estiver marcado.
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                // Oculta a senha com um caractere de bolinha se o checkbox estiver desmarcado.
                txtSenha.PasswordChar = '•';
            }
        }

        // Evento acionado quando o link "Cadastrar" é clicado.
        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            // Abre o formulário de registro e oculta o formulário de login.
            new frmRegistro().Show();
            this.Hide();
        }

        // Evento acionado quando o rótulo "label4" é clicado (aparentemente relacionado ao encerramento da aplicação).
        private void label4_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem de confirmação para o usuário.
            string message = "Tem certeza que deseja sair e encerrar a aplicação?";
            DialogResult res = MessageBox.Show(message, "Sair da aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se o usuário confirmar, encerra a aplicação.
            if (res != DialogResult.Yes)
            {
                return;
            }
            else
            {
                System.Windows.Forms.Application.ExitThread();
            }
        }
    }
}
