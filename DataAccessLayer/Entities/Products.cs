using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Products
    {
        public   int Id { get; set; }
        public   string Name { get; set; } = string.Empty;

        public   string Description { get; set; }= string.Empty;

        [Range(50,1000000)]
        [Precision(18, 2)]
        [Required]
        public   decimal Price { get; set; }
        [Precision(18, 2)]
        public   decimal Discount { get; set; }

        [Range(0,100000)]
        public   int StockQuantity { get; set; }

        //Images in new class'
        //nav prop
        [ForeignKey(nameof(Category))]
        public   int CategoryId { get; set; }
        public   Category? Category { get; set; }

        public string ProductImages { get; set; } = string.Empty;
        public ICollection<CartItems> CartItems { get; set; }= new HashSet<CartItems>();
        public ICollection<OrderItems> OrderItems { get; set; }=new HashSet<OrderItems>();
    }
    //create class for Images Url
    //public class ProductImages
    //{
    //    //forign key
    //    [Key]
    //    public int ImageId { get; set; }
    //    [ForeignKey(nameof(Product))]
    //    public   int ProductId { get; set; }
    //    public Products Product { get; set; }
    //    public  string ImageUrl { get; set; } = string.Empty;



        
    //}
}
