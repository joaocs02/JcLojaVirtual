using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jc.LojaVirtual.Dominio.Repositorio;
using Jc.LojaVirtual.Dominio.Entidades;

namespace Jc.LojaVirtual.Dominio.Repositorio
{
    public class RepositorioProdutos
    {
        private readonly EfDBContext _Context = new EfDBContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _Context.Produtos; }
        }
    }
}
