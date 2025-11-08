using AppRegistroMultas.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRegistroMultas.Contexto
{
    public class VeiculoContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;

        public VeiculoContext()
        {
            dados_conexao = "server=localhost;port=3310;database=bdregistromultas;user=root;password=root;Persist Security Info=False;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);
        }
     public List<Veiculo> ListarVeiculos()
        {
            List<Veiculo> listarVeiculosParaExportar = new List<Veiculo>();
            string sql = "SELECT * FROM VEICULO";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();

                MySqlDataReader dados = comando.ExecuteReader();

                while (dados.Read())
                {
                    Veiculo veiculo = new Veiculo();
                    veiculo.id = Convert.ToInt32(dados["id"]);
                    veiculo.Modelo = dados["Modelo"].ToString();
                    veiculo.Placa = dados["Placa"].ToString();
                    veiculo.Marca = dados["Marca"].ToString();
                    listarVeiculosParaExportar.Add(veiculo);

                }
                conexao.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"error {ex.Message}");
            }
            return listarVeiculosParaExportar;



        }

        public void InserirVeiculos(Veiculo veiculo)
        {
            string sql = "INSERT INTO VEICULO (Modelo, Placa, Marca) VALUES (@Modelo, @Placa, @Marca)";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Modelo", veiculo.Modelo);
                comando.Parameters.AddWithValue("@Placa", veiculo.Placa);
                comando.Parameters.AddWithValue("@Marca", veiculo.Marca);

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




    }
}
