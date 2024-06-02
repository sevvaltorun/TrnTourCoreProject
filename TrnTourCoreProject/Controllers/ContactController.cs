using Microsoft.AspNetCore.Mvc;

namespace TrnTourCoreProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
    }
}
