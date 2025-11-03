using DataAccessLayer.Entities;
using DataAccessLayer.Repositries.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositries.CategoryRepo
{
    public interface ICategoryRepositries : IGenericRepo<Entities.Category>
    {
        //Task<List<Entities.Category>> GetAllCategories();
        ////Task<List<String>> GetProductImages(int id);
        //Task<Entities.Category?> GetCategoryById(int id);

        //Task AddCategory(Entities.Category product);
        //Task UpdateCategory(Entities.Category product);
        //Task DeleteCategory(int id);
    }
}
