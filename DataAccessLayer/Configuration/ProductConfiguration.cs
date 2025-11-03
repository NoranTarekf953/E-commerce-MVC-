using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
         
       

        public void Configure(EntityTypeBuilder<Products> builder)
        {
           builder.HasKey(p=>p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Description)
                .HasMaxLength(1000);
            builder.Property(p => p.ProductImages)
                .HasMaxLength(1000);

           builder.Property(p => p.Price)
        .HasColumnType("decimal(18,2)");

            builder.HasOne(p=>p.Category)
                .WithMany(c=>c.Products)
                .HasForeignKey(p=>p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p=>p.CartItems)
                .WithOne(c=>c.Product)
                .HasForeignKey(p=>p.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p=>p.OrderItems)
                .WithOne(c=>c.Product)
                .HasForeignKey(p=>p.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            //builder.HasMany(p=>p.ProductImages)
            //    .WithOne(c=>c.Product)
            //    .HasForeignKey(p=>p.ProductId)
            //    .OnDelete(DeleteBehavior.Cascade);

            
            // --- Seed Products ---
            builder.HasData(
                new Products
                {
                    Id = 1,
                    Name = "iPhone 15 Pro",
                    Description = "Latest Apple smartphone with advanced features.",
                    Price = 45000m,
                    Discount = 2000m,
                    StockQuantity = 20,
                    CategoryId = 1,
                    ProductImages = 
                 "https://example.com/images/products/iphone15pro-1.jpg"

                        
                },
                new Products
                {
                    Id = 2,
                    Name = "Men’s Leather Jacket",
                    Description = "Stylish black leather jacket for men.",
                    Price = 2500m,
                    Discount = 200m,
                    StockQuantity = 50,
                    CategoryId = 2,
                    ProductImages = 
                    "https://example.com/images/products/iphone15pro-2.jpg"
                        
                },
                new Products
                {
                    Id = 3,
                    Name = "The Pragmatic Programmer",
                    Description = "Classic book for software developers.",
                    Price = 600m,
                    Discount = 50m,
                    StockQuantity = 120,
                    CategoryId = 3,
                    ProductImages = 
                      "https://example.com/images/products/pragmaticprogrammer-1.jpg"

                      
                }
            );

           

            //builder.HasData
            //     (
            //       new Products { Id = 1, Name = "Delicious Pizza", Description = "Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit.", Price = 20.00m, ProductImages = [new ProductImages { ImageUrl = "images/product-11.png" }] },
            //       new Products { Id = 2, Name = "Delicious Burger", Description = "Magna voluptatem repellendus sed eaque.", Price = 15.00m, ProductImages = [new ProductImages { ImageUrl = "images/product-11.png" }] },
            //       new Products
            //       {
            //           Id = 3,
            //           Name = "Delicious Pizza",
            //           Description = "Veniam debitis quaerat officiis quasi cupiditate quo.",
            //           Price = 17.00m
            //           ,
            //           ProductImages = [new ProductImages { ImageUrl = "images/product-11.png" }]
            //       },
            //       new Products { Id = 4, Name = "Delicious Pasta", Description = "Magna voluptatem repellendus sed eaque.", Price = 18.00m, ProductImages = [new ProductImages { ImageUrl = "images/product-11.png" }] },
            //       new Products { Id = 5, Name = "French Fries", Description = "Quasi cupiditate quo, quisquam velit.", Price = 10.00m, ProductImages = [new ProductImages { ImageUrl = "images/product-11.png" }] },
            //       new Products { Id = 6, Name = "Delicious Pizza", Description = "Veniam debitis quaerat officiis quasi cupiditate quo.", Price = 15.00m, ProductImages = [new ProductImages { ImageUrl = "images/product-11.png" }] },
            //       new Products { Id = 7, Name = "Tasty Burger", Description = "Magna voluptatem repellendus sed eaque.", Price = 12.00m, ProductImages = [new ProductImages { ImageUrl = "images/product-11.png" }] },
            //       new Products { Id = 8, Name = "Tasty Burger", Description = "Veniam debitis quaerat officiis quasi cupiditate quo.", Price = 14.00m, ProductImages = [new ProductImages { ImageUrl = "images/product-11.png" }] },
            //       new Products { Id = 9, Name = "Delicious Pasta", Description = "Magna voluptatem repellendus sed eaque.", Price = 10.00m, ProductImages = [new ProductImages { ImageUrl = "images/product-11.png" }] }
            //     );
        }
    }
}
