using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MysqlCoreConsole
{
    public class BudgetDataContext : DbContext
    {
        public DbSet<Album> Albuns { get; set; }

        public DbSet<Musica> Musicas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("Server=localhost;port=3306;User Id=root;Password=manager;Database=treinaweb");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}
