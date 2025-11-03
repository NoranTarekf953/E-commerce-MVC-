using BusinessLayer.Contracts;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.VMs.Product;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductManager _productManager;
        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }
        public async Task<IActionResult> GetAllProduct()
        {
            var products = await  _productManager.GetAll();
            //var getProducts = products.Select( async p => new AllProducts
            // {
            //     Name = p.Name,
            //     Description = p.Description,
            //     Price = p.Price,
            //     Discount = p.Discount,
            //     StockQuantity = p.StockQuantity,
            //     Images =await  _productManager.GetProductImages(p.Id)
            //}).ToList();
            // var res = await Task.WhenAll(getProducts).ContinueWith(t => t.Result.ToList());

            var getProducts = new List<AllProducts>();

   

            //        Name = p.Name,
            //        Description = p.Description,
            //        Price = p.Price,
            //        Discount = p.Discount,
            //        StockQuantity = p.StockQuantity,
            //        Images = images
            //    });
            //}
            return View( getProducts);
        }

        
    }
}
