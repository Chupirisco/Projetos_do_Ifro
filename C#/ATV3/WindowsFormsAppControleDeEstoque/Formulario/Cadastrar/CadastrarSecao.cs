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
    public partial class CadastrarSecao : Form
    {
        public CadastrarSecao()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btSalvar_Click(object sender, EventArgs e)
        {            
            SecaoContext secaoContext = new SecaoContext();
            if (txtNome.Text != "" && txtNumero.Text != "")
            {
                            
                    Secao secao = new Secao()
                    {                         
                        Nome = txtNome.Text,                        
                        Numero = Convert.ToInt32(txtNumero.Text)
                    };

                secaoContext.InserirSecao(secao);
                          
                    MessageBox.Show("Seção cadastrada com sucesso!", "Sistema de Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   
                    txtNome.Clear();                   
                    txtNumero.Clear();
                               
            }
            else
            {
               
                MessageBox.Show("ERRO AO SALVAR: Todos os campos devem ser preenchidos!", "Sistema de Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtNome.Clear();           
            txtNumero.Clear();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
             txtNome.Clear();
            txtNumero.Clear();
        }


    }
}
