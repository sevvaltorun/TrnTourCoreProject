using Microsoft.AspNetCore.Mvc;

namespace TrnTourCoreProject.ViewComponents.DestinationViewComponents
{
    public class _HeaderDestinationComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
