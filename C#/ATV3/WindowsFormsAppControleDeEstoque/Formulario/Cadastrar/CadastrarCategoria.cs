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

namespace WindowsFormsAppControleDeEstoque.Formulario
{
    public partial class CadastrarCategoria : Form
    {
        
        public CadastrarCategoria()
        {
            InitializeComponent();
        }
        
        private void btSalvar_Click_1(object sender, EventArgs e)
        {
            CategoriaContext categoriaContext = new CategoriaContext();
            if (txtNome.Text != "")
            {

                Categoria categoria = new Categoria()
                {
                    Nome = txtNome.Text,
                };

               
                categoriaContext.InserirCategoria(categoria);

                MessageBox.Show("Seção cadastrada com sucesso!", "Sistema de Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();

            }
            else
            {

                MessageBox.Show("ERRO AO SALVAR: Todos os campos devem ser preenchidos!", "Sistema de Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtNome.Clear();
        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
            txtNome.Clear();
        }

        private void btVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
