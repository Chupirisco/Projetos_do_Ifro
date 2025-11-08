using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppControleDeEstoque.Contexto;
using WindowsFormsAppControleDeEstoque.Models;

namespace WindowsFormsAppControleDeEstoque.Formulario.Alterar
{
    public partial class AlterarProduto : Form
    {
         Produto produtoSelecionado = new Produto();
         ProdutoContext produtoContext = new ProdutoContext();
        public AlterarProduto()
        {
            InitializeComponent();
            cbEscolher.DataSource = produtoContext.ListarProdutos().ToList();
            cbEscolher.DisplayMember = "Nome";
            cbEscolher.SelectedIndex = -1;


            txtNome.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            
            if (txtNome.Text != "" && txtPreco.Text != "" && txtQuantidade.Text != "")
            {
                Produto prod = new Produto();

                prod.IdProduto = produtoSelecionado.IdProduto;
                prod.Nome = txtNome.Text;
                prod.Preco = Convert.ToInt32(txtPreco.Text);
                prod.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                produtoContext.AtualizarProduto(prod);


                cbEscolher.SelectedIndex = -1;
                txtNome.Text = "";
                txtPreco.Text = "";
                txtQuantidade.Text = "";

            }
        }

        private void cbEscolher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEscolher.SelectedItem is Produto prod )
            {
                produtoSelecionado = prod;
                txtNome.Text = prod.Nome;
                txtPreco.Text = prod.Preco.ToString();
                txtQuantidade.Text = prod.Quantidade.ToString();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cbEscolher.SelectedIndex = -1;
            txtNome.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
        }
    }
}
