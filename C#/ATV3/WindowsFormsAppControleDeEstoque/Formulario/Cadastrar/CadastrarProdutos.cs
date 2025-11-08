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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppControleDeEstoque.Formulario
{
    public partial class CadastrarProdutos : Form
    {

        int idSecao;
        int idCategoria;

        

        public List<Secao> listaSecao = new List<Secao>();
        public List<Categoria> listaCategoria = new List<Categoria>();

        public CadastrarProdutos()
        {
            InitializeComponent();
            CategoriaContext categoriaContext = new CategoriaContext();
            SecaoContext secaoContext = new SecaoContext();

            listaSecao = secaoContext.ListarSecao().ToList();
            listaCategoria = categoriaContext.ListarCategorias().ToList();

            cbSecao.DataSource = listaSecao.ToList();
            cbSecao.DisplayMember = "Nome";
            cbSecao.SelectedIndex = -1;
            cbCategoria.DataSource = listaCategoria.ToList();
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.SelectedIndex = -1;
            
        }


        
       
        private void btSalvar_Click(object sender, EventArgs e)
        {
            ProdutoContext produtoContext = new ProdutoContext();

                if (txtNome.Text != "" && txtPreco.Text != "" && txtQuantidade.Text != "")
                {
            
                    if (cbSecao.SelectedItem is Secao secaoSelecionada)
                    {

                        Produto produto = new Produto()
                        {
                            Nome = txtNome.Text,
                            Preco = Convert.ToDecimal(txtPreco.Text),
                            Quantidade = Convert.ToInt32(txtQuantidade.Text),                                             

                        };


                        produtoContext.InserirProduto(produto, idSecao, idCategoria);


                        MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     
                        txtNome.Clear();
                        txtPreco.Clear();
                        txtQuantidade.Clear();
                        cbSecao.SelectedIndex = -1;
                      
                    }
                }
                else
                {
                  MessageBox.Show("Todos os campos devem ser preenchidos!","Erro ao salvar",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }         
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            cbSecao.SelectedIndex = -1;
            cbCategoria.SelectedIndex = -1;
        }

        private void cbSecao_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbSecao.SelectedItem is Secao secaoSelecionada)
            {
                idSecao = secaoSelecionada.IdSecao;
            }
           
        }
        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedItem is Categoria secaoSelecionada)
            {
                idCategoria = secaoSelecionada.IdCategoria;
            }
        }
        

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

       
    }
}
