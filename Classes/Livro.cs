using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MinhaBiliotecaVirtual.Classes
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string EditoraNome { get; set; }
        public string AutorNome { get; set; }
        public string CategoriaNome { get; set; }
        
        // App config 
        readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
  
        public List<Livro> GetLivros()
        {

            List<Livro> livroList = new List<Livro>();

            MySqlConnection con = new MySqlConnection(ConnectionString);

            string selectSQL = "SELECT LivroId, Titulo,ISBN, EditoraNome, AutorNome, CategoriaNome FROM GetLivroData";

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
                    livro.ISBN = dr["ISBN"].ToString();
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
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand("CriarLivro", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("p_Titulo", livro.Titulo));
            cmd.Parameters.Add(new MySqlParameter("p_ISBN", livro.ISBN));
            cmd.Parameters.Add(new MySqlParameter("p_EditoraNome", livro.EditoraNome));
            cmd.Parameters.Add(new MySqlParameter("p_AutorNome", livro.AutorNome));
            cmd.Parameters.Add(new MySqlParameter("p_CategoriaNome", livro.CategoriaNome));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Livro GetLivros(int livroId)
        {
            
            MySqlConnection con = new MySqlConnection(ConnectionString);

            string selectSQL = "SELECT LivroId, Titulo, ISBN, EditoraNome, AutorNome, CategoriaNome FROM GetLivrosData WHERE LivroId=" + livroId;

            con.Open();

            MySqlCommand cmd = new MySqlCommand(selectSQL, con);

            MySqlDataReader dr = cmd.ExecuteReader();

            Livro livro = new Livro();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Livro lilvro = new Livro();
                    livro.LivroId = Convert.ToInt32(dr["LivroId"]);
                    livro.Titulo = dr["Titulo"].ToString();
                    livro.ISBN = dr["ISBN"].ToString();
                    livro.EditoraNome = dr["EditoraNome"].ToString();
                    livro.AutorNome = dr["AutorNome"].ToString();
                    livro.CategoriaNome = dr["CategoriaNome"].ToString();
                  
                }

            }
            return livro;
        }

        public void EditarLivro(Livro livro)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand cmd = new MySqlCommand("AtualizarLivro", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new MySqlParameter("p_LivroId", livro.LivroId));
                    cmd.Parameters.Add(new MySqlParameter("p_Titulo", livro.Titulo));
                    cmd.Parameters.Add(new MySqlParameter("p_ISBN", livro.ISBN));
                    cmd.Parameters.Add(new MySqlParameter("p_EditoraNome", livro.EditoraNome));
                    cmd.Parameters.Add(new MySqlParameter("p_AutorNome", livro.AutorNome));
                    cmd.Parameters.Add(new MySqlParameter("p_CategoriaNome", livro.CategoriaNome));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception ex) 
            {
                throw ex;
            }

            
            
        }


        public void DeletarLivro(int livroId)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand("DeletarLivro", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("p_LivroId", livroId));
         
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }

}

    


