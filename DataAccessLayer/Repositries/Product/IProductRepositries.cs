using DataAccessLayer.Entities;
using DataAccessLayer.Repositries.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositries.Product
{
    public  interface IProductRepositries:IGenericRepo<Products>
    {
        //Task<List<Products>> GetAllProducts();
        ////Task<List<String>> GetProductImages(int id);
        //Task<Products?> GetProductById(int id);
        Task<List<Products>> GetProductsByCategory(int categoryId);

        //Task AddProduct(Products product);
        //Task UpdateProduct(Products product);
        //Task DeleteProduct(int id);



    }
}
