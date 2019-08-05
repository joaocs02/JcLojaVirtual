using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Jc.LojaVirtual.Dominio.Repositorio;
using Jc.LojaVirtual.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Jc.LojaVirtual.Dominio.Repositorio
{
    public class EfDBContext : DbContext
    {
         public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
    }
}
