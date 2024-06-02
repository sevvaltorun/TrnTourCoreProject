using Microsoft.AspNetCore.Mvc;

namespace TrnTourCoreProject.ViewComponents.DefaultViewComponents
{
    public class _SliderDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
