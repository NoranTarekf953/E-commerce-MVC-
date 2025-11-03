using DataAccessLayer.Context;

using DataAccessLayer.Entities;
using DataAccessLayer.Repositries.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositries.Product
{
    public class ProductRepositries: GenericRepo<Products>, IProductRepositries
    {
        private readonly ApplicationDbContext _context;
        public ProductRepositries(ApplicationDbContext context) : base(context) { }
       
        //public async Task< List<Products>> GetAllProducts()
        //{
        //    //await using var context = _context.CreateDbContext();
        //    return await _context.Products
        //        .AsNoTracking()
        //        //.Include(p=>p.ProductImages)
        //        .ToListAsync();

        //}
        //public async Task<List<String>> GetProductImages(int id)
        //{
        //    //var productImages = 
        //    await using var context = _context.CreateDbContext();
        //     return await   context.ProductImages
        //        .Where(pi => pi.ProductId == id)
        //        .Select(img => img.ImageUrl).ToListAsync();

        //    //return productImages;
        //    //return productImages.SelectMany(images =>
        //    //images.Select(img => img.ImageUrl)).ToList();
        //}

        //public async Task<Products?>GetProductById(int id)
        //{
        //    //await using ApplicationDbContext? context = _context.CreateDbContext();
        //    var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        //    if (product == null) return null;
        //    return product;
        //}
        public async Task<List<Products>> GetProductsByCategory(int categoryId) {
            return await _context.Products
                .Where(p => p.CategoryId == categoryId)
                .Include(c=>c.Category)
                .ToListAsync();
        }

        //for buyer and admin
        //public async Task AddProduct(Products products)
        //{
        //    //await using ApplicationDbContext? context = _context.CreateDbContext();

        //    //if (products == null) return ;
        //    _context.Products.Add(products);
        //    _context.SaveChanges();

        //}
        // public async Task UpdateProduct(Products product)
        //{
        //    //await using ApplicationDbContext? context = _context.CreateDbContext();

        //    var updatedProduct = await _context.Products
        //        .FirstOrDefaultAsync(p=>p.Id == product.Id);
        //    if (updatedProduct == null) return;
        //    _context.Products.Update(product);
            

        //}

        //public async Task DeleteProduct(int id)
        //{

        //    //await using ApplicationDbContext? context = _context.CreateDbContext();
        //    var deletedProduct = await _context.Products
        //        .FirstOrDefaultAsync(p => p.Id == id);
        //    if(deletedProduct == null) return;
        //    _context.Products.Remove(deletedProduct);

        }

    }
//}
