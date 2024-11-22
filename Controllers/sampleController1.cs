using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    public class sampleController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
