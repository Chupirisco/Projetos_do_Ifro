using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRegistroMultas.Models;
using MySql.Data.MySqlClient;

namespace AppRegistroMultas.Contexto
{
    public class MultaContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;

        public MultaContext()
        {
            dados_conexao = "server=localhost;port=3310;database=bdregistromultas;user=root;password=root;Persist Security Info=False;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }
        public List<Multa> ListarMultas()
        {
            List<Multa> listarMultasParaExportar = new List<Multa>();
            string sql = "SELECT * FROM MULTA";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();

                MySqlDataReader dados = comando.ExecuteReader();

                while (dados.Read())
                {
                    Multa multa = new Multa();
                    multa.Id = Convert.ToInt32(dados["id"]);
                    multa.Descricao = dados["Descricao"].ToString();
                    multa.ValorMulta =Convert.ToDecimal(dados["ValorMulta"]);
                    multa.VeiculoId =Convert.ToInt32(dados["VeiculoId"]);
                    listarMultasParaExportar.Add(multa);

                }
                conexao.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"error {ex.Message}");
            }
            return listarMultasParaExportar;



        }

        public void InserirMultas(Multa multa, int idVeiculo)
        {
            string sql = "INSERT INTO MULTA (Descricao, ValorMulta, VeiculoId) VALUES (@Descricao, @ValorMulta, @VeiculoId)";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Descricao", multa.Descricao);
                comando.Parameters.AddWithValue("@ValorMulta", multa.ValorMulta);
                comando.Parameters.AddWithValue("@VeiculoId", idVeiculo);

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


        public void AtualizarMulta(Multa multa)
        {
            string sql = "UPDATE MULTA SET Descricao = @Descricao, ValorMulta = @ValorMulta WHERE id = @Id";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Descricao", multa.Descricao);
                comando.Parameters.AddWithValue("@ValorMulta", multa.ValorMulta);
                comando.Parameters.AddWithValue("@Id", multa.Id);
                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();
                if (linhasAfetadas == 0)
                {
                    MessageBox.Show("Nenhuma multa encontrada com esse ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar a multa: {ex.Message}");
            }
            finally
            {
                MessageBox.Show("Multa Modificada com sucesso!!!");
                conexao.Close();
            }
        }
        public void DeletarMulta(int idMulta)
        {
            string sql = "DELETE FROM MULTA WHERE id = @Id";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Id", idMulta);
                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();
                if (linhasAfetadas == 0)
                {
                    MessageBox.Show("Nenhuma multa encontrada com esse ID para deletar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar a multa: {ex.Message}");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
