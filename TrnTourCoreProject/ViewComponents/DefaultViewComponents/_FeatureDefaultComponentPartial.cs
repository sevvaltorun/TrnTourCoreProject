using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TrnTourCoreProject.ViewComponents.DefaultViewComponents
{
    public class _FeatureDefaultComponentPartial:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDal());

        public IViewComponentResult Invoke()
        {
         //   var values = featureManager.TGetList();
       
            return View();
        }
    }
}
