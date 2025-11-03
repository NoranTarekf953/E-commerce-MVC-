//using DataAccessLayer.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccessLayer.Configuration
//{
//    internal class ProductImageConfiguration : IEntityTypeConfiguration<ProductImages>
//    {
//        public void Configure(EntityTypeBuilder<ProductImages> builder)
//        {
//            builder.HasKey(pi => pi.ImageId);
//            builder.Property(pi => pi.ImageUrl)
//                .IsRequired()
//                .HasMaxLength(1000);
//            builder.HasOne(pi => pi.Product)
//                .WithMany(p => p.ProductImages)
//                .HasForeignKey(pi => pi.ProductId)
//                .OnDelete(DeleteBehavior.Cascade);
//            // --- Seed Product Images ---
//            builder.HasData(
//                new ProductImages
//                {
//                    ImageId = 1,
//                    ProductId = 1,
//                    ImageUrl = 
//                    "https://example.com/images/products/iphone15pro-1.jpg"
//                },
//                new ProductImages
//                {
//                    ImageId = 2,
//                    ProductId = 1,
//                    ImageUrl =
//                    "https://example.com/images/products/iphone15pro-2.jpg"
//                },
//                new ProductImages
//                {
//                    ImageId = 3,
//                    ProductId = 2,
//                    ImageUrl = 
//                    "https://example.com/images/products/leatherjacket-1.jpg"
//                },
//                new ProductImages
//                {
//                    ImageId = 4,
//                    ProductId = 3,
//                    ImageUrl =
//                    "https://example.com/images/products/pragmaticprogrammer-1.jpg"
//                }
//            );

//        }
//    }
//}
