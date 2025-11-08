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

namespace WindowsFormsAppControleDeEstoque.Formulario
{
    public partial class ListarProdutos : Form
    {
        public ListarProdutos()
        {
            InitializeComponent();
            ProdutoContext prod = new ProdutoContext();
            var listarProdutos = prod.ListarProdutos().ToList();

            dtTabela.DataSource = listarProdutos.ToList();
        }
    }
}
