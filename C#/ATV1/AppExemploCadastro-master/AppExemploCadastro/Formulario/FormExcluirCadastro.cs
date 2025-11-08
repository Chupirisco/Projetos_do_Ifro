using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AppExemploCadastro.Contexto;
using AppExemploCadastro.Models;

namespace AppExemploCadastro.Formulario
{
    public partial class FormExcluirCadastro : Form
    {
         PessoaContext pessoaContext;
         List<Pessoa> listarPessoas; 

        public FormExcluirCadastro()
        {
            InitializeComponent();
            pessoaContext = new PessoaContext();
            

            listarPessoas = pessoaContext.ListarPessoas();
            cbPessoa.DataSource = listarPessoas.ToList();
            cbPessoa.DisplayMember = "Nome";            
            cbPessoa.SelectedIndex = -1;

            txtNome.Text = "";
            txtCpf.Text ="";
            txtRegistroGeral.Text = "";
            txtEmail.Text = "";
        }

        

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (cbPessoa.SelectedIndex != -1)
            {
                var pessoaSelec = listarPessoas[cbPessoa.SelectedIndex];
                txtNome.Text = pessoaSelec.Nome;
                txtCpf.Text = pessoaSelec.Cpf;
                txtEmail.Text = pessoaSelec.Email;

                pessoaContext.ExcluirCadastro(pessoaSelec.Id);
                listarPessoas = pessoaContext.ListarPessoas();
                cbPessoa.DataSource = null;
                cbPessoa.DataSource = listarPessoas.ToList();
                cbPessoa.DisplayMember = "Nome";
                cbPessoa.SelectedIndex = -1;

                txtNome.Text = "";
                txtCpf.Text = "";
                txtRegistroGeral.Text = "";
                txtEmail.Text = "";

            }
            else
            {
                MessageBox.Show("Selecione uma pessoa!", "Excluir Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cbPessoa.DataSource = null;
            pessoaContext = new PessoaContext();

            listarPessoas = pessoaContext.ListarPessoas();
            cbPessoa.DataSource = listarPessoas.ToList();
            cbPessoa.DisplayMember = "Nome";
            cbPessoa.SelectedIndex = -1;

            
            txtNome.Text = "";
            txtCpf.Text = "";
            txtRegistroGeral.Text = "";
            txtEmail.Text = "";
        }

        private void cbPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPessoa.SelectedIndex != -1)
            {

                if (cbPessoa.SelectedItem is Pessoa pessoaSelecionada)
                {
                    txtNome.Text = pessoaSelecionada.Nome;
                    txtCpf.Text = pessoaSelecionada.Cpf;
                    txtRegistroGeral.Text = pessoaSelecionada.RegistroGeral;
                    txtEmail.Text = pessoaSelecionada.Email;
                }
            }
        }
    }
}
