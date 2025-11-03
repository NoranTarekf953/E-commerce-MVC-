using BusinessLayer.Contracts;
using BusinessLayer.DTOs.Catogries;
using DataAccessLayer.Entities;
using DataAccessLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Managers
{
    public class CategoryManager : ICategoryManager
    {

        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddCategory(AddCategoryDTO category)
        {
            await _unitOfWork.Categories.Add(
                new Category
                {
                    Id = category.Id,
                    Name = category.Name,
                    ImageUrl = category.ImageUrl,
                    Description = category.Description,
                }
                );
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteCategory(int id)
        {
            var cat = await _unitOfWork.Categories.GetById(id);
            if (cat != null) { 
              await _unitOfWork.Categories.Update(cat);
                await _unitOfWork.CompleteAsync();
            }
        }

        public async Task<List<GetAllCategoriesDto>> GetAllCategories()
        {
            var categories = await _unitOfWork.Categories.GetAll();
            var AllCategories = categories
                .Select(c => new GetAllCategoriesDto { 
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl,
                    Description = c.Description,
                    ProductCount = c.Products.Count()
                }).ToList();

            return AllCategories;


        }

        public async Task<GetCategoryByIdDTO> GetCategoryById(int id)
        {
            var cat = await _unitOfWork.Categories.GetById(id);
             

                return new GetCategoryByIdDTO
                {
                    Id = cat.Id,
                    Name = cat.Name,
                    ImageUrl = cat.ImageUrl,
                    Description = cat.Description,


                };  
            
        }

        public async Task UpdateCategory(UpdateCategoryDTO category)
        {
            var updated = await _unitOfWork.Categories
                .Update(
                new Category
                {
                    Id = category.Id,
                    Name = category.Name,
                    ImageUrl = category.ImageUrl,
                    Description = category.Description,

                }
                );
            await _unitOfWork.CompleteAsync();

           
        }
    }
}
