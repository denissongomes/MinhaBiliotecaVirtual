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
            preencherGridView();
        }

        void preencherGridView()
        {
           List<Livro> livroList = new List<Livro>();

           Livro livro = new Livro();

           livroList = livro.GetLivros();

 ;         dataGridViewLivros.DataSource = livroList;
            


        }


        private void frmPrincipal_Activated(object sender, System.EventArgs e)
        {
            preencherGridView();
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


      void  DeletarLivro()
        {
            // int livroId;
            //livroId = (int)dataGridViewLivros.CurrentRow.Cells[0].Value;

            //  Livro livro = new Livro();
            //  livro.DeletarLivro(livroId);
            //  preencherGridView();
            int livroId;
            livroId = (int)dataGridViewLivros.CurrentRow.Cells[0].Value;

            string? livroTitulo = datagridviewBooks.CurrentRow.Cells[1].Value.ToString();
            string message = "Are you sure that you want to delete the book '" + livroTitulo + "'?";
            DialogResult dr = MessageBox.Show(message, "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                  Livro livro = new Livro();
                  livro.DeletarLivro(livroId);
                  preencherGridView();

            }
        }
}
