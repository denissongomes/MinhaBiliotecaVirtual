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
        public frmRegistro()
        {

            InitializeComponent();
          
        }

        static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        static MySqlConnection con = new MySqlConnection(ConnectionString);
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        void Connect()
        {
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsuatio.Text == "" &&  txtUsuatio.Text == "" && txtConfSenha.Text == "")
            {
                MessageBox.Show("Os campos Usuário e Senha estão vazios!", "Falha no Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSenha.Text == txtConfSenha.Text){ 
            

            }
        }
    }
}
