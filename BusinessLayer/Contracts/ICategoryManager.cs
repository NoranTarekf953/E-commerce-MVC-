using BusinessLayer.DTOs.Catogries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public interface ICategoryManager
    {
        Task<List<GetAllCategoriesDto>> GetAllCategories();
        Task<GetCategoryByIdDTO> GetCategoryById(int id);

        Task AddCategory(AddCategoryDTO category);

        Task UpdateCategory (UpdateCategoryDTO category);

        Task DeleteCategory(int id);

        
    }
}
