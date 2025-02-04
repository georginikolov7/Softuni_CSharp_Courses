﻿
namespace Invoices.Data
{
    using Invoices.Data.Models;
    using Microsoft.EntityFrameworkCore;
    public class InvoicesContext : DbContext
    {
        public InvoicesContext()
        {
        }

        public InvoicesContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ProductClient> ProductsClients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductClient>()
                .HasKey(x => new { x.ProductId, x.ClientId });

        }
    }
}
