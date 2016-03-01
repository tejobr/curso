using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using H2O.LojaVirtual.Dominio.Repositorio;

namespace H2O.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

      private ProdutosRepositorio oRepositorio;

      public int ProdutosPorPagina = 8;

      public ActionResult ListaProdutos(int pagina=1)
        {
         oRepositorio = new ProdutosRepositorio();

         var oProdutos = oRepositorio.Produtos
            .OrderBy(p => p.Descricao)
            .Skip((pagina - 1) * ProdutosPorPagina)
            .Take(ProdutosPorPagina);

         return View(oProdutos);
         
        }
    }
}