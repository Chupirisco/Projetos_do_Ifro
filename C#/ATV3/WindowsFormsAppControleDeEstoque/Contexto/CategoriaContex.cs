using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppControleDeEstoque.Models;

namespace WindowsFormsAppControleDeEstoque.Contexto
{
    public class CategoriaContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;
        public CategoriaContext()
        {
            dados_conexao = "server=localhost;port=3310;database=tarefapo;user=root;password=root;Persist Security Info=False;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }

        public List<Categoria> ListarCategorias()
        {
            List<Categoria> listarCategoriasParaExportar = new List<Categoria>();
            string sql = "SELECT * FROM CATEGORIA";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();

                MySqlDataReader dados = comando.ExecuteReader();

                while (dados.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.IdCategoria = Convert.ToInt32(dados["IdCategoria"]);
                    categoria.Nome = dados["Nome"].ToString();                    
                    listarCategoriasParaExportar.Add(categoria);

                }
                conexao.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"error {ex.Message}");
            }
            return listarCategoriasParaExportar;



        }

        public void InserirCategoria(Categoria categoria)
        {
            string sql = "INSERT INTO CATEGORIA (Nome) VALUES (@Nome)";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Nome", categoria.Nome);              
                 

                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir tabela {ex.Message}");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void AtualizarCategoria(Categoria categoria)
        {
            string sql = "UPDATE CATEGORIA SET Nome = @Nome WHERE IdCategoria = @IdCategoria";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Nome", categoria.Nome);
                comando.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);

                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Categoria atualizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhuma categoria foi atualizada. Verifique o IdCategoria.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar categoria: {ex.Message}");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
