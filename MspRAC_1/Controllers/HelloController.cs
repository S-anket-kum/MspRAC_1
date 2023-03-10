using Microsoft.AspNetCore.Mvc;

namespace MspRAC_1.Controllers
{
    public class HelloController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}
