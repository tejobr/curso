using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using H2O.LojaVirtual.Dominio.Repositorio;

namespace H2O.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {

      private ProdutosRepositorio oRepositorio;

      // GET: Produto
      public ActionResult Index()
        {
         oRepositorio = new ProdutosRepositorio();

         var oProdutos = oRepositorio.Produtos ;

         return View(oProdutos);

        }
    }
}