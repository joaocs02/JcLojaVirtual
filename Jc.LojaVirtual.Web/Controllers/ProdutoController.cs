using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jc.LojaVirtual.Dominio.Repositorio;

namespace Jc.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private RepositorioProdutos _repositorio;
        // GET: Produto
        public ActionResult Index()
        {
            _repositorio = new RepositorioProdutos();
            var produtos = _repositorio.Produtos.Take(10);

            return View(produtos);
        }
    }
}