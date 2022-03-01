using _181701c_task_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace _181701c_task_3.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult List()
        {
            return View(Storage.Products);
        }
        public IActionResult Details(int id)
        {
            return View(Storage.Products.FirstOrDefault(product => product.Id == id));
        }
    }
}
