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
    public class ProdutoContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;

        public ProdutoContext()
        {
            dados_conexao = "server=localhost;port=3310;database=tarefapo;user=root;password=root;Persist Security Info=False;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }
        public List<Produto> ListarProdutos()
        {
            List<Produto> listarProdutoParaExportar = new List<Produto>();
            string sql = "SELECT * FROM PRODUTO";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();

                MySqlDataReader dados = comando.ExecuteReader();

                while (dados.Read())
                {
                    Produto produto = new Produto();
                    produto.IdProduto = Convert.ToInt32(dados["IdProduto"]);
                    produto.Preco = Convert.ToDecimal(dados["Preco"]);
                    produto.Quantidade = Convert.ToInt32(dados["Quantidade"]);
                    produto.Nome = dados["Nome"].ToString();
                    produto.IdSecao = Convert.ToInt32(dados["IdSecao"]);
                    produto.IdCategoria = Convert.ToInt32(dados["IdCategoria"]);
                    listarProdutoParaExportar.Add(produto);

                }
                conexao.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"error {ex.Message}");
            }
            return listarProdutoParaExportar;



        }

        public void InserirProduto(Produto produto, int idSecao, int idCategoria)
        {
            string sql = "INSERT INTO PRODUTO (Nome, Preco, Quantidade, IdSecao, IdCategoria) VALUES (@Nome, @Preco, @Quantidade, @IdSecao, @IdCategoria)";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Nome", produto.Nome);
                comando.Parameters.AddWithValue("@Preco", produto.Preco);
                comando.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                comando.Parameters.AddWithValue("@IdSecao", idSecao);
                comando.Parameters.AddWithValue("@IdCategoria", idCategoria);

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
        public void AtualizarProduto(Produto produto)
        {
            string sql = "UPDATE PRODUTO SET Nome = @Nome, Preco = @Preco, Quantidade = @Quantidade WHERE IdProduto = @IdProduto";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Nome", produto.Nome);
                comando.Parameters.AddWithValue("@Preco", produto.Preco);
                comando.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                comando.Parameters.AddWithValue("@IdProduto", produto.IdProduto);

                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Produto atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum produto foi atualizado. Verifique o IdProduto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar produto: {ex.Message}");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
