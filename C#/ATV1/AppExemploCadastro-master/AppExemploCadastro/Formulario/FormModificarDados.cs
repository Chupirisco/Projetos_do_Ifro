using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppExemploCadastro.Contexto;
using AppExemploCadastro.Models;

namespace AppExemploCadastro.Formulario
{
    public partial class FormModificarDados : Form
    {
        int numExec = 0;
        public List<Pessoa> ListaPessoas = new List<Pessoa>();

        public FormModificarDados()
        {
            InitializeComponent();
            PessoaContext context = new PessoaContext(); 
            ListaPessoas = context.ListarPessoas(); 
            comboBox1.DataSource = new List<Pessoa>(ListaPessoas); 
            comboBox1.DisplayMember = "Nome";
            comboBox1.SelectedIndex = -1;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtRegistroGeral.Clear();
            txtNome.Select();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                var pessoaSelec = ListaPessoas[comboBox1.SelectedIndex];

                Pessoa pessoa = new Pessoa
                {
                    Id = pessoaSelec.Id,
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    RegistroGeral = txtRegistroGeral.Text,
                    Email = txtEmail.Text
                };

                PessoaContext context = new PessoaContext();
                context.AtualizarPessoa(pessoa);

                txtNome.Clear();
                txtCpf.Clear();
                txtEmail.Clear();
                txtRegistroGeral.Clear();
                txtNome.Select();

                ListaPessoas = context.ListarPessoas();
                comboBox1.DataSource = new List<Pessoa>(ListaPessoas);
                comboBox1.SelectedIndex = -1;
                numExec = 0;
            }
            else
            {
                MessageBox.Show("Selecione um Candidato!", "2°B INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1 && numExec > 0)
            {
                var pessoaSelec = ListaPessoas[comboBox1.SelectedIndex];
                txtNome.Text = pessoaSelec.Nome;
                txtCpf.Text = pessoaSelec.Cpf;
                txtRegistroGeral.Text = pessoaSelec.RegistroGeral;
                txtEmail.Text = pessoaSelec.Email;
            }
            numExec++;
        }
    }
}
