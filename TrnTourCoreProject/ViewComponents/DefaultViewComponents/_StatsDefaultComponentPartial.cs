using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TrnTourCoreProject.ViewComponents.DefaultViewComponents
{
    public class _StatsDefaultComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2= c.Teams.Count();
            ViewBag.v3 = "275";
            return View();
        }
    }
}
