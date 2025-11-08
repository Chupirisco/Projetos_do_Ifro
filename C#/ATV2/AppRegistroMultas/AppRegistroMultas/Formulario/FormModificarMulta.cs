using AppRegistroMultas.Contexto;
using AppRegistroMultas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRegistroMultas.Formulario
{
    public partial class FormModificarMulta : Form
    {
        MultaContext multaContext = new MultaContext();
        VeiculoContext veiculoContext = new VeiculoContext();       
        List<Multa> listaMultas = new List<Multa>();

        int idMultaSelecionada;
        int idVeiculoSelecionado;
        public FormModificarMulta()
        {

            InitializeComponent();

            cbVeiculo.DataSource = veiculoContext.ListarVeiculos();
            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.SelectedIndex = -1;


            cbMulta.DataSource = null;
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";

        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbVeiculo.SelectedValue is Veiculo veiculo)
            {
                txtModelo.Text = veiculo.Modelo;
                txtMarca.Text = veiculo.Marca;
                txtPlaca.Text = veiculo.Placa;
                idVeiculoSelecionado = veiculo.id;


                listaMultas = multaContext.ListarMultas().Where(m => m.VeiculoId == idVeiculoSelecionado).ToList();

                cbMulta.DataSource = listaMultas.ToList();
                cbMulta.DisplayMember = "Descricao";
                cbMulta.SelectedIndex = -1;
                txtDescricao.Text = "";
                txtValor.Text = "";
            }
        }

        private void cbMulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMulta.SelectedValue is Multa multa)
            {
                idMultaSelecionada = multa.Id;
                txtDescricao.Text = multa.Descricao;
                txtValor.Text = multa.ValorMulta.ToString();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cbVeiculo.DataSource = null;
            cbMulta.DataSource = null;
            cbVeiculo.DataSource = veiculoContext.ListarVeiculos();
            cbVeiculo.DisplayMember = "Placa";
            cbVeiculo.SelectedIndex = -1;
            txtDescricao.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            txtValor.Text = "";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if(txtDescricao.Text != "" && txtValor.Text != "")
            {
                Multa multa = new Multa();

                multa.Descricao = txtDescricao.Text;
                multa.ValorMulta = Convert.ToDecimal(txtValor.Text);
                multa.Id = idMultaSelecionada;
                multaContext.AtualizarMulta(multa);

                cbVeiculo.DataSource = null;
                cbMulta.DataSource = null;
                cbVeiculo.DataSource = veiculoContext.ListarVeiculos();
                cbVeiculo.DisplayMember = "Placa";
                cbVeiculo.SelectedIndex = -1;
                txtDescricao.Text = "";
                txtMarca.Text = "";
                txtModelo.Text = "";
                txtPlaca.Text = "";
                txtValor.Text = "";
            }
        }
    }
}
