using Microsoft.AspNetCore.Mvc;

namespace TrnTourCoreProject.ViewComponents.DefaultViewComponents
{
    public class _ScriptDefaultComponentPartial:ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
