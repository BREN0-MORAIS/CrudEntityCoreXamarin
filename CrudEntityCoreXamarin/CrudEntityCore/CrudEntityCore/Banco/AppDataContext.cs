using App1.Banco;
using Microsoft.EntityFrameworkCore;
using System;

namespace SqliteApp.Standard
{
    public class AppDataContext : DbContext
    { 
        public DbSet<Product> Products { get; set; }

        private readonly string _databasePath;

        public AppDataContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={Constantes.CaminhoDoBanco}");
        }

    }
}
