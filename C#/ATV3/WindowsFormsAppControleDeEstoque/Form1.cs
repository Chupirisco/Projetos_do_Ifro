using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppControleDeEstoque.Formulario;
using WindowsFormsAppControleDeEstoque.Formulario.Alterar;
using WindowsFormsAppControleDeEstoque.Formulario.Listar;

namespace WindowsFormsAppControleDeEstoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarSecao_Click(object sender, EventArgs e)
        {
            CadastrarSecao form = new CadastrarSecao();
            form.ShowDialog();
        }

        private void btCadastrarProdutos_Click(object sender, EventArgs e)
        {
            CadastrarProdutos form = new CadastrarProdutos();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarCategoria form = new CadastrarCategoria();
            form.ShowDialog();
        }

        private void btPesquisarProdutos_Click(object sender, EventArgs e)
        {
            ListarProdutos form = new ListarProdutos();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListarCategorias form = new ListarCategorias();
            form.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListarSecao form = new ListarSecao();
            form.ShowDialog();
        }

        private void btFiltrarCategoria_Click(object sender, EventArgs e)
        {
            AlterarProduto form = new AlterarProduto();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlterarCategoria form = new AlterarCategoria();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AlterarSecao form = new AlterarSecao();
            form.ShowDialog();
        }
    }
}
