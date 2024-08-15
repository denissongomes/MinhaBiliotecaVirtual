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
        static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        static MySqlConnection con = new MySqlConnection(ConnectionString);

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string loginSQL = "SELECT * FROM Usuários WHERE usuario='" + txtUsuatio.Text + "' AND senha='"+ txtSenha.Text + "')";
            MySqlCommand cmd = new MySqlCommand(loginSQL, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true) 
            {
                new frmPrincipal().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos, por favor tente novamente!", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuatio.Text = "";
                txtSenha.Text = "";
                txtUsuatio.Focus();

            }

            con.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuatio.Text = "";
            txtSenha.Text = "";
            txtUsuatio.Focus();
        }
    }
}
