using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiliotecaVirtual.Classes
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string Isbn { get; set; }
        public string EditoraNome { get; set; }
        public string AutorNome { get; set; }
        public string CategoriaNome { get; set; }
        String strConnetion = "server=192.168.0.38;uid=root;database=Livraria;";

        public List<Livro> GetLivros()
        {

            List<Livro> livroList = new List<Livro>();

            MySqlConnection con = new MySqlConnection(strConnetion);

            string selectSQL = "SELECT LivroId, Titulo, EditoraNome, AutorNome, CategoriaNome FROM GetLivrosData";

            con.Open();

            MySqlCommand cmd = new MySqlCommand(selectSQL, con);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Livro livro = new Livro();
                    livro.LivroId = Convert.ToInt32(dr["LivroId"]);
                    livro.Titulo = dr["Titulo"].ToString();
                    livro.EditoraNome = dr["EditoraNome"].ToString();
                    livro.AutorNome = dr["AutorNome"].ToString();
                    livro.CategoriaNome = dr["CategoriaNome"].ToString();
                    livroList.Add(livro);

                }

            }
            return livroList;
        }

        public void NovoLivro(Livro livro)
        {
            MySqlConnection con = new MySqlConnection(strConnetion);
            MySqlCommand cmd = new MySqlCommand("CriarLivro", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("p_Titulo", livro.Titulo));
            cmd.Parameters.Add(new MySqlParameter("p_ISBN", livro.Isbn));
            cmd.Parameters.Add(new MySqlParameter("p_EditoraNome", livro.EditoraNome));
            cmd.Parameters.Add(new MySqlParameter("p_AutorNome", livro.AutorNome));
            cmd.Parameters.Add(new MySqlParameter("p_CategoriaNome", livro.CategoriaNome));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }

    
}

