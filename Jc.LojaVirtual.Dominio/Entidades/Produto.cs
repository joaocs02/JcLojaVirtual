using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jc.LojaVirtual.Dominio.Entidades
{

    public class Produto
    {
        public int ProdutoId { get; set; }
        public int ProdutoCodigo { get; set; }
        public string ProdutoDescricao { get; set; }

        public string ProdutoDescricaoResumida { get; set; }

        public string MarcaDescricao { get; set; }

        public string ModeloDescricao { get; set; }


        public string ProdutoModeloCodigo { get; set; }

        public string CorCodigo { get; set; }

        public string TamanhoCodigo { get; set; }

        public string UnidadeVenda { get; set; }

        public decimal Preco { get; set; }


    }
    
}
