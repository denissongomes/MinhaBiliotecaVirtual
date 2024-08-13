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

        private void btnNovoForm_Click(object sender, EventArgs e)
        {
            frmNovoLivro formNovoLivro = new frmNovoLivro();
            formNovoLivro.ShowDialog();
        }

        private void frmPrincipal_Activated(object sender, System.EventArgs e)
        {
            preencherGridView();
        }
    }
}
