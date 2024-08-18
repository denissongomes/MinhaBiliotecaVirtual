using MySql.Data.MySqlClient; // Importa o namespace para trabalhar com o MySQL
using System;
using System.Collections.Generic;
using System.Configuration; // Para acessar a string de conexão do arquivo de configuração
using System.Data;
using System.Windows.Forms;

namespace MinhaBiliotecaVirtual.Classes
{
    public class Livro
    {
        // Propriedades da classe Livro, representando os dados do livro
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string EditoraNome { get; set; }
        public string AutorNome { get; set; }
        public string CategoriaNome { get; set; }

        // String de conexão com o banco de dados, obtida do arquivo de configuração
        readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        // Método para obter a lista de livros do banco de dados
        public List<Livro> GetLivros()
        {
            List<Livro> livroList = new List<Livro>(); // Cria uma lista para armazenar os livros

            // Conexão com o banco de dados MySQL
            MySqlConnection con = new MySqlConnection(ConnectionString);

            // Query para selecionar os dados dos livros
            string selectSQL = "SELECT LivroId, Titulo, ISBN, EditoraNome, AutorNome, CategoriaNome FROM GetLivroData";

            con.Open(); // Abre a conexão

            // Comando SQL para executar a query
            MySqlCommand cmd = new MySqlCommand(selectSQL, con);

            // Executa a query e obtém os resultados
            MySqlDataReader dr = cmd.ExecuteReader();

            // Verifica se há resultados
            if (dr != null)
            {
                while (dr.Read()) // Itera sobre os registros retornados
                {
                    Livro livro = new Livro
                    {
                        LivroId = Convert.ToInt32(dr["LivroId"]),
                        Titulo = dr["Titulo"].ToString(),
                        ISBN = dr["ISBN"].ToString(),
                        EditoraNome = dr["EditoraNome"].ToString(),
                        AutorNome = dr["AutorNome"].ToString(),
                        CategoriaNome = dr["CategoriaNome"].ToString()
                    };
                    livroList.Add(livro); // Adiciona o livro à lista
                }
            }
            return livroList; // Retorna a lista de livros
        }

        // Método para adicionar um novo livro ao banco de dados
        public void NovoLivro(Livro livro)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand("CriarLivro", con) // Stored Procedure para criar um novo livro
            {
                CommandType = CommandType.StoredProcedure
            };

            // Define os parâmetros da Stored Procedure
            cmd.Parameters.Add(new MySqlParameter("p_Titulo", livro.Titulo));
            cmd.Parameters.Add(new MySqlParameter("p_ISBN", livro.ISBN));
            cmd.Parameters.Add(new MySqlParameter("p_EditoraNome", livro.EditoraNome));
            cmd.Parameters.Add(new MySqlParameter("p_AutorNome", livro.AutorNome));
            cmd.Parameters.Add(new MySqlParameter("p_CategoriaNome", livro.CategoriaNome));
            con.Open(); // Abre a conexão
            cmd.ExecuteNonQuery(); // Executa a Stored Procedure
            con.Close(); // Fecha a conexão
        }

        // Método para obter os dados de um livro específico pelo ID
        public Livro GetLivros(int livroId)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);

            // Query para selecionar os dados de um livro específico
            string selectSQL = "SELECT LivroId, Titulo, ISBN, EditoraNome, AutorNome, CategoriaNome FROM GetLivroData WHERE LivroId=" + livroId;

            con.Open(); // Abre a conexão

            MySqlCommand cmd = new MySqlCommand(selectSQL, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            Livro livro = new Livro();

            // Verifica se há resultados e preenche o objeto livro com os dados
            if (dr != null)
            {
                while (dr.Read())
                {
                    livro.LivroId = Convert.ToInt32(dr["LivroId"]);
                    livro.Titulo = dr["Titulo"].ToString();
                    livro.ISBN = dr["ISBN"].ToString();
                    livro.EditoraNome = dr["EditoraNome"].ToString();
                    livro.AutorNome = dr["AutorNome"].ToString();
                    livro.CategoriaNome = dr["CategoriaNome"].ToString();
                }
            }
            return livro; // Retorna o livro com os dados preenchidos
        }

        // Método para editar os dados de um livro existente no banco de dados
        public void EditarLivro(Livro livro)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString))
                {
                    MySqlCommand cmd = new MySqlCommand("AtualizarLivro", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Define os parâmetros da Stored Procedure
                    cmd.Parameters.Add(new MySqlParameter("p_LivroId", livro.LivroId));
                    cmd.Parameters.Add(new MySqlParameter("p_Titulo", livro.Titulo));
                    cmd.Parameters.Add(new MySqlParameter("p_ISBN", livro.ISBN));
                    cmd.Parameters.Add(new MySqlParameter("p_EditoraNome", livro.EditoraNome));
                    cmd.Parameters.Add(new MySqlParameter("p_AutorNome", livro.AutorNome));
                    cmd.Parameters.Add(new MySqlParameter("p_CategoriaNome", livro.CategoriaNome));

                    con.Open(); // Abre a conexão
                    cmd.ExecuteNonQuery(); // Executa a Stored Procedure
                    con.Close(); // Fecha a conexão
                }
            }
            catch (Exception ex)
            {
                throw ex; // Lança a exceção em caso de erro
            }
        }

        // Método para deletar um livro do banco de dados
        public void DeletarLivro(int livroId)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand("DeletarLivro", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new MySqlParameter("p_LivroId", livroId)); // Define o parâmetro da Stored Procedure

            con.Open(); // Abre a conexão
            cmd.ExecuteNonQuery(); // Executa a Stored Procedure
            con.Close(); // Fecha a conexão
        }
    }
}
