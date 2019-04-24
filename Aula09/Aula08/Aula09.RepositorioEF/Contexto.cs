using System.Data.Entity;
using Aula08.Dominio;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;

namespace Aula09.RepositorioEF
{
    public class Contexto : Dbcontext
    {
        public Contexto()
            : base("DBprojetos")
        {

        }

        public DbSet<Editora> Editoras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Editora>().Property(x =>x.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(75);
        }

        internal void SaveChange()
        {
            throw new NotImplementedException();
        }
    }
}
