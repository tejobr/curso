using H2O.LojaVirtual.Web.HtmlHelpers;
using H2O.LojaVirtual.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using System.Text;
using System.Linq;
using System.Web;

namespace H2O.LojaVirtual.UnitTest
{
   [TestClass]
   public class UnitTestH2O
   {
      [TestMethod]
      public void TestarAPaginacao()
      {

         //Arrange

         HtmlHelper html = null;
         Paginacao paginacao = new Paginacao
         {

            PaginaAtual = 3,
            ItensTotal = 28,
            ItensPorPagina = 10

         };

         Func<int, string> paginaUrl = i => "Pagina" + i;

         //Act

         MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

         //Assert

         Assert.AreEqual(
                     @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                  + @"<a class=""btn btn-default"" href=""Pagina2"">2</a>"
                  + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina3"">3</a>", resultado.ToString()
                  
                  );

      }
   }
}
