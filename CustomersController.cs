using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    public class CustomersController : Controller
    {
        public IActionResult Service()
        {
            return View();
        }
    }
}
