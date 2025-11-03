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
    public class CartItemsConfiguration : IEntityTypeConfiguration<CartItems>
    {
        public void Configure(EntityTypeBuilder<CartItems> builder)
        {
            builder.HasKey(c=>c.Id);

            builder.HasOne(c => c.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(c=>c.Cart)
                .WithMany(c=>c.Items)
                .HasForeignKey(c=>c.CartId)
                .OnDelete(DeleteBehavior.Cascade);


                
        }
    }
}
