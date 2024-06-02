using Microsoft.AspNetCore.Mvc;

namespace TrnTourCoreProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
