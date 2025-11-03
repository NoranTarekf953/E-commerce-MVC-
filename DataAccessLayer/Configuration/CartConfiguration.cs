using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configuration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(c=> c.Items)
                .WithOne(i=>i.Cart)
                .HasForeignKey(i=> i.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c=>c.Customer)
                .WithOne(c=>c.Cart)
                .HasForeignKey<Customer>(c=>c.CartId)
                .OnDelete(DeleteBehavior.Cascade);




        }
    }
}
