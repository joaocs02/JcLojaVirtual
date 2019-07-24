using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jc.LojaVirtual.Dominio.Entidades
{

    public class Produto
    {
        public int ProdutoID { get; set; }
        public string nome { get; set; }

        public string descricap { get; set; }

        public decimal preco { get; set; }

        public string categoria { get; set; }

    }
    
}
