using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using H2O.LojaVirtual.Dominio.Repositorio;
using H2O.LojaVirtual.Web.Models;

namespace H2O.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

      private ProdutosRepositorio oRepositorio;

      public int ProdutosPorPagina = 8;

      public ViewResult ListaProdutos(int pagina=1)
        {

         oRepositorio = new ProdutosRepositorio();

         ProdutosViewModel model = new ProdutosViewModel
         {


            Produtos  = oRepositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina),

            Paginacao = new Paginacao
            {

               PaginaAtual = pagina,
               ItensPorPagina = ProdutosPorPagina,
               ItensTotal = oRepositorio.Produtos.Count()
             }

          };
               

         return View(model);
         
        }
    }
}