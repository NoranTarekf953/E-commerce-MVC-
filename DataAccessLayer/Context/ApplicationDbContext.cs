using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options){ }
    
    public DbSet<Products> Products { get; set; }
        //public DbSet<ProductImages> ProductImages { get; set; }


    public DbSet<Category> Categories { get; set; }

    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItems> OrderItems { get; set; }

    public DbSet<Cart> Carts { get; set; }

public DbSet<CartItems> CartItems { get; set; }
        public DbSet<Payment> Payment { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

    //        builder.Entity<Customer>()
    //    .HasOne(c => c.Cart)
    //    .WithOne(cart => cart.Customer)
    //    .HasForeignKey<Customer>(c => c.CartId)
    //    .OnDelete(DeleteBehavior.Restrict);

    //        builder.Entity<Customer>()
    //.HasOne(c => c.Payment)
    //.WithMany()
    //.HasForeignKey(c => c.PaymentId)
    //.OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(builder);
        }
    }

}
