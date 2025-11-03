using BusinessLayer.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public interface IProductManager
    {
        Task<List<GetAllProductDto>> GetAll();
        //Task<List<String>> GetProductImages(int id);
        Task<GetProductByIdDTO> GetProductById(int id);

        //Task<GetProductsWithCatDTO> GetProductsWithCatList(int catId);

        Task AddProduct(AddProductDTO product);

        Task DeleteProduct(int id);

        Task UpdateProduct(UpdateProductDTO product);




    }
}
