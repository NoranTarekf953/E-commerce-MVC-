using BusinessLayer.Contracts;
using BusinessLayer.DTOs.Products;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositries.Product;
using DataAccessLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Managers
{
    public class ProductManager : IProductManager
    {
        //private readonly IProductRepositries _productRepositries;
        private readonly IUnitOfWork _unitOfWork;

        public ProductManager(IUnitOfWork unitOfWork)
        {
            //_productRepositries = productRepositries;
            _unitOfWork = unitOfWork;
        }

        public async Task AddProduct(AddProductDTO product)
        {
            await _unitOfWork.Products.Add(new Products
            {
                Id = product.ProductId,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                Discount = product.Discount,
                StockQuantity = product.StockQuantity,
                ProductImages = product.Images,
            });
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _unitOfWork.Products.GetById(id);
            if (product != null) {
                _unitOfWork.Products.Delete(id);
                await _unitOfWork.CompleteAsync();
            }
        }

        //public  async Task<List<String>> GetProductImages(int id)
        //{
        //    return await _productRepositries.GetProductImages(id);
        //}
        public  async Task<List<GetAllProductDto>> GetAll()
        {
            var products = await _unitOfWork.Products.GetAll();

            var productDtos =  products.Select(async p =>
            {
                //var images = await GetProductImages(p.Id);
                return new GetAllProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    //Description = p.Description,
                    Price = p.Price,
                    Discount = p.Discount,
                    StockQuantity = p.StockQuantity,
                    Images = p.ProductImages
                    //images.Select(img => new GetAllProductImagesDto
                    //{
                    //    ImageUrl = img
                    //}).ToList()
                };
            });

            return (await Task.WhenAll(productDtos)).ToList();
    //        var productsList = products.Select( async p =>
    //         new GetAllProductDto
    //         {
    //             Id = p.Id,
    //             Name = p.Name,
    //             Description = p.Description,
    //             Price = p.Price,
    //             Discount = p.Discount,
    //             StockQuantity = p.StockQuantity,
    //             Images = ( await GetProductImages(p.Id))
    //.Select(  imgurl =>  new GetAllProductImagesDto
    //{
    //    ImageUrl = imgurl
    //})
    //.ToList()

    //         }
    //         ).ToList();
    //        var results = new List<GetAllProductDto>();

    //        foreach (var productTask in productsList)
    //        {
    //            var product = await productTask; // waits for each task to finish before next
    //            results.Add(product);
    //        }

    //        return results;

            //return await Task.WhenAll(productsList).ContinueWith(t => t.Result.ToList());




        }

        public async Task<GetProductByIdDTO> GetProductById(int id)
        {
            var product = await _unitOfWork.Products.GetById(id);
            return new GetProductByIdDTO
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Discount = product.Discount,
                StockQuantity = product.StockQuantity,
                Images = product.ProductImages,
                Description = product.Description

            };
        }

        //public async Task<GetProductsWithCatDTO> GetProductsWithCatList(int catId)
        //{
        //    var productWithCat = await _unitOfWork.Products.GetProductsByCategory(catId);
        //    return new GetProductsWithCatDTO { 
        //        CategoryName = productWithCat
                
        //    };
        //}

        public async Task UpdateProduct(UpdateProductDTO product)
        {
            var updated = _unitOfWork.Products.Update(
                new Products
                {
                    Id = product.ProductId,
                    Name = product.Name,
                    Price= product.Price,
                    Discount = product.Discount,
                    StockQuantity = product.StockQuantity,
                    Description = product.Description
                    ,ProductImages = product.Images
                }
                
                );
            await _unitOfWork.CompleteAsync();

        }
    }
        
           

      
    }


