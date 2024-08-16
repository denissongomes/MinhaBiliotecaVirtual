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

        static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        static MySqlConnection con = new MySqlConnection(ConnectionString);

        public frmRegistro()
        {

            InitializeComponent();
          
        }

               
        private void checkBxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxMostrarSenha.Checked)
            {
                txtSenha.PasswordChar = '\0';
                txtConfSenha.PasswordChar = '\0';

            } 
            else
            {
                txtSenha.PasswordChar = '•';
                txtConfSenha.PasswordChar = '•';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsuatio.Text == "" &&  txtUsuatio.Text == "" && txtConfSenha.Text == "")
            {
                MessageBox.Show("Os campos Usuário e Senha estão vazios!", "Falha no Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSenha.Text == txtConfSenha.Text){


                con.Open();
                string registroSQL = "INSERT INTO Usuários VALUES ('"+txtUsuatio.Text+"', '"+txtSenha.Text+"')";
                MySqlCommand cmd = new MySqlCommand(registroSQL, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                con.Close();

                txtUsuatio.Text = "";
                txtSenha.Text = "";
                txtConfSenha.Text = "";

                MessageBox.Show("Sua conta foi criada com sucesso!", "Confirmação de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("A senha não corresponde, por favor digite novamente.", "Falha no Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                txtSenha.Text = "";
                txtConfSenha.Text = "";
                txtSenha.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuatio.Text = "";
            txtSenha.Text = "";
            txtConfSenha.Text = "";
            txtUsuatio.Focus();
        }

        private void lblEntre_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string message = "Tem certeza que deseja sair e encerrar a aplicaçcão?";
            DialogResult res = MessageBox.Show(message, "Sair da aplicaçcão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
