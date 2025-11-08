using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRegistroMultas.Models;
using AppRegistroMultas.Contexto;

namespace AppRegistroMultas.Formulario
{
    public partial class FormCadastro : Form
    {
     
        public FormCadastro()
        {
            InitializeComponent();
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
          txtMarca.Clear();txtModelo.Clear();
            txtPlaca.Clear();txtModelo.Select(); 
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Modelo = txtModelo.Text;
            veiculo.Marca = txtMarca.Text;    
            veiculo.Placa = txtPlaca.Text;


            VeiculoContext context = new VeiculoContext();
            context.InserirVeiculos(veiculo);

            
            //veiculo.id = idVeiculo;//chave primária
            //Context.ListaVeiculos.Add(veiculo);
            //idVeiculo++; 
            MessageBox.Show("SALVO COM SUCESSO","2A INF",MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMarca.Clear(); txtModelo.Clear();
            txtPlaca.Clear(); txtModelo.Select();

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
