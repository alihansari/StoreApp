using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Abstract;
using Services.Abstract;

namespace StoreApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IServiceManager _manager;

        public CategoryController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.CategoryService.GetAllCategories(false).ToList();
            return View(model);
        }
    }
}