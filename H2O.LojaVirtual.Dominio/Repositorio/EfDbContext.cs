using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H2O.LojaVirtual.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace H2O.LojaVirtual.Dominio.Repositorio
{
   public class EfDbContext : DbContext
   {
   
      public DbSet<Produto> Produtos { get; set; }

      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
         
         modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         modelBuilder.Entity<Produto>().ToTable("Produtos");

      } 
   }
}
