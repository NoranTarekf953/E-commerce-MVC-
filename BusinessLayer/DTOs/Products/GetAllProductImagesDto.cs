using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs.Products
{
    public class GetAllProductImagesDto
    {
        //public int ImageId { get; set; }
        //public int ProductId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

    }
}
