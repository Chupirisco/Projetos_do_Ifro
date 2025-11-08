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

namespace WindowsFormsAppControleDeEstoque.Formulario.Listar
{
    public partial class ListarCategorias : Form
    {
        public ListarCategorias()
        {
            InitializeComponent();

            CategoriaContext cat = new CategoriaContext();
            var listarCategorias = cat.ListarCategorias().ToList();

            dtTabela.DataSource = listarCategorias.ToList();

        }

     
    }
}
