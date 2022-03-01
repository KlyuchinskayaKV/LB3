using _181701c_task_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace _181701c_task_3.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Add(int id)
        {
            return View(Storage.Products.FirstOrDefault(product => product.Id == id));
        }
    }
}
