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
    public partial class ListarSecao : Form
    {
        public ListarSecao()
        {
            InitializeComponent();
           SecaoContext sec = new SecaoContext();
            var listarSecao = sec.ListarSecao().ToList();

            dtTabela.DataSource = listarSecao.ToList();
        }
    }
}
