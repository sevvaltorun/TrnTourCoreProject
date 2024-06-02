
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;


namespace TrnTourCoreProject.ViewComponents.DefaultViewComponents
{
    public class _PopularDestinationDefaultComponentPartial : ViewComponent

    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
       public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

    }

}
