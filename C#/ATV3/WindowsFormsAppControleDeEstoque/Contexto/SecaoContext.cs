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
    internal class SecaoContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;
        public SecaoContext()
        {
            dados_conexao = "server=localhost;port=3310;database=tarefapo;user=root;password=root;Persist Security Info=False;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }

        public List<Secao> ListarSecao()
        {
            List<Secao> listarSecaoParaExportar = new List<Secao>();
            string sql = "SELECT * FROM SECAO";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();

                MySqlDataReader dados = comando.ExecuteReader();

                while (dados.Read())
                {
                    Secao secao = new Secao();
                    secao.IdSecao = Convert.ToInt32(dados["IdSecao"]);
                    secao.Nome = dados["Nome"].ToString();
                    secao.Numero = Convert.ToInt32(dados["Numero"]);                
                    listarSecaoParaExportar.Add(secao);

                }
                conexao.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"error {ex.Message}");
            }
            return listarSecaoParaExportar;



        }

       public void InserirSecao(Secao secao)
        {
            string sql = "INSERT INTO SECAO (Nome, Numero) VALUES (@Nome, @Numero)";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Nome", secao.Nome);
                comando.Parameters.AddWithValue("@Numero", secao.Numero);               
                              
                

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
        public void AtualizarSecao(Secao secao)
        {
            string sql = "UPDATE SECAO SET Nome = @Nome, Numero = @Numero WHERE IdSecao = @IdSecao";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Nome", secao.Nome);
                comando.Parameters.AddWithValue("@Numero", secao.Numero);
                comando.Parameters.AddWithValue("@IdSecao", secao.IdSecao);

                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Seção atualizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhuma seção foi atualizada. Verifique o IdSecao.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar seção: {ex.Message}");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}

