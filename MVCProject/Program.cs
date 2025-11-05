using BusinessLayer.Contracts;
using BusinessLayer.Managers;
using DataAccessLayer.Context;
using DataAccessLayer.Entities.Account;
using DataAccessLayer.Repositries.Category;
using DataAccessLayer.Repositries.CategoryRepo;
using DataAccessLayer.Repositries.Generic;
using DataAccessLayer.Repositries.Product;
using DataAccessLayer.UnitOfWork;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MVCProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IProductRepositries, ProductRepositries>();
            builder.Services.AddScoped<IProductManager, ProductManager>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<ICategoryRepositries, CategoryRepositries>();
            builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
                //.LogTo(Console.WriteLine, LogLevel.Information);
            }
            );

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddIdentity<ApplicationUser,IdentityRole<int>>
                (options => {
                    options.SignIn.RequireConfirmedAccount = true;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequiredLength = 6; 
                    })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();
            //app.MapRazorPages()
            //   .WithStaticAssets();

            app.Run();
        }
    }
}
