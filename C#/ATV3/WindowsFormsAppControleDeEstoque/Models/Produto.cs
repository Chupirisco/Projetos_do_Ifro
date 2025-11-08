using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppControleDeEstoque.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }            
        public string Nome { get; set; }     
        public decimal Preco { get; set; }   
        public int Quantidade { get; set; }
        public int IdSecao { get; set; }
        public int IdCategoria { get; set; }

    }
}
