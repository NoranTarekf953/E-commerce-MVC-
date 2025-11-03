using BusinessLayer.DTOs.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs.Catogries
{
    public class GetAllCategoriesDto
    {
        //public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;


        public string ImageUrl { get; set; } = string.Empty;

        public int ProductCount { get; set; }



        //public ICollection<GetAllProductDto> Products { get; set; } = new HashSet<GetAllProductDto>();


    }

    public class GetCategoryByIdDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        public string ImageUrl { get; set; } = string.Empty;



        public ICollection<GetAllProductDto> Products { get; set; } = new HashSet<GetAllProductDto>();



    }

    public class AddCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;


        public string ImageUrl { get; set; } = string.Empty;

        public ICollection<AddProductDTO> Products { get; set; } = new HashSet<AddProductDTO>();


    }



}
