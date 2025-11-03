using DataAccessLayer.Context;
using DataAccessLayer.Repositries.CategoryRepo;
using DataAccessLayer.Repositries.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositries.Category
{
    public class CategoryRepositries:GenericRepo<Entities.Category>,ICategoryRepositries
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepositries(ApplicationDbContext context) : base(context) { }
       

        //public async Task AddCategory(Entities.Category product)
        //{
        //    _context.Categories.Add(product);
        //    _context.SaveChanges();
        //}

        //public async Task DeleteCategory(int id)
        //{
        //    var deletedCat = await _context.Categories
        //        .FirstOrDefaultAsync(c => c.Id == id);
        //    if (deletedCat == null) return;
        //    _context.Categories.Remove(deletedCat);
        //}

        //public async Task<List<Entities.Category>> GetAllCategories()
        //{
        //    return await _context.Categories
        //        .AsNoTracking()
        //        .ToListAsync();
        //}

        //public async Task<Entities.Category?> GetCategoryById(int id)
        //{
        //    var cat = await _context.Categories
        //        .FirstOrDefaultAsync (c => c.Id == id);
        //    if (cat == null) return null;
        //    return cat;
        //}

        //public async Task UpdateCategory(Entities.Category category)
        //{
        //    var cat = await _context.Categories
        //        .FirstOrDefaultAsync(c => c.Id == category.Id);
        //    if (cat == null) return ;
        //    _context.Categories.Update(category);
        //}
    }
}
