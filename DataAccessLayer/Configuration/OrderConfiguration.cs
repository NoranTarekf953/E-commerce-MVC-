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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o=>o.Id);

            builder.Property(o => o.ShippingAddress)
                .IsRequired()
                .HasMaxLength(200);


            builder.Property(o => o.Status)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(o=>o.PaymentMethod)
                .IsRequired()
                .HasConversion<string>();

            builder.HasMany(o=>o.OrderItems)
                .WithOne(o => o.Order)
                .HasForeignKey(o=>o.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.Payment)
                .WithOne(o => o.Order)
                .HasForeignKey<Payment>(o=>o.OrderId);

            //in payment config
            //builder.HasOne(o => o.Order)
                //.WithOne(o => o.Payment)
                //.HasForignKey(o=>o.OrderId);









        }
    }
}
