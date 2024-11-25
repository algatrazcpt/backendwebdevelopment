using Microsoft.AspNetCore.Mvc;
namespace Pratik1.Controller
{
    public class MainSiteController:ControllerBase
    {
        public IActionResult Index()
        {
            return Content("Index");
        }
        public IActionResult AboutPage()
        {
            return Content("AboutPage");
        }

    }
}
