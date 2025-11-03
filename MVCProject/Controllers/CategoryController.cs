using BusinessLayer.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryManager _categoryManager;
        public IActionResult Index()
        {
            return View();
        }
    }
}
