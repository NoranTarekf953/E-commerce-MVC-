using BusinessLayer.DTOs.Products;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Extensions
{
    public static class ProductExtension
    {
        public static Products ToEntity(this GetAllProductDto dto)
        => new Products
        {
            Id = dto.Id,
            Name = dto.Name,
            Price = dto.Price,
            StockQuantity = dto.StockQuantity,
            Discount = dto.Discount,
            //Description = dto.d,
            ProductImages = dto.Images
        };


        public static GetAllProductDto ToDto(this Products entity)
            => new GetAllProductDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                StockQuantity = entity.StockQuantity,
                Discount = entity.Discount,
                //Description = entity.Description,
                Images = entity.ProductImages

            };


    }
}
