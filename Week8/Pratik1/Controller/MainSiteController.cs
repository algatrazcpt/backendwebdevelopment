namespace Pratik1.Controller
{
    public class MainSiteController:Controller
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
