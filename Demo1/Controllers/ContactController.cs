using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}