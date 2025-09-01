using System;
using Microsoft.EntityFrameworkCore;

namespace SistemaProtoB
{
    public class Repository : DbContext
    {
        private static readonly String _connectionParams = @"server=ifnmg.edu.br;port=3306;uid=root;pwd=;database=sistemaprotob";

        public DbSet<Usuario> Usuarios { get; set; }

        public Repository() => this.Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_connectionParams);
        }
    }
}
