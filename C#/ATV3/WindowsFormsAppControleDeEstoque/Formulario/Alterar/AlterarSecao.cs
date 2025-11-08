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
    public partial class AlterarSecao : Form
    {
        Secao secaoSelecionado = new Secao();
        SecaoContext secaoContext = new SecaoContext();
        public AlterarSecao()
        {
            InitializeComponent();
            cbEscolher.DataSource = secaoContext.ListarSecao().ToList();
            cbEscolher.DisplayMember = "Nome";
            cbEscolher.SelectedIndex = -1;

            txtNome.Text = "";
            txtNumero.Text = "";
        }

        private void cbEscolher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEscolher.SelectedItem is Secao sec)
            {
                secaoSelecionado = sec;
                txtNome.Text = sec.Nome;
                txtNumero.Text = sec.Numero.ToString();

            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtNumero.Text != "")
            {
                Secao sec = new Secao();

                sec.IdSecao = secaoSelecionado.IdSecao;
                sec.Nome = txtNome.Text;
                sec.Numero =Convert.ToInt32(txtNumero.Text);

                secaoContext.AtualizarSecao(sec);


                cbEscolher.SelectedIndex = -1;
                txtNome.Text = "";
                txtNumero.Text = "";


            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cbEscolher.SelectedIndex = -1;
            txtNome.Text = "";
            txtNumero.Text = "";
        }
    }
}
