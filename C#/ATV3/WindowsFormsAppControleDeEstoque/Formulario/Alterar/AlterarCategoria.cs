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
    public partial class AlterarCategoria : Form
    {
         Categoria categoriaSelecionado = new Categoria();
        CategoriaContext categoriaContext = new CategoriaContext();
        public AlterarCategoria()
        {
            InitializeComponent();
            cbEscolher.DataSource = categoriaContext.ListarCategorias().ToList();
            cbEscolher.DisplayMember = "Nome";
            cbEscolher.SelectedIndex = -1;

            txtNome.Text = "";            
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                Categoria cat = new Categoria();

                cat.IdCategoria = categoriaSelecionado.IdCategoria;
                cat.Nome = txtNome.Text;               

                categoriaContext.AtualizarCategoria(cat);


                cbEscolher.SelectedIndex = -1;
                txtNome.Text = "";
               

            }
        }

        private void cbEscolher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEscolher.SelectedItem is Categoria cat)
            {
                categoriaSelecionado = cat;
                txtNome.Text = cat.Nome;
                
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cbEscolher.SelectedIndex = -1;
            txtNome.Text = "";
        }
    }
}
