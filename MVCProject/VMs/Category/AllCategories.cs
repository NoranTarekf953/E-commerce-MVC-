using BusinessLayer.DTOs.Products;
using PresentationLayer.VMs.Product;

namespace PresentationLayer.VMs.Category
{
    public class AllCategories
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        public string ImageUrl { get; set; } = string.Empty;



        public ICollection<AllProducts> Products { get; set; } = new HashSet<AllProducts>();

    }
}
