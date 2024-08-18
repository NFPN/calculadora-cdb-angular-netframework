using System.Web.Mvc;

namespace Projeto.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "API RUNNING";
            return View();
        }
    }
}
