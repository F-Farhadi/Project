using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sample01_OnlineShoping.Models.EFCore
{
    public class OnlineShopDbContext : DbContext
    {


        #region [- OnConfiguring(DbContextOptionsBuilder optionsBuilder) -]
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer("Server=DESKTOP-5UQLMMU;Integrated Security = True;Database=OnlineShop;");// DESKTOP - 5UQLMMU; Integrated Security = True

            base.OnConfiguring(optionsBuilder);
        }
        #endregion

        #region [- Aggregation -]
        #region [- Product -]
        public DbSet<Models.DomainModel.Aggregations.ProductAggregation.ProductCategory> ProductCategory { get; set; }
        public DbSet<Models.DomainModel.Aggregations.ProductAggregation.Product> Product { get; set; }
        #endregion
        #endregion


        #region [- OnModelCreating(ModelBuilder modelBuilder) -]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.DomainModel.Aggregations.ProductAggregation.ProductCategory>()
                .HasKey(pc => pc.ID);
            modelBuilder.Entity<Models.DomainModel.Aggregations.ProductAggregation.ProductCategory>()
                .Property(pc => pc.Title)
                .HasMaxLength(50);


            modelBuilder.Entity<Models.DomainModel.Aggregations.ProductAggregation.Product>()
                .HasKey(p=>p.ID);
            modelBuilder.Entity<Models.DomainModel.Aggregations.ProductAggregation.Product>()
                .Property(p => p.ProductName)
                .HasMaxLength(50);
            modelBuilder.Entity<Models.DomainModel.Aggregations.ProductAggregation.Product>()
                .HasOne(p => p.Category)
                .WithMany(pc => pc.Products)
                .HasForeignKey(p=>p.CategoryRef);
            //base.OnModelCreating(modelBuilder);
        }
        #endregion

    }
}
