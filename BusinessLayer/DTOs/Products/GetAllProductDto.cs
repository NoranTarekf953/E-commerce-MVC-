using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs.Products
{
    public class GetAllProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        //public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public int StockQuantity { get; set; }
        public String Images { get; set; } = string.Empty;



    }

    public class GetProductByIdDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public int StockQuantity { get; set; }
        public String Images { get; set; } = string.Empty;

        public string CategoryName {  get; set; } = string.Empty;


    }

    public class GetProductsWithCatDTO
    {
        public string CategoryName { get; set;}= string.Empty;
        public ICollection<GetAllProductDto> Products { get; set; }= new List<GetAllProductDto>();

    }

    public class AddProductDTO
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public int StockQuantity { get; set; }
        public String Images { get; set; } = string.Empty;

    }

    public class UpdateProductDTO { 
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public int StockQuantity { get; set; }
        public String Images { get; set; } = string.Empty;


    }
    public class DeleteProductDTO { 
        public int ProductId { get; set; }
        public string Name { get; set; }= string.Empty;

    }
}

