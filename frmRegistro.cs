using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaBiliotecaVirtual.Classes;
using MySql.Data.MySqlClient;

namespace MinhaBiliotecaVirtual
{
    public partial class frmRegistro : Form
    {
        // Define a string de conexão para o banco de dados MySQL, utilizando uma configuração no arquivo de configuração da aplicação.
        static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        // Cria uma instância da conexão com o banco de dados utilizando a string de conexão definida acima.
        static MySqlConnection con = new MySqlConnection(ConnectionString);

        // Construtor do formulário frmRegistro.
        public frmRegistro()
        {
            InitializeComponent(); // Inicializa os componentes do formulário, configurados no designer.
        }

        // Evento acionado quando o checkbox de "Mostrar Senha" é alterado.
        private void checkBxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxMostrarSenha.Checked)
            {
                // Exibe a senha em texto claro se o checkbox estiver marcado.
                txtSenha.PasswordChar = '\0';
                txtConfSenha.PasswordChar = '\0';
            }
            else
            {
                // Oculta a senha com um caractere de bolinha se o checkbox estiver desmarcado.
                txtSenha.PasswordChar = '•';
                txtConfSenha.PasswordChar = '•';
            }
        }

        // Evento acionado quando o botão "Registrar" é clicado.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Verifica se os campos de usuário e senha estão vazios.
            if (txtUsuatio.Text == "" && txtSenha.Text == "" && txtConfSenha.Text == "")
            {
                // Exibe uma mensagem de erro se os campos estiverem vazios.
                MessageBox.Show("Os campos Usuário e Senha estão vazios!", "Falha no Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSenha.Text == txtConfSenha.Text)
            {
                // Se as senhas coincidem, tenta registrar o usuário no banco de dados.
                con.Open(); // Abre a conexão com o banco de dados.

                // Concatena a consulta SQL para inserir o novo usuário no banco de dados.
                string registroSQL = "INSERT INTO usuarios VALUES ('" + txtUsuatio.Text + "', '" + txtSenha.Text + "')";
                MySqlCommand cmd = new MySqlCommand(registroSQL, con);

                // Executa a consulta SQL.
                MySqlDataReader dr = cmd.ExecuteReader();

                con.Close(); // Fecha a conexão com o banco de dados.

                // Limpa os campos de entrada após o registro bem-sucedido.
                txtUsuatio.Text = "";
                txtSenha.Text = "";
                txtConfSenha.Text = "";

                // Exibe uma mensagem confirmando o sucesso do registro.
                MessageBox.Show("Sua conta foi criada com sucesso!", "Confirmação de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abre o formulário principal e oculta o formulário de registro.
                new frmPrincipal().Show();
                this.Hide();

            }
            else
            {
                // Se as senhas não correspondem, exibe uma mensagem de erro e limpa os campos de senha.
                MessageBox.Show("A senha não corresponde, por favor digite novamente.", "Falha no Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtSenha.Text = "";
                txtConfSenha.Text = "";
                txtSenha.Focus();
            }
        }

        // Evento acionado quando o botão "Limpar" é clicado.
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa os campos de entrada e coloca o foco no campo de usuário.
            txtUsuatio.Text = "";
            txtSenha.Text = "";
            txtConfSenha.Text = "";
            txtUsuatio.Focus();
        }

        // Evento acionado quando o link "Entre" é clicado.
        private void lblEntre_Click(object sender, EventArgs e)
        {
            // Abre o formulário de login e oculta o formulário de registro.
            new frmLogin().Show();
            this.Hide();
        }

        // Evento acionado quando o rótulo "label6" é clicado (aparentemente relacionado ao encerramento da aplicação).
        private void label6_Click(object sender, EventArgs e)
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
