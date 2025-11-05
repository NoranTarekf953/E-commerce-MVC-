using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EcomercePresentationLayer.ActionRequest
{
    public class CreateProductActionRequest
    {
        //[Required(ErrorMessage = "Name is required")]
        //[StringLength(100, ErrorMessage = "Name Lenghth connot be less than 5 char ")]
        //[Remote(action:"CheckName",controller:"Product", ErrorMessage ="Name is used Before")]
        public string ProductName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

    }
}
