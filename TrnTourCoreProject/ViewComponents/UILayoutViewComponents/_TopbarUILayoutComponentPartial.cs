using Microsoft.AspNetCore.Mvc;

namespace TrnTourCoreProject.ViewComponents.UILayoutViewComponents
{
    public class _TopbarUILayoutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
