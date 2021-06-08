namespace GestOn1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using BibliotecaClases2;

    public partial class Context : DbContext
    {
        public DbSet<Documento> Documentos { get; set; }
        public Context()
            : base("name=GestOn")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Documento>().HasMany(p => p.detalle).WithMany().Map(mc =>
            //{}
        }
    }
}
