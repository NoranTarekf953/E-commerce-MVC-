using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Category
    {
        [Key]
        public  int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        [StringLength(50, MinimumLength =2 , ErrorMessage ="Invalid length of Name")]
        public  string Name { get; set; } = string.Empty;

        [StringLength(200, MinimumLength =2, ErrorMessage = "Invalid length of description")]
        public  string Description { get; set; } = string.Empty ;

        [Url(ErrorMessage = "Invalid image URL format.")]
        [Display(Name = "Category Image URL")]
        [Required]

        public  string ImageUrl { get; set; } =string.Empty;

        public  DateTime CreateAt { get; set; } = DateTime.Now;


        public  ICollection<Products> Products { get; set; } = new HashSet<Products>();

    }
}
