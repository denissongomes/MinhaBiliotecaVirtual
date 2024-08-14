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


namespace MinhaBiliotecaVirtual
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            PreencherGridView();
            AjustarGridView();
        }

        void PreencherGridView()
        {
            List<Livro> livroList = new List<Livro>();

            Livro livro = new Livro();

            livroList = livro.GetLivros();

            dataGridViewLivros.DataSource = livroList;



        }


        private void frmPrincipal_Activated(object sender, System.EventArgs e)
        {
            PreencherGridView();
        }


        private void btnAbrirFrmNovo_Click(object sender, EventArgs e)
        {
            frmNovoLivro formNovoLivro = new frmNovoLivro();
            formNovoLivro.ShowDialog();

        }

        private void btnAbrirFrmEditar_Click(object sender, EventArgs e)
        {
            EditarLivro();
        }

        void EditarLivro()
        {
            int livroId;
            livroId = (int)dataGridViewLivros.CurrentRow.Cells[0].Value;

            frmEditarLivro formEditarLivro = new frmEditarLivro(livroId);
            formEditarLivro.ShowDialog();

        }

        private void btnDeletarLivro_Click(object sender, EventArgs e)
        {
            DeletarLivro();
        }


        void DeletarLivro()
        {
            
            int livroId;
            livroId = (int)dataGridViewLivros.CurrentRow.Cells[0].Value;

            string livroTitulo = dataGridViewLivros.CurrentRow.Cells[1].Value.ToString();
            string message = "Tem certeza de que deseja excluir o livro: '" + livroTitulo + "'?";
            DialogResult dr = MessageBox.Show(message, "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Livro livro = new Livro();
                livro.DeletarLivro(livroId);
                PreencherGridView();

            }
        }

        void AjustarGridView()
        {
            dataGridViewLivros.Columns[0].HeaderText = "ID";
            dataGridViewLivros.Columns[1].HeaderText = "Título";
            dataGridViewLivros.Columns[2].HeaderText = "ISBN";
            dataGridViewLivros.Columns[3].HeaderText = "Editora";
            dataGridViewLivros.Columns[4].HeaderText = "Autor";
            dataGridViewLivros.Columns[5].HeaderText = "Categoria";

            dataGridViewLivros.Columns[0].Width = 50;
            dataGridViewLivros.Columns[1].Width = 200;
            dataGridViewLivros.Columns[2].Width = 90;
            dataGridViewLivros.Columns[3].Width = 120;
            dataGridViewLivros.Columns[4].Width = 120;
            dataGridViewLivros.Columns[5].Width = 120;
        }
    }
}
