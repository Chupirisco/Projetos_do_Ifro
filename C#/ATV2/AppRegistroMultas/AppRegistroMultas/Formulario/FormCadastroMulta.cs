using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRegistroMultas.Contexto;
using AppRegistroMultas.Models; 

namespace AppRegistroMultas.Formulario
{
    public partial class FormCadastroMulta : Form
    {
        int cont = 1;
        int idVeiculo;
        public List<Veiculo> listaVeiculos = new List<Veiculo>();    
        public List<Multa> listaMultasTemp = new List<Multa>(); //temporário
       

        public FormCadastroMulta()
        {
            InitializeComponent();
            VeiculoContext veiculoContext = new VeiculoContext();
            listaVeiculos = veiculoContext.ListarVeiculos().ToList();
            cbVeiculo.DataSource = listaVeiculos.ToList();

            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.SelectedIndex = -1; //combobox em branco
        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int linhaSelec = cbVeiculo.SelectedIndex;
            if(linhaSelec>-1 && cont > 1)
            {
                var veiculo = listaVeiculos[linhaSelec]; 
                txtModelo.Text = veiculo.Modelo;
                txtMarca.Text = veiculo.Marca;
                txtPlaca.Text = veiculo.Placa;
               
                idVeiculo = veiculo.id;//para ser usado como chave estrangeira
            }
            cont++; 
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Multa multa = new Multa();
            multa.Descricao = txtDescricao.Text;    
            multa.ValorMulta = Convert.ToDecimal(txtValor.Text);
           
            multa.VeiculoId = idVeiculo;//chave estrangeira => vínculo da multa com o veículo
            listaMultasTemp.Add(multa);
         
            dtTabela.DataSource = listaMultasTemp.ToList();//exibir na tabela
            txtDescricao.Clear();txtValor.Clear();
            txtDescricao.Select(); 
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear(); txtValor.Clear();
           txtMarca.Clear(); txtModelo.Clear();
            txtPlaca.Clear(); cbVeiculo.SelectedIndex = -1; //combobox em branco
            listaMultasTemp.Clear();//limpar lista
            dtTabela.DataSource = listaMultasTemp.ToList();//atualizar tabela
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            MultaContext multa = new MultaContext();
            Context.ListaMultas.AddRange(listaMultasTemp);//salva os dados em lote

            foreach(var item in listaMultasTemp)
            {
                multa.InserirMultas(item, idVeiculo);
            }

            MessageBox.Show("SALVO COM SUCESSO", "2A INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDescricao.Clear(); txtValor.Clear();
            txtMarca.Clear(); txtModelo.Clear();
            txtPlaca.Clear(); cbVeiculo.SelectedIndex = -1; //combobox em branco
            listaMultasTemp.Clear();//limpar lista
            dtTabela.DataSource = listaMultasTemp.ToList();//atualizar tabela

        }

        private void FormCadastroMulta_Load(object sender, EventArgs e)
        {

        }
    }
}
