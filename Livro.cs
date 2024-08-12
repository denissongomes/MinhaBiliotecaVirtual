using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MinhaBiliotecaVirtual
{
    public class Livro
    {
        public int LivroId (get; set;);
        public string Title (get; set;);
        public string Isbn (get; set;);
        public string EditoraNome (get; set;);
        public string AutorNome(get; set;);
        public string CategoriaNome(get; set;);

      
        

    }

    public List<Livro> GetLivros()
    {
        List<Livro> livroList = new List<Livro>();
        String strConnetion = "server=192.168.0.38;uid=root;database=Livraria;";
        MySqlConnection con = new MySqlConnection(strConnetion);
        string selectSQL = "SELECT LivroId, Titulo, EditoraNome, AutorNome, CategoriaNome FROM GetLivrosData";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(selectSQL, con);
        MySqlDataReader dr = cmd.ExecuteReader();

        if (dr != null)
        {
            while (dr.Read()) {
                Livro livro = new Livro();
                livro.LivroId = Convert.ToInt32(dr["LivroId"]);
                livro.Titulo = dr["Título"].ToString();
                livro.EditoraNome = dr["EditoraNome"].ToString();
                livro.AutorNome = dr["AutorNome"].ToString();
                livro.CategoriaNome = dr["CategoriaNome"].ToString();
                livroList.Add(livro);

            }

        }
        return livroList;
    }
}
