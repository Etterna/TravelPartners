using System.Web.Mvc;

namespace TravelPartners.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Users()
        {
            return RedirectToAction("Index", "Users");
        }
    }
}