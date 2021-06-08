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

        public static void ConfigureForSqlServer()
        {
            try
            {
                //Local
                String baseConnectionString = @"Data Source=LAPTOP-9SVDO2G2\SQLEXPRESS;user id=sa;password=123456789;MultipleActiveResultSets=True";

                Database.DefaultConnectionFactory = new System.Data.Entity.Infrastructure.SqlConnectionFactory(baseConnectionString);
            }
            catch (Exception ex)
            {

            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Documento>().HasMany(p => p.detalle).WithMany().Map(mc =>
            //{}
        }
    }
}
