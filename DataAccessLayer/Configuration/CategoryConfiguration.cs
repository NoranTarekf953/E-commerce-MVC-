using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(c => c.Description)
                .HasMaxLength(200);
            builder.Property(c => c.ImageUrl)
                .IsRequired();
            builder.Property(c => c.CreateAt)
                .HasDefaultValueSql("GETDATE()");
            builder.HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasData(
              new Category
              {
                  Id = 1,
                  Name = "Electronics",
                  Description = "Devices and gadgets including phones, laptops, and accessories.",
                  ImageUrl = "https://example.com/images/categories/electronics.jpg",
                  CreateAt = new DateTime(2024, 01, 01)

              },
              new Category
              {
                  Id = 2,
                  Name = "Fashion",
                  Description = "Clothing, shoes, and accessories for all genders.",
                  ImageUrl = "https://example.com/images/categories/fashion.jpg",
                  CreateAt = new DateTime(2024, 01, 01)

              },
              new Category
              {
                  Id = 3,
                  Name = "Books",
                  Description = "Wide range of educational and entertainment books.",
                  ImageUrl = "https://example.com/images/categories/books.jpg",
                  CreateAt = new DateTime(2024, 01, 01)

              }
          );

        }
    }
}
